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
    public class IndexModel : PageModel
    {
        private readonly Vinteler_Erica_lab8.Data.Vinteler_Erica_lab8Context _context;

        public IndexModel(Vinteler_Erica_lab8.Data.Vinteler_Erica_lab8Context context)
        {
            _context = context;
        }

        public IList<BookCategory> BookCategory { get;set; }

        public async Task OnGetAsync()
        {
            BookCategory = await _context.BookCategory
                .Include(b => b.Book)
                .Include(b => b.Category).ToListAsync();
        }
    }
}
