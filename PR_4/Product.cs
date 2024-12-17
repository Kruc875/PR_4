using System;
using System.Collections.Generic;

namespace PR_4;

public partial class Product
{
    public int Id { get; set; }

    public short IdTypeOfProduct { get; set; }

    public string Name { get; set; } = null!;

    public string Article { get; set; } = null!;

    public decimal MinimalPrice { get; set; }

    public virtual ProductsType IdNavigation { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
