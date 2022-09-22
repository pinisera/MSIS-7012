using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatPinisera.Models;

namespace RecruitCatPinisera.Pages.JobTitles
{
    public class IndexModel : PageModel
    {
        private readonly OrgDb _context;

        public IndexModel(OrgDb context)
        {
            _context = context;
        }

        public IList<JobTitle> JobTitle { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.JobTitle != null)
            {
                JobTitle = await _context.JobTitle.ToListAsync();
            }
        }
    }
}
