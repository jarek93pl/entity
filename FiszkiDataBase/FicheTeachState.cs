using System;
using System.Collections.Generic;

namespace FiszkiDataBase;

public partial class FicheTeachState
{
    public int IdFiche { get; set; }

    public int IdTeachSet { get; set; }

    public int? NumberCorect { get; set; }

    public DateTime? NextTry { get; set; }

    public bool? IsDone { get; set; }

    public virtual Fiche IdFicheNavigation { get; set; } = null!;

    public virtual TeachSetsFiche IdTeachSetNavigation { get; set; } = null!;
}
