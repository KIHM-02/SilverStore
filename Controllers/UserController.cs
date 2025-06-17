using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SilverStore.Models;

namespace SilverStore.Controllers
{
    public class UserController: Controller
    {
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}

