using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tutorial.Portal.EntityModel;
using Tutorial.Portal.Service;
using Tutorial.Portal.ViewModel;

namespace Tutorial.Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICommonService<User> _userService;
        private readonly IMapper _mapper;

        public HomeController(ICommonService<User> userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var users = _mapper.Map<IEnumerable<UserViewModel>>(_userService.GetAll());
            return View(users);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.Add(user);
            }
            return View();
        }
    }
}