using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_GestioneNegozio.Models;

namespace wpf_GestioneNegozio.DAL
{
    internal class VariazioneDal : IDal<Variazione>
    {
        private static VariazioneDal? instance;

        public static VariazioneDal GetInstance()
        {
            if (instance == null)
            {
                instance = new VariazioneDal();
            }
            return instance;
        }

        private VariazioneDal() { }

        public bool Delete(int id)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    var variazioneToDelete = ctx.Variaziones.Find(id);
                    if (variazioneToDelete != null)
                    {
                        ctx.Variaziones.Remove(variazioneToDelete);
                        ctx.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Variazione con ID {id} non trovata.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante l'eliminazione della variazione con ID {id}: {ex.Message}");
                    return false;
                }
            }
        }

        public List<Variazione> GetAll()
        {
            List<Variazione> risultato = new List<Variazione>();

            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    risultato = ctx.Variaziones.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return risultato;
        }

        public bool Insert(Variazione t)
        {
            bool risultato = false;

            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    ctx.Variaziones.Add(t);
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

        public bool Update(Variazione t)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    var existingVariazione = ctx.Variaziones.Find(t.VariazioneId);
                    if (existingVariazione != null)
                    {
                        ctx.Entry(existingVariazione).CurrentValues.SetValues(t);
                        ctx.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Variazione con ID {t.VariazioneId} non trovata.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante l'aggiornamento della variazione con ID {t.VariazioneId}: {ex.Message}");
                    return false;
                }
            }
        }

        public Variazione findById(int id)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    return ctx.Variaziones.Single(v => v.VariazioneId == id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return new Variazione();
            }
        }
    }
}
