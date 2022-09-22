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
    public class DeleteModel : PageModel
    {
        private readonly OrgDb _context;

        public DeleteModel(OrgDb context)
        {
            _context = context;
        }

        [BindProperty]
      public JobTitle JobTitle { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.JobTitle == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.JobTitleId == id);

            if (jobtitle == null)
            {
                return NotFound();
            }
            else 
            {
                JobTitle = jobtitle;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.JobTitle == null)
            {
                return NotFound();
            }
            var jobtitle = await _context.JobTitle.FindAsync(id);

            if (jobtitle != null)
            {
                JobTitle = jobtitle;
                _context.JobTitle.Remove(JobTitle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
