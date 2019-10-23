using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedBeltPreview.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;



namespace RedBeltPreview.Controllers
{
    public class HomeController : Controller
    {
        private const string ViewName = "Dashboard";
        private HomeContext dbContext;
        public HomeController(HomeContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost("Register")]
        public IActionResult Register(User regUser)
        {
            Console.WriteLine(regUser);
            if(ModelState.IsValid)
            {   
                Console.WriteLine("Register if valid");
                HttpContext.Session.SetString("Email", regUser.Email);
                HttpContext.Session.SetInt32("UserId", regUser.UserId);
                dbContext.Users.Add(regUser);
                dbContext.SaveChanges();
                ViewBag.User = regUser;
                Console.WriteLine(ViewBag.User.Email);
                return Redirect("/Wedding/Dashboard");
            }
            else
            {   
                Console.WriteLine("else");
                return View("Index");
            }
        }
        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpPost("Login")]
        public IActionResult Login(LogUser UserSubmission)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault( u => u.Email == UserSubmission.LoginEmail);
                HttpContext.Session.SetString("Email", userInDb.Email);
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                
                if(userInDb == null)
                {
                    
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Index");
                }
                else
                {
                 ViewBag.User = userInDb;
                 return Redirect("/Wedding/Dashboard");
                }
                }
            
            else
            {
                return View("Index");
            }
        }
       public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


