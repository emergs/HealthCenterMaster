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
    public class IndexModel : PageModel
    {
        private readonly HealthCenterMaster.Data.ApplicationDbContext _context;

        public IndexModel(HealthCenterMaster.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Schedule> Schedule { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Schedule != null)
            {
                Schedule = await _context.Schedule
                .Include(s => s.Client)
                .Include(s => s.Physiotherapist).ToListAsync();
            }
        }
    }
}
