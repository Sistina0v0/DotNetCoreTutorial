using Microsoft.AspNetCore.Mvc;
using Tutorial.Portal.EntityModel;
using Tutorial.Portal.Service;

namespace Tutorial.Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoginService _loginService;
        private readonly ICommonService<User> _userService;

        public HomeController(ILoginService loginService, ICommonService<User> userService)
        {
            _loginService = loginService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View(_userService.GetAll());
        }
    }
}