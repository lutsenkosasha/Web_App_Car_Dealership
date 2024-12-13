using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Car_Dealership.Models;
using Car_Dealership.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace Car_Dealership.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Метод для отображения страницы регистрации
        public IActionResult Register()
        {
            return View();
        }

        // Обработка регистрации
        [HttpPost]
        public async Task<IActionResult> Register(User model)
        {
            if (ModelState.IsValid)
            {
                // Устанавливаем уровень доступа 3 для клиента при регистрации
                model.AccessLevel = 3;

                _context.Users.Add(model);
                await _context.SaveChangesAsync();

                // Перенаправление на страницу логина
                return RedirectToAction("Login");
            }

            // Если модель невалидна, возвращаем на страницу регистрации с ошибками
            return View(model);
        }

        // Метод для отображения страницы логина
        public IActionResult Login()
        {
            return View();
        }

        // Обработка логина
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == model.Username && u.Password == model.Password);

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Неправильный логин или пароль.");
                return View(model);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.AccessLevel.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            // Перенаправление на нужную страницу
            return RedirectToAction("Index", "Car");  // Перенаправляем на CarController -> Index
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            // Перенаправление на страницу логина после выхода
            return RedirectToAction("Login", "User");
        }
    }
}
