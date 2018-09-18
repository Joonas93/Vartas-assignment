using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VartasAssignment.Models
{
    public class Story
    {
        
        [StringLength(30, MinimumLength = 2)]
        [Display(Name = "nimi")]
        [Required]
        public string name { get; set; }
        [Display(Name = "sukupuoli")]
        [Required]
        public string Sex { get; set; }
        [Required]
        [Range(1, 120)]
        [Display(Name = "ikä")]
        public string Age { get; set; }
        [Required]
        [Display(Name = "väri")]
        public string Color { get; set; }
        [Required]
        [Display(Name = "fontin koko")]
        public string FontSize{ get; set; }





    public enum eSex
        {
            Mies,
            Nainen,
            Muu
        }

    public string createStory()
        {
            string kind;
            if (this.Sex == "Mies")
            {
                kind = "komea mies";
            }                
            else if (this.Sex == "Mainen")
            {            
                kind = "kaunis nainen";
            }
            else
            {
                kind = "muunlainen henkilö";
            }
            string text = "Olipa kerran " + this.name + ". Hän oli hyvin, hyvin " + kind + ". Ikää hänellä oli ainakin " + Age + "-vuotta! Sen pituinen se :)";
            

            return text;
        }
    }
}