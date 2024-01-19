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
    public class IndexModel : PageModel
    {
        private readonly HealthCenterMaster.Data.ApplicationDbContext _context;

        public IndexModel(HealthCenterMaster.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Physiotherapist> Physiotherapist { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Physiotherapist != null)
            {
                Physiotherapist = await _context.Physiotherapist.ToListAsync();
            }
        }
    }
}
