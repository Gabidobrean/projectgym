using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using project.Data;
using project.Models;

namespace project.Pages.Antrenori
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
            return Page();
        }

        [BindProperty]
        public Antrenor Antrenor { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Antrenor.Add(Antrenor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
