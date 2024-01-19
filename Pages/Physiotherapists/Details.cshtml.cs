using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HealthCenterMaster.Data;
using HealthCenterMaster.Models;

namespace HealthCenterMaster.Pages.Physiotherapists
{
    public class DetailsModel : PageModel
    {
        private readonly HealthCenterMaster.Data.ApplicationDbContext _context;

        public DetailsModel(HealthCenterMaster.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Physiotherapist Physiotherapist { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Physiotherapist == null)
            {
                return NotFound();
            }

            var physiotherapist = await _context.Physiotherapist.FirstOrDefaultAsync(m => m.Id == id);
            if (physiotherapist == null)
            {
                return NotFound();
            }
            else 
            {
                Physiotherapist = physiotherapist;
            }
            return Page();
        }
    }
}
