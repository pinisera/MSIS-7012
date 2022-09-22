using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatPinisera.Models;

namespace RecruitCatPinisera.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly OrgDb _context;

        public DetailsModel(OrgDb context)
        {
            _context = context;
        }

      public Company Company { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Company == null)
            {
                return NotFound();
            }

            var company = await _context.Company
                                        .Include(x => x.JobTitle)
                                        .Include(y => y.Industry)
                                        .Include(z => z.Candidates)
                                        .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (company == null)
            {
                return NotFound();
            }
            else 
            {
                Company = company;
            }
            return Page();
        }
    }
}
