using System;
using System.Collections.Generic;

namespace FiszkiDataBase;

public partial class FicheAnswer
{
    public int Id { get; set; }

    public int? IdTeachSet { get; set; }

    public int? IdFiche { get; set; }

    public bool? IsCorrect { get; set; }

    public DateTime? DateAnswering { get; set; }
}
