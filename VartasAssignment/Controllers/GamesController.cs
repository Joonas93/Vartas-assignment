using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VartasAssignment.Models;

namespace VartasAssignment.Controllers
{
    public class GamesController : Controller
    {
        private GameDBContext db = new GameDBContext();
           
        public ActionResult Index()
        {
            return View(db.Games.ToList());
        }

        
    }
}
