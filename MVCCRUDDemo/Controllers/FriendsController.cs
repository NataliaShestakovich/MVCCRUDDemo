﻿using Microsoft.AspNetCore.Mvc;
using MVCCRUDDemo.Models.Domain;
using MVCCRUDDemo.Services.Interfaces;

namespace MVCCRUDDemo.Controllers
{
    public class FriendsController : Controller
    {
        private readonly IFriendService _friendService;
        
        public FriendsController(IFriendService friendService)
        {
            _friendService = friendService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var _friends = _friendService.GetFriends();

            return View(_friends);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Friend addFriendRequest)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _friendService.Create(addFriendRequest);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var friend = _friendService.Get(id);

            if (friend != null)
            {
                return View("Details", friend);
            }

            return NotFound("The requested object was not found");
        }

        [HttpPost]
        public IActionResult Details(Friend model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _friendService.Update(model);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Friend model)
        {
            _friendService.Delete(model);

            return RedirectToAction("Index");
        }
    }
}
