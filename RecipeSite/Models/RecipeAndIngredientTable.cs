using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSite.Models
{
    public class RecipeAndIngredientTable
    {
        [Key]
        public int RecipeID { get; set; }
        [Key]
        public int IngredientID { get; set; }
        public Recipe Recipe { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
