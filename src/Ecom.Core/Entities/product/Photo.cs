using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecom.Core.Entities.product;

public class Photo: baseEntity<Guid>
{
    public  string? ImageName { get; set; }
    public  Guid ProductId { get; set; }
    [ForeignKey(nameof(ProductId))]
    public  virtual Product ?Product { get; set; }
}
