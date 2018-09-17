﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace VartasAssignment.Models
{
    public class Movie
    {
        
        [Display(Name = "Elokuvan nimi")]
        public string movieName { get; set; }
        [Display(Name = "Genre")]
        public string category { get; set; }
        [Display(Name = "Kuvaus")]
        public string description { get; set; }
        [Display(Name = "Alkaa")]
        public string startTime { get; set; }
        [Display(Name = "Loppuu")]
        public string endTime { get; set; }


        public Movie()
        {

        }

        public Movie(String name, String category, String description, String startTime, String endTime)
        {
            this.movieName = name;
            this.category = category;
            this.description = description;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public enum ECategory
        {
            Toiminta,
            Komedia,
            Draama
        }




    }

}