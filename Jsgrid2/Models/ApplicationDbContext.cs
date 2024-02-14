using Microsoft.EntityFrameworkCore;

namespace Jsgrid2.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Gridlist> Gridsystem {  get; set; }

        
            
        

    }
}
