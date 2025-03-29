using System;
using System.Collections.Generic;

namespace FiszkiDataBase;

public partial class TeachBag
{
    public int Id { get; set; }

    public int? IdTeachSet { get; set; }

    public string? Name { get; set; }

    public int? TypeAnswer { get; set; }

    public TimeOnly? PeriodTime { get; set; }

    public int? LimitTimeSek { get; set; }

    public int? Number { get; set; }

    public virtual TeachSetsFiche? IdTeachSetNavigation { get; set; }

    public virtual DictionaryTypeAnswer? TypeAnswerNavigation { get; set; }
}
