using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedBeltPreview.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace RedBeltPreview.Controllers
{
    public class WeddingController : Controller
    {
        private HomeContext dbContext; 

        public WeddingController(HomeContext context)
        {
            dbContext = context;
        }
        

        public IActionResult Dashboard()
        {
            if(HttpContext.Session.GetInt32("Email") == null)
            {
                Console.WriteLine("Dashboard if sessions to logout");
                return RedirectToAction("Logout", "Home");
            }
            else
            {
                Console.WriteLine("Dashboard user logged in");
                List<Wedding> allWedding = dbContext.Weddings.Include( w => w.GuestList).ThenInclude( r => r.Guest).ToList(); 
                User userInDb = dbContext.Users.Include( u => u.myRsvps).ThenInclude( r => r.Attending).Include( u => u.createdWeddings).FirstOrDefault( u => u.UserId == HttpContext.Session.GetInt32("UserId"));
                ViewBag.UserId = userInDb.UserId;                
                return View("Dashboard", allWedding);
            }
        }    
        public IActionResult NewWedding()
        {
            if(HttpContext.Session.GetInt32("UserId")==null)
                {
                    Console.WriteLine("New Wedding no user");
                    return RedirectToAction("Logout", "Home");
                }
            else
                { 
                    
                    Console.WriteLine("New Wedding with user");
                    return View("NewWedding");
                }
        }

        [HttpPost("/Wedding/Create")]

        public IActionResult CreateWedding(Wedding NewWedding)
            {
            User userInDb = dbContext.Users.FirstOrDefault( u => u.UserId == HttpContext.Session.GetInt32("UserId"));

            if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Logout", "Home");
            }
            else
            {
                if(ModelState.IsValid)
                {
                    NewWedding.UserId = userInDb.UserId;
                    dbContext.Weddings.Add(NewWedding);
                    dbContext.SaveChanges();
                    return RedirectToAction("Dashboard");
                }
                else
                {
                    return View("NewWedding");
                }
            }

            }

            [HttpGet("/Wedding/{WeddingId}")]

            public IActionResult ShowWedding(int WeddingId)
            {
                if(HttpContext.Session.GetInt32("UserId")==null)
                {
                    return RedirectToAction("Logout", "Home");
                }
                else
                { 
                    Wedding display = dbContext.Weddings.Include(w => w.GuestList).ThenInclude(r => r.Guest).FirstOrDefault( w => w.WeddingID == WeddingId);
                    return View(display);
                }
            }
            [HttpGet("/Destroy/{WeddingId}")]

            public IActionResult DestroyWedding(int WeddingId)
            {
                if(HttpContext.Session.GetInt32("UserId")==null)
                {
                    return RedirectToAction("Logout", "Home");
                }
                else
                {
                    Console.WriteLine("destroy else");
                    Wedding delete = dbContext.Weddings.FirstOrDefault( w => w.WeddingID == WeddingId);
                    dbContext.Weddings.Remove(delete);
                    dbContext.SaveChanges();
                    return RedirectToAction("Dashboard");
                }

            }
            [HttpGet("rsvp/{weddingId}/{status}")]
            public IActionResult RSVP(int weddingId, string status)
            {
                if(HttpContext.Session.GetInt32("UserId")==null)
                {
                    return RedirectToAction("Logout", "Home");
                }
                else
                {
                    User userInDb = dbContext.Users.FirstOrDefault( u => u.UserId == HttpContext.Session.GetInt32 ("UserId"));
                    if(status == "add")
                    {
                       
                        Rsvp newRsvp = new Rsvp();
                        newRsvp.WeddingId = weddingId;
                        newRsvp.UserId = userInDb.UserId;
                        dbContext.Rsvps.Add(newRsvp);
                        dbContext.SaveChanges();
                    }
                    else if(status == "remove")
                    {
                        Rsvp delete = dbContext.Rsvps.FirstOrDefault( r => r.UserId == userInDb.UserId && r.WeddingId == weddingId);
                        dbContext.Rsvps.Remove(delete);
                        dbContext.SaveChanges();
                        
                    }
                    return RedirectToAction("Dashboard");
                }
            }
        }
    }
