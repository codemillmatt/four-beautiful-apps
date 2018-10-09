﻿using System;
namespace SmashingRecipe
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Directions { get; set; }
        public string Picture { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
