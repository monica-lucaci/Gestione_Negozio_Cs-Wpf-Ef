using System;
using System.Collections.Generic;

namespace wpf_GestioneNegozio.Models;

public partial class Utente
{
    public int UtenteId { get; set; }

    public string Nominativo { get; set; } = null!;

    public string? Email { get; set; }

    public string? Indirizzo { get; set; }

    public virtual ICollection<Ordine> Ordines { get; set; } = new List<Ordine>();
}
