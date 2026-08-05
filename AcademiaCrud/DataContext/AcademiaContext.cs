using AcademiaCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace AcademiaCrud.DataContext
{
    public class AcademiaContext:DbContext
    {
        public AcademiaContext(DbContextOptions<AcademiaContext>options):base(options) 
        {
            
        }

        public DbSet<Instrutor> Instrutor { get; set; }

    }
}
