using System;
using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Data;

namespace Ecom.Infrastructure.Repositries;

public class UnitRepo : IUnitRpo
{
    private readonly AppDbContext _context ; 
    public ICategoryRepo categoryRepo {get;}

    public IPhotoRepo photoRepo {get;}
    public IProductRepo productRepo {get;}

    public UnitRepo(AppDbContext context)
    {
        _context = context;
        categoryRepo = new CategoryRepo(context);
        photoRepo = new PhotoRepo(context);
        productRepo = new ProductRepo(context);

    }
}
