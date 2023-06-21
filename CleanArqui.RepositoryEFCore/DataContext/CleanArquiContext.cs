using CleanArqui.Entities.POCOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArqui.RepositoryEFCore.DataContext
{
    public class CleanArquiContext : DbContext
    {
        public CleanArquiContext(DbContextOptions<CleanArquiContext> options) : base(options)  {  }

        public DbSet<Product> Products { get; set; }
    }
}
