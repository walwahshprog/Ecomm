using System;
using Ecom.Core.Entities.product;
using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Data;

namespace Ecom.Infrastructure.Repositries;

public class PhotoRepo  :GenericRepo<Photo> , IPhotoRepo
{
    public PhotoRepo(AppDbContext context) : base(context){}
    
}
