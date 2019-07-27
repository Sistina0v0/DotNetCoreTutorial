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
            return View(new UserViewModel());
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.Add(user);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = _userService.GetById(id);
            return View(_mapper.Map<UserViewModel>(user));
        }


        [HttpPost]
        public IActionResult Edit(UserViewModel user)
        {
            var userInfo = _userService.GetById(user.Id);
            userInfo.UserName = user.UserName;
            userInfo.Gender = user.Gender;
            userInfo.BirthDate = user.BirthDate;
            _userService.Edit(userInfo);
            return RedirectToAction("Index");
        }
    }
}