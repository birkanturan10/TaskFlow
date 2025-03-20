using BusinessLayer;
using DataLayer;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskFlowContext _context;

        public HomeController(TaskFlowContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMessage = "Lütfen tüm alanları doğru doldurun!";
                return View(model);
            }

            //E-posta kayıtlı mı?
            if (_context.Users.Any(u => u.Email == model.Email))
            {
                ViewBag.ErrorMessage = "Bu e-posta adresi zaten kayıtlı!";
                return View(model);
            }

            //Kullanıcı oluşturma
            var newUser = new User
            {
                NameSurname = model.NameSurname,
                Email = model.Email,
                Password = model.Password
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            return RedirectToAction("Login", "Home");
        }
    }
}
