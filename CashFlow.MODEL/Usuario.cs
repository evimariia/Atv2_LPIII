using System;
using System.Collections.Generic;

namespace CashFlow.MODEL;

public partial class Usuario
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public virtual ICollection<Extrato> Extratos { get; set; } = new List<Extrato>();
}
