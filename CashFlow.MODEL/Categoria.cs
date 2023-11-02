using System;
using System.Collections.Generic;

namespace CashFlow.MODEL;

public partial class Categoria
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<Extrato> Extratos { get; set; } = new List<Extrato>();
}
