using System;
using System.Collections.Generic;

namespace FiszkiDataBase;

public partial class SetsFiche
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<Fiche> Fiches { get; set; } = new List<Fiche>();

    public virtual ICollection<TeachSetsFiche> TeachSetsFiches { get; set; } = new List<TeachSetsFiche>();

    public virtual User? User { get; set; }
}
