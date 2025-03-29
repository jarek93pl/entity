using System;
using System.Collections.Generic;

namespace FiszkiDataBase;

public partial class Fiche
{
    public int Id { get; set; }

    public string? Response { get; set; }

    public string? Prompt { get; set; }

    public int? TypePrompt { get; set; }

    public int? IdSetFiche { get; set; }

    public int? IdFile { get; set; }

    public virtual ICollection<FicheResponse> FicheResponses { get; set; } = new List<FicheResponse>();

    public virtual ICollection<FicheTeachState> FicheTeachStates { get; set; } = new List<FicheTeachState>();

    public virtual File? IdFileNavigation { get; set; }

    public virtual SetsFiche? IdSetFicheNavigation { get; set; }

    public virtual DictionaryTypeContent? TypePromptNavigation { get; set; }
}
