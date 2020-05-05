using MVC_Lab01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Lab01.Controllers
{
    public class FriendController : Controller
    {
        private static List<FriendModel> friendList = new List<FriendModel>() { 
            new FriendModel(){ Ime="John Doe", FriendId = 22, MestoZiveenje = "Kratovo"},
            new FriendModel(){ Ime="Jill and Spock", FriendId = 66, MestoZiveenje = "Space"},
        };

        // GET: Friend
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowAllFriends() 
        {
            return View(friendList);
        }

        
        public ActionResult AddNewFriend()
        {
            var newFriend = new FriendModel();
            return View(newFriend);
        }

        [HttpPost]
        public ActionResult AddNewFriend(FriendModel model) 
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            friendList.Add(model);
            return View("ShowAllFriends", friendList);
        }


        public ActionResult UpdateFriend(int id)
        {
            var friend = friendList.ElementAt(id);
            return View(friend);
        }
        [HttpPost]
        public ActionResult UpdateFriend(FriendModel model)
        {

            if (!ModelState.IsValid) 
            {
                return View(model) ;
            }
            friendList.RemoveAt(model.ID);
            friendList.Insert(model.ID, model);
            return View("ShowAllFriends", friendList);
        }

        public ActionResult DeleteFriend(int id)
        {
            friendList.RemoveAt(id);
            return View("ShowAllFriends", friendList);
        }
    }

}