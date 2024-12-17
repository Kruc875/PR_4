using System;
using System.Collections.Generic;

namespace PR_4;

public partial class PartnersProduct
{
    public int Id { get; set; }

    public int IdPartner { get; set; }

    public int IdProduct { get; set; }

    public int Count { get; set; }

    public DateTime Date { get; set; }

    public virtual Partner IdPartnerNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
