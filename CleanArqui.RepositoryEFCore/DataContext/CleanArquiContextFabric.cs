using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArqui.RepositoryEFCore.DataContext
{
    public class CleanArquiContextFabric : IDesignTimeDbContextFactory<CleanArquiContext>
    {
        public CleanArquiContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new 
                DbContextOptionsBuilder<CleanArquiContext>();

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;database=CleanArqui");
            return new CleanArquiContext(optionsBuilder.Options);
        }
    }
}
