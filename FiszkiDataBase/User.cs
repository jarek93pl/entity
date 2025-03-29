using System;
using System.Collections.Generic;

namespace FiszkiDataBase;

public partial class User
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string? Password { get; set; }

    public virtual ICollection<SetsFiche> SetsFiches { get; set; } = new List<SetsFiche>();
}
