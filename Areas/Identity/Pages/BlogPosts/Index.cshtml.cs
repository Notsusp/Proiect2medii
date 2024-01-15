using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JustABlog.Data;
using JustABlog.Models;
using Microsoft.AspNetCore.Authorization;

namespace JustABlog.Areas.Identity.Pages.BlogPosts
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly JustABlog.Data.JAuthDbContext _context;

        public IndexModel(JustABlog.Data.JAuthDbContext context)
        {
            _context = context;
        }

        public IList<BlogPost> BlogPost { get;set; } = default!;

        public async Task OnGetAsync()
        {
            BlogPost = await _context.BlogPost.ToListAsync();
        }
    }
}
