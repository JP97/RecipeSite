using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSide.Models
{
    public class Ingredient
    {
        [Key]
        public string NameID { get; set; }
        public int Amount { get; set; }
        public enum Unit
        {
            g = 0,
            kg = 1,
            dl = 2,
            tsk = 3
        };
    }
}
