using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HealthCenterMaster.Data;
using HealthCenterMaster.Models;

namespace HealthCenterMaster.Pages.Physiotherapists
{
    public class CreateModel : PageModel
    {
        private readonly HealthCenterMaster.Data.ApplicationDbContext _context;

        public CreateModel(HealthCenterMaster.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Physiotherapist Physiotherapist { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Physiotherapist == null || Physiotherapist == null)
            {
                return Page();
            }

            _context.Physiotherapist.Add(Physiotherapist);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
