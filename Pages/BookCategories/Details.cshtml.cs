using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vinteler_Erica_lab8.Data;
using Vinteler_Erica_lab8.Models;

namespace Vinteler_Erica_lab8.Pages.BookCategories
{
    public class DetailsModel : PageModel
    {
        private readonly Vinteler_Erica_lab8.Data.Vinteler_Erica_lab8Context _context;

        public DetailsModel(Vinteler_Erica_lab8.Data.Vinteler_Erica_lab8Context context)
        {
            _context = context;
        }

        public BookCategory BookCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).FirstOrDefaultAsync(m => m.ID == id);

            if (BookCategory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
