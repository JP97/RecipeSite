using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecipeSite.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Comment> Comments { get; set; }
        [Display(Name = "Rating")]
        public double AverageRating { get; set; }
        public List<Rating> Ratings { get { return Ratings; } set { CalcAverageRating(); } }

        
        private void CalcAverageRating()
        {
            double totalsum = Ratings.Sum(x => x.Character);
            AverageRating =  totalsum/Ratings.Count;
        }
    }
}
