using Labs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Labs.Controllers
{
    public class UserController : Controller
    {
        private static List<User> ListOfUsers
            = new List<User>()
            {
                new User(){ID=100,FirstName="Ahmed",LastName="Mamdouh",Email="ahmadmamdouh3.gmail.com",
                UserName="a-mamdouh",Password="123456",Gender=false},

                new User(){ID=101,FirstName="Naira",LastName="Anwar",Email="Naira0anwar.gmail.com",
                UserName="naira.Anwar1",Password="123456",Gender=true}
            };
            

        // GET: User
        public ActionResult Index()
        {
            return View(ListOfUsers);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(User u)
        {
            ListOfUsers.Add(u);
            return Redirect("/User/Index");
        }
    }
}