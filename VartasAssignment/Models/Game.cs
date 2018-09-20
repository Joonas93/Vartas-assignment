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
        [Display(Name = "Hinta")]
       [RegularExpression(@"^-?\d*\,?\d*", ErrorMessage = "Käytä pilkkua sekä tarkista syöte!")]
        
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
        public DbSet<Game> Games { get; set; }
    }
}