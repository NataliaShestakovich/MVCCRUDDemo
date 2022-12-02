using Microsoft.AspNetCore.Mvc;
using MVCCRUDDemo.Models;
using MVCCRUDDemo.Models.Domain;
using System.Net;

namespace MVCCRUDDemo.Controllers
{
    public class FriendsController : Controller
    {
        List<Friend> friends;

        public FriendsController()
        {
            friends = Storage.friends;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(friends);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Friend addFriendRequest)
        {
           addFriendRequest.FriendID = Guid.NewGuid();

            Storage.friends.Add(addFriendRequest);

            Storage.UpdateOfFriends();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details (Guid id)
        {
            var friend = Storage.friends.FirstOrDefault(x => x.FriendID== id);

            if (friend != null)
            {
                return View("Details", friend);
            }

            return NotFound("The requested object was not found");
        }

        [HttpPost]
        public IActionResult Details (Friend model)
        {
            var friend = Storage.friends.Find(x => x.FriendID == model.FriendID);
            
            var index = Storage.friends.IndexOf(friend);
            
            Storage.friends.RemoveAt(index);
            
            Storage.friends.Insert(index, model);

            Storage.UpdateOfFriends();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Friend model)
        {
            var friend = Storage.friends.Find(x => x.FriendID == model.FriendID);

            if (friend != null)
            {
                var index = Storage.friends.IndexOf(friend);

                Storage.friends.RemoveAt(index);

                Storage.UpdateOfFriends();

                return RedirectToAction("Index");
            }

           return NotFound("The requested object was not found");
        }
    }
}
