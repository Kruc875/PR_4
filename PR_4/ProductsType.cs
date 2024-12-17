using System;
using System.Collections.Generic;

namespace PR_4;

public partial class ProductsType
{
    public int Id { get; set; }

    public string TypeOfProduct { get; set; } = null!;

    public virtual Product? Product { get; set; }
}
