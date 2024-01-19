using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HealthCenterMaster.Data;
using HealthCenterMaster.Models;

namespace HealthCenterMaster.Pages.Schedules
{
    public class DeleteModel : PageModel
    {
        private readonly HealthCenterMaster.Data.ApplicationDbContext _context;

        public DeleteModel(HealthCenterMaster.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Schedule Schedule { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Schedule == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule.FirstOrDefaultAsync(m => m.Id == id);

            if (schedule == null)
            {
                return NotFound();
            }
            else 
            {
                Schedule = schedule;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Schedule == null)
            {
                return NotFound();
            }
            var schedule = await _context.Schedule.FindAsync(id);

            if (schedule != null)
            {
                Schedule = schedule;
                _context.Schedule.Remove(Schedule);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
