using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_GestioneNegozio.Models;

namespace wpf_GestioneNegozio.DAL
{
    internal class OrdineVariazioneDal : IDal<OrdineVariazione>
    {
        private static OrdineVariazioneDal? instance;

        public static OrdineVariazioneDal GetInstance()
        {
            if (instance == null)
            {
                instance = new OrdineVariazioneDal();
            }
            return instance;
        }

        private OrdineVariazioneDal() { }

        public bool Delete(int id)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    var ordineVariazioneToDelete = ctx.OrdineVariaziones.Find(id);
                    if (ordineVariazioneToDelete != null)
                    {
                        ctx.OrdineVariaziones.Remove(ordineVariazioneToDelete);
                        ctx.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Variazione dell'ordine con ID {id} non trovata.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante l'eliminazione della variazione dell'ordine con ID {id}: {ex.Message}");
                    return false;
                }
            }
        }

        public List<OrdineVariazione> GetAll()
        {
            List<OrdineVariazione> risultato = new List<OrdineVariazione>();

            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    risultato = ctx.OrdineVariaziones.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return risultato;
        }

        public bool Insert(OrdineVariazione t)
        {
            bool risultato = false;

            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    ctx.OrdineVariaziones.Add(t);
                    ctx.SaveChanges();
                    risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return risultato;
        }

        public bool Update(OrdineVariazione t)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    var existingOrdineVariazione = ctx.OrdineVariaziones.Find(t.OrdineVariazione1);
                    if (existingOrdineVariazione != null)
                    {
                        ctx.Entry(existingOrdineVariazione).CurrentValues.SetValues(t);
                        ctx.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Variazione dell'ordine con ID {t.OrdineVariazione1} non trovata.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante l'aggiornamento della variazione dell'ordine con ID {t.OrdineVariazione1}: {ex.Message}");
                    return false;
                }
            }
        }

        public OrdineVariazione findById(int id)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    return ctx.OrdineVariaziones.Single(o => o.OrdineVariazione1 == id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return new OrdineVariazione();
            }
        }
    }
}
