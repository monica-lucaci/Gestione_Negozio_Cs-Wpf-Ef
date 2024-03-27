using System;
using System.Collections.Generic;

namespace wpf_GestioneNegozio.Models;

public partial class OrdineVariazione
{
    public int OrdineVariazione1 { get; set; }

    public int Quantita { get; set; }

    public int VariazioneRif { get; set; }

    public int OrdineRif { get; set; }

    public virtual Ordine OrdineRifNavigation { get; set; } = null!;

    public virtual Variazione VariazioneRifNavigation { get; set; } = null!;
}
