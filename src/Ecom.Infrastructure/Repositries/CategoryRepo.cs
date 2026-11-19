using System;
using System.Linq.Expressions;
using Ecom.Core.Entities.product;
using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Infrastructure.Repositries;

public class CategoryRepo : GenericRepo<Category> , ICategoryRepo 
{
    public CategoryRepo(AppDbContext context) : base(context){}
}
