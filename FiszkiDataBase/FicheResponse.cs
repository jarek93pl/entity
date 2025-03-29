using System;
using System.Collections.Generic;

namespace FiszkiDataBase;

public partial class FicheResponse
{
    public int Id { get; set; }

    public int? IdFile { get; set; }

    public int? TypePrompt { get; set; }

    public string? Name { get; set; }

    public int? IdFiche { get; set; }

    public bool? IsCorect { get; set; }

    public virtual Fiche? IdFicheNavigation { get; set; }

    public virtual File? IdFileNavigation { get; set; }

    public virtual DictionaryTypeContent? TypePromptNavigation { get; set; }
}
