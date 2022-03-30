using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Opdracht9.Models;

namespace Opdracht9.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Klas> Klassen { get; set; }
        public DbSet<Docent> Docenten { get; set; }
        public DbSet<Student> Students { get; set; }    
        public DbSet<Rooster> Roosters { get; set; }  
        public DbSet<Vak> Vakken { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}