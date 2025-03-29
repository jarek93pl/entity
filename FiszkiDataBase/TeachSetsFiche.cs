using System;
using System.Collections.Generic;

namespace FiszkiDataBase;

public partial class TeachSetsFiche
{
    public int Id { get; set; }

    public int? IdSetFiche { get; set; }

    public string? Name { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? FirstTypeAnswer { get; set; }

    public int? LimitTimeSek { get; set; }

    public virtual ICollection<FicheTeachState> FicheTeachStates { get; set; } = new List<FicheTeachState>();

    public virtual DictionaryTypeAnswer? FirstTypeAnswerNavigation { get; set; }

    public virtual SetsFiche? IdSetFicheNavigation { get; set; }

    public virtual ICollection<TeachBag> TeachBags { get; set; } = new List<TeachBag>();
}
