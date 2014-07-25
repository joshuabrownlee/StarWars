using StarWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarWars.Controllers
{
    public class HomeController : Controller
    {
            List<Character> Characters= new List<Character>();
            List<Character> FilteredList = new List<Character>();
        

        //Constructor function for my HomeController Class the 
            public HomeController()
            {
            Characters.Add(new Jedi("Luke", "Human", "Green"));
            Characters.Add(new BountyHunter("Dog", "Human", "Gun"));
            Characters.Add(new Jedi("Tom", "IDK", "Green"));
            Characters.Add(new BountyHunter("Cat", "Cat", "Meow"));
            Characters.Add(new Jedi("Kevin", "Human", "Green"));
            Characters.Add(new BountyHunter("Dog", "Human", "Gun"));
            Characters.Add(new Jedi("Willie", "IDK", "Green"));
            Characters.Add(new BountyHunter("Cat", "Cat", "Meow"));
            Characters.Add(new Jedi("Terry", "Human", "Green"));
            Characters.Add(new BountyHunter("Dog", "Human", "Gun"));
            Characters.Add(new Jedi("Larry", "IDK", "Green"));
            Characters.Add(new BountyHunter("Cat", "Cat", "Meow"));
            Characters.Add(new Jedi("Joe", "Human", "Green"));
            Characters.Add(new BountyHunter("Dog", "Human", "Gun"));
            Characters.Add(new Jedi("Jeff", "IDK", "Green"));
            Characters.Add(new BountyHunter("Cat", "Cat", "Meow"));
            Characters.Add(new Jedi("Sam", "Human", "Green"));
            Characters.Add(new BountyHunter("Dog", "Human", "Gun"));
            Characters.Add(new Jedi("Mike", "IDK", "Green"));
            Characters.Add(new BountyHunter("Cat", "Cat", "Meow"));
                
                
                
                
            }
        //overloading is when you add two things posting to the same thing
        public ActionResult Index()
        {
           
            return View(Characters);
        }

        public ActionResult About()
        {

            return View(Characters);
        }
        public ActionResult Contact()
        {

            return View(Characters);
        }
        public ActionResult Jedi()
        {
          
           FilteredList = Characters.Where(c => c.MyType == Character.Type.Jedi).ToList();
            return View(FilteredList);
        }
        [HttpPost]
        public ActionResult Jedi(string name, string race, string sabercolor)
        {
            Characters.Add(new Jedi(name, race, sabercolor));
            FilteredList = Characters.Where(c => c.MyType == Character.Type.Jedi).ToList();
            return View(FilteredList);
        }
        public ActionResult BountyHunters()
        {

            FilteredList = Characters.Where(c => c.MyType == Character.Type.BountyHunter).ToList();
            return View(FilteredList);
        }
        [HttpPost]
        public ActionResult BountyHunters(string name, string race, string weapon)
        {
            Characters.Add(new BountyHunter(name, race, weapon));
            FilteredList = Characters.Where(c => c.MyType == Character.Type.BountyHunter).ToList();
            return View(FilteredList);
        }
        
    }
}