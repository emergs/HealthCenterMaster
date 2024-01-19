using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HealthCenterMaster.Data;
using HealthCenterMaster.Models;

namespace HealthCenterMaster.Pages.Physiotherapists
{
    public class EditModel : PageModel
    {
        private readonly HealthCenterMaster.Data.ApplicationDbContext _context;

        public EditModel(HealthCenterMaster.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Physiotherapist Physiotherapist { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Physiotherapist == null)
            {
                return NotFound();
            }

            var physiotherapist =  await _context.Physiotherapist.FirstOrDefaultAsync(m => m.Id == id);
            if (physiotherapist == null)
            {
                return NotFound();
            }
            Physiotherapist = physiotherapist;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Physiotherapist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhysiotherapistExists(Physiotherapist.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PhysiotherapistExists(int id)
        {
          return (_context.Physiotherapist?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
