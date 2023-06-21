using CleanArqui.Entities.Interfaces;
using CleanArqui.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArqui.RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly CleanArquiContext context;
        public UnitOfWork(CleanArquiContext _context)=>
            context = _context;
        
        public Task<int> SaveChanges()
        {

            return context.SaveChangesAsync();
        }
    }
}
