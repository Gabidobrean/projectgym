using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Models;

namespace project.Pages.Abonamente
{
    public class IndexModel : PageModel
    {
        private readonly project.Data.projectContext _context;

        public IndexModel(project.Data.projectContext context)
        {
            _context = context;
        }

        public IList<Abonament> Abonament { get;set; }

        public async Task OnGetAsync()
        {
            Abonament = await _context.Abonament
                .Include(a => a.Antrenor)
                .Include(a => a.Curs).ToListAsync();
        }
    }
}
