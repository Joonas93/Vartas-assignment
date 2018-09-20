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
        
        [HttpGet]
        public ActionResult Index()
        {
            //Luodaan lista tietokannan riveistä viewbagiin
            ViewBag.gamedb = db.Games.ToList();
            Game game = new Game();

            return View(game);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(int? Id)
        {
            //Luodaan lista tietokannan riveistä viewbagiin
            ViewBag.gamedb = db.Games.ToList();
            Game game = new Game();
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            game = db.Games.Find(Id);
            

            return View(game);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int? Id)
        {
            if(Id == null)
            {
               return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = db.Games.Find(Id);
            db.Games.Remove(game);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update([Bind(Include = "ProductID,Category,Name,Price,Description")] Game game)
        {
            
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            game.Update(); //Päivitetään timestamp
            db.Entry(game).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind(Include = "ProductID,Category,Name,Price,Description")] Game game)
        {
            
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            game.Update();//päivitetään timestamp
            db.Games.Add(game);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
    }

