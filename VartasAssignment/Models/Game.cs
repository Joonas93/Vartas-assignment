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
        [Display(Name = "Tuotenumero")]
        public int ProductID { get; set; }
        [Display(Name = "Kategoria")]
        public string Category { get; set; }
        [Display(Name = "Nimi")]
        public string Name { get; set; }
        [Display(Name = "Hinta")]
        public double Price { get; set; }
        [Display(Name = "Kuvaus")]
        public string Description { get; set; }
        [Display(Name = "Muokattu")]
        public DateTime Edited { get; set; }
    }
    ;
    public class GameDBContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}