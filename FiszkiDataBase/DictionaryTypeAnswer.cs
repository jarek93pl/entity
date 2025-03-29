using System;
using System.Collections.Generic;

namespace FiszkiDataBase;

public partial class DictionaryTypeAnswer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<TeachBag> TeachBags { get; set; } = new List<TeachBag>();

    public virtual ICollection<TeachSetsFiche> TeachSetsFiches { get; set; } = new List<TeachSetsFiche>();
}
