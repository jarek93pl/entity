using System;
using System.Collections.Generic;

namespace FiszkiDataBase;

public partial class DictionaryTypeContent
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<FicheResponse> FicheResponses { get; set; } = new List<FicheResponse>();

    public virtual ICollection<Fiche> Fiches { get; set; } = new List<Fiche>();
}
