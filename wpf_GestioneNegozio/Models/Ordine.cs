using System;
using System.Collections.Generic;

namespace wpf_GestioneNegozio.Models;

public partial class Ordine
{
    public int OrdineId { get; set; }

    public DateOnly? DataOrdine { get; set; }

    public int UtenteRif { get; set; }

    public string? StatoOrdine { get; set; }

    public virtual ICollection<OrdineVariazione> OrdineVariaziones { get; set; } = new List<OrdineVariazione>();

    public virtual Utente UtenteRifNavigation { get; set; } = null!;
}
