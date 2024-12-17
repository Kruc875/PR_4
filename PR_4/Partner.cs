using System;
using System.Collections.Generic;

namespace PR_4;

public partial class Partner
{
    public int Id { get; set; }

    public short IdPartner { get; set; }

    public string Name { get; set; } = null!;

    public string LegalAddress { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public string NameOfDirector { get; set; } = null!;

    public string TelephoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public short? Rating { get; set; }

    public virtual User IdPartnerNavigation { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();

}
