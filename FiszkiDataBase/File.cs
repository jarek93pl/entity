using System;
using System.Collections.Generic;

namespace FiszkiDataBase;

public partial class File
{
    public int Id { get; set; }

    public string? FileExtension { get; set; }

    public virtual ICollection<FicheResponse> FicheResponses { get; set; } = new List<FicheResponse>();

    public virtual ICollection<Fiche> Fiches { get; set; } = new List<Fiche>();
}
