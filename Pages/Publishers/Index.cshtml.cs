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
    public class IndexModel : PageModel
    {
        private readonly Tocaciu_NiculinaLarisa_Lab2.Data.Tocaciu_NiculinaLarisa_Lab2Context _context;

        public IndexModel(Tocaciu_NiculinaLarisa_Lab2.Data.Tocaciu_NiculinaLarisa_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}

