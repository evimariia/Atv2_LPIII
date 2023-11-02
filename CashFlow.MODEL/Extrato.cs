using System;
using System.Collections.Generic;

namespace CashFlow.MODEL;

public partial class Extrato
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public DateTime? Data { get; set; }

    public decimal Valor { get; set; }

    public int IdCategoria { get; set; }

    public int IdUsuario { get; set; }

    public virtual Categoria IdCategoriaNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
