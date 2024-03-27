using System;
using System.Collections.Generic;

namespace wpf_GestioneNegozio.Models;

public partial class Prodotto
{
    public int ProdottoId { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descrizione { get; set; }

    public int CategoriaRif { get; set; }

    public virtual Categorium CategoriaRifNavigation { get; set; } = null!;

    public virtual ICollection<Variazione> Variaziones { get; set; } = new List<Variazione>();
}
