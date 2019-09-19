using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipeSite.Data;
using RecipeSite.Models;

namespace RecipeSite.Pages.Ingredients
{
    public class DetailsModel : PageModel
    {
        private readonly RecipeSite.Data.ApplicationDbContext _context;

        public DetailsModel(RecipeSite.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Ingredient Ingredient { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ingredient = await _context.Ingredient.FirstOrDefaultAsync(m => m.NameID == id);

            if (Ingredient == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
