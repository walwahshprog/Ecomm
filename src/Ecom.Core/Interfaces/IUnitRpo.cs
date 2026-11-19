using System;

namespace Ecom.Core.Interfaces;

public interface IUnitRpo
{
    public ICategoryRepo categoryRepo{get;}
    public IPhotoRepo photoRepo{get;}
    public IProductRepo productRepo{get;}
}
