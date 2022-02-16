using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using project.Data;
using project.Models;

namespace project.Pages.Abonamente
{
    public class CreateModel : PageModel
    {
        private readonly project.Data.projectContext _context;

        public CreateModel(project.Data.projectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AntrenorID"] = new SelectList(_context.Set<Antrenor>(), "ID", "ID");
        ViewData["CursID"] = new SelectList(_context.Set<Curs>(), "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Abonament Abonament { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Abonament.Add(Abonament);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
