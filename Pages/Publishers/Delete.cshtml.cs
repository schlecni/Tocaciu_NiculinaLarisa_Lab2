using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tocaciu_NiculinaLarisa_Lab2.Data;
using Tocaciu_NiculinaLarisa_Lab2.Models;

namespace Tocaciu_NiculinaLarisa_Lab2.Pages.Publishers
{
    public class DeleteModel : PageModel
    {
        private readonly Tocaciu_NiculinaLarisa_Lab2.Data.Tocaciu_NiculinaLarisa_Lab2Context _context;

        public DeleteModel(Tocaciu_NiculinaLarisa_Lab2.Data.Tocaciu_NiculinaLarisa_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (publisher == null)
            {
                return NotFound();
            }
            else
            {
                Publisher = publisher;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FindAsync(id);
            if (publisher != null)
            {
                Publisher = publisher;
                _context.Publisher.Remove(Publisher);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

