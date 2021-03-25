using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication19.Models;
namespace WebApplication19.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var t = new List<Student>();
            var user1 = new Student();
            user1.id = 1;
            user1.name = "tosiq";
            user1.password = "123";
            user1.age = 20;

            var user2 = new Student();
            user2.id = 2;
            user2.name = "laiq";
            user2.password = "123";
            user2.age = 21;

            var user3 = new Student();
            user3.id = 3;
            user3.name = "saneeya";
            user3.password = "123";
            user3.age = 22;

            t.Add(user1);
            t.Add(user2);
            t.Add(user3);
            ViewBag.a = t;


            return View();
        }
    }
}