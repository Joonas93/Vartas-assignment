using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace VartasAssignment.Models
{
    public class Game
    {
        [Key]
        [Required]
        [Display(Name = "Tuotenumero")]
        public int ProductID { get; set; }
        [Required]
        [Display(Name = "Kategoria")]
        public string Category { get; set; }
        [Required]
        [Display(Name = "Nimi")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^-?\d*\,?\d*", ErrorMessage = "Käytä pilkkua sekä tarkista syöte!")]
        [Display(Name = "Hinta")]
        public decimal Price { get; set; }        
        [Display(Name = "Kuvaus")]
        public string Description { get; set; }
        [Display(Name = "Muokattu")]
        public DateTime Edited { get; set; }


        //Metodi kutsutaan ennen olion lisäystä tietokantaan.
        public void Update()
        {
            this.Edited = DateTime.Now;
        }
    }
    public class GameDBContext : DbContext
    {
        public GameDBContext() : base("GameDBContext")
        {
            

            //Database.SetInitializer<GameDBContext>(new DropCreateDatabaseIfModelChanges<GameDBContext>());
           // Database.SetInitializer<GameDBContext>(new DropCreateDatabaseAlways<GameDBContext>());
            Database.SetInitializer(new GameDBInitializer());
        }
        public DbSet<Game> Games { get; set; }
    }

    public class GameDBInitializer : DropCreateDatabaseAlways<GameDBContext>
    {


        protected override void Seed(GameDBContext context)
        {
            IList<Game> gamelist = new List<Game>();

            gamelist.Add(new Game() { Name = "World of Tanks", Category = "Sotapeli", Description = "Taistele tankeilla", Price = 0.99m, Edited = DateTime.Now });
            gamelist.Add(new Game() { Name = "World of Warcraft", Category = "RPG", Description = "Seikkaile örkeillä", Price = 14.99m, Edited = DateTime.Now });
            gamelist.Add(new Game() { Name = "Call of Duty", Category = "Sotapeli", Description = "Taistele tantereella", Price = 19.99m, Edited = DateTime.Now });
            gamelist.Add(new Game() { Name = "Hearts of Iron", Category = "Strategia", Description = "Valloita maailma", Price = 9.99m, Edited = DateTime.Now });
            gamelist.Add(new Game() { Name = "Destiny", Category = "Scifi", Description = "Taistele avaruudessa", Price = 29.99m, Edited = DateTime.Now });
            context.Games.AddRange(gamelist);

            base.Seed(context);
        }
    }
}
