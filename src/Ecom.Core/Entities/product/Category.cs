using System;

namespace Ecom.Core.Entities.product;

public class Category :baseEntity<Guid>
{
    public string ?Name { get; set; }
    public  string ?Description { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();

}
