using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products
{
    public sealed class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(ProductId id)
            : base($"The product with the ID = {id.Value} was not found")
        {
        }
    }
}
