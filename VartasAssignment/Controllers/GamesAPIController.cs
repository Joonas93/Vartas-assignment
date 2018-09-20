using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using VartasAssignment.Models;

namespace VartasAssignment.Controllers
{
    public class GamesAPIController : ApiController
    {
        private GameDBContext db = new GameDBContext();

        // api/GamesAPI palauttaa kaikki pelit
        public IQueryable<Game> GetGames()
        {
            return db.Games;
        }

        //  api/GamesAPI?id=5 palauttaa tietyn pelin id:n mukaan
        [ResponseType(typeof(Game))]
        public IHttpActionResult GetGameById(int id)
        {
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return NotFound();
            }

            return Ok(game);
        }
        //api/GamesAPI?name=< nimi > Palauttaa kaikki kyseisen nimiset pelit
        public IHttpActionResult GetGamesByName(string name)
        {
            List<Game> games = new List<Game>();
            foreach (var item in db.Games)
            {
                if(item.Name.ToLower() == name.ToLower())
                {
                    games.Add(item);
                    
                }
            }
            if (games.Count == 0)
            {
                return NotFound();
            }
            else
            {
                IEnumerable<Game> result = games;
                return Ok(result);
            }                    
        }
        //api/GamesAPI?category=<kategoria> Palauttaa kaikki kyseisen kategorian pelit
        public IHttpActionResult GetGamesByCategory(string category)
        {
            List<Game> games = new List<Game>();
            foreach (var item in db.Games)
            {
                if (item.Category.ToLower() == category.ToLower())
                {
                    games.Add(item);

                }
            }
            if (games.Count == 0)
            {
                return NotFound();
            }
            else
            {
                IEnumerable<Game> result = games;
                return Ok(result);
            }
        }






    }
}