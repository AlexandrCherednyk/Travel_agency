﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public enum StarCategory
    {
        Starless,
        OneStar,
        TwoStars,
        ThreeStars,
        FourStars,
        FiveStars
    }

    public class Hotel
    {
        [Key]
        public Guid Id { get;  set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public StarCategory StarRating { get; set; }
        public virtual ICollection<Lodging> Lodgings { get; set; }
        public List<MealsType> MealsTypes { get; set; }
        public string PathToImage { get; set; }

        public Hotel() 
        {
            Lodgings = new HashSet<Lodging>();
            MealsTypes = new List<MealsType>();
        }
        public Hotel(string name, string country, StarCategory starCategory)
        {
            Id = Guid.NewGuid();
            Name = name;
            Country = country;
            StarRating = starCategory;
            Lodgings = new HashSet<Lodging>();
            MealsTypes = new List<MealsType>();
        }
        public Hotel(string name, string country, StarCategory starCategory, string pathToImage)
        {
            Id = Guid.NewGuid();
            Name = name;
            Country = country;
            StarRating = starCategory;
            Lodgings = new HashSet<Lodging>();
            MealsTypes = new List<MealsType>();
            PathToImage = pathToImage;
        }
    }
}
