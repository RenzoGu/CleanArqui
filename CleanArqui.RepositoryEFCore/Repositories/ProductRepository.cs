using CleanArqui.Entities.Interfaces;
using CleanArqui.Entities.POCOs;
using CleanArqui.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArqui.RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        readonly CleanArquiContext context;
        public ProductRepository(CleanArquiContext _context)
        {
            this.context = _context;
        }
        public void CreateProduct(Product product)
        {
            context.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return context.Products;
        }
    }
}
