namespace VartasAssignment.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VartasAssignment.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VartasAssignment.Models.GameDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "VartasAssignment.Models.GameDBContext";
        }
        //Laitetaan seed-dataa tietokantaan
        protected override void Seed(VartasAssignment.Models.GameDBContext context)
        {
            context.Games.AddOrUpdate(m => m.ProductID,
                new Game() { Name = "World of Tanks", Category = "Sotapeli", Description = "Taistele tankeilla", Price = 0.99, Edited = DateTime.Now },
                new Game() { Name = "World of Warcraft", Category = "RPG", Description = "Seikkaile örkeillä", Price = 14.99, Edited = DateTime.Now },
                new Game() { Name = "Call of Duty", Category = "Sotapeli", Description = "Taistele tantereella", Price = 19.99, Edited = DateTime.Now },
                new Game() { Name = "Hearts of Iron", Category = "Strategia", Description = "Valloita maailma", Price = 9.99, Edited = DateTime.Now },
                new Game() { Name = "Destiny", Category = "Scifi", Description = "Taistele avaruudessa", Price = 29.99, Edited = DateTime.Now }
                );
        }
    }
}
