using CleanArqui.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArqui.Entities.Interfaces
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);
        IEnumerable<Product> GetAll();
    }
}
