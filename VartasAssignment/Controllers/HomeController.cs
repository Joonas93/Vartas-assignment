using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VartasAssignment.Models;

namespace VartasAssignment.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
          
           //Ohjataan aloitussivuksi Storyyn tähän tehtävään
          return RedirectToAction("Index","Story");

        }

    }

    
}