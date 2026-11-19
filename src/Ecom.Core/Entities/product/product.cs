using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecom.Core.Entities.product;

public class Product:baseEntity<Guid>
{
    public  string ?Name { get; set; }
    public  string ?Description { get; set; }
    public  decimal Price { get; set; }
    public  Guid CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))]
    public  virtual Category ?Category { get; set; }

    public  virtual List<Photo>? Photos { get; set; }
}
