using System;

namespace Ecom.Core.Entities;

public class baseEntity<T>
{
    public required T Id { get; set; }
}
