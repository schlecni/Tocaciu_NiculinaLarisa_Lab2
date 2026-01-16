using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tocaciu_NiculinaLarisa_Lab2.Data;
using Tocaciu_NiculinaLarisa_Lab2.Models;

namespace Tocaciu_NiculinaLarisa_Lab2.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly Tocaciu_NiculinaLarisa_Lab2.Data.Tocaciu_NiculinaLarisa_Lab2Context _context;

        public DeleteModel(Tocaciu_NiculinaLarisa_Lab2.Data.Tocaciu_NiculinaLarisa_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Category Category { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (category == null)
            {
                return NotFound();
            }
            else
            {
                Category = category;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FindAsync(id);
            if (category != null)
            {
                Category = category;
                _context.Category.Remove(Category);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

