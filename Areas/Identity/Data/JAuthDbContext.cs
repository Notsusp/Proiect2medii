using JustABlog.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JustABlog.Models;

namespace JustABlog.Data;

public class JAuthDbContext : IdentityDbContext<BlogUser>
{
    public JAuthDbContext(DbContextOptions<JAuthDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<JustABlog.Models.BlogPost> BlogPost { get; set; } = default!;
}
