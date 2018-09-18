using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VartasAssignment.Models;

namespace VartasAssignment.Controllers
{
    public class StoryController : Controller
    {
        // GET: Story
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]      
        public ActionResult Story([Bind(Include = "Name,Sex,Age,Color,FontSize")] Story story)
        {
            if (ModelState.IsValid)
            {
                return View(story);
                
            }

            return RedirectToAction("Index");
        }
    }
}