using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using JustABlog.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JustABlog.Data;
using JustABlog.Models;
using Microsoft.AspNetCore.Authorization;

namespace JustABlog.Areas.Identity.Pages.BlogPosts
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly JustABlog.Data.JAuthDbContext _context;

        public CreateModel(JustABlog.Data.JAuthDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BlogPost BlogPost { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            BlogPost.DateAndTime = DateTime.Now;
            BlogPost.Author = User.Identity.Name;

            _context.BlogPost.Add(BlogPost);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
