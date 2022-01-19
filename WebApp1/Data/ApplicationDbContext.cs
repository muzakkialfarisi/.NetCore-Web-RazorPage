using WebApp1.Model;
using Microsoft.EntityFrameworkCore;


namespace WebApp1.Data
{
    public class ApplicationDbContext : DbContext
    {
        //bikin ini setelah inisialisasi coneksi dari program.cs
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
    }
}
