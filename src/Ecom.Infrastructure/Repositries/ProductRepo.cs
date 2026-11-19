using System;
using Ecom.Core.Entities.product;
using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Data;

namespace Ecom.Infrastructure.Repositries;

public class ProductRepo : GenericRepo<Product> , IProductRepo  
{
    public ProductRepo(AppDbContext context) : base(context){}

}
