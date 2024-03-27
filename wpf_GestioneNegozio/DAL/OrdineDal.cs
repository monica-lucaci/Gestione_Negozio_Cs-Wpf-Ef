using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_GestioneNegozio.Models;

namespace wpf_GestioneNegozio.DAL
{
    internal class OrdineDal : IDal<Ordine>
    {
        private static OrdineDal? instance;

        public static OrdineDal GetInstance()
        {
            if (instance == null)
            {
                instance = new OrdineDal();
            }
            return instance;
        }

        private OrdineDal() { }

        public bool Delete(int id)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    var ordineToDelete = ctx.Ordines.Find(id);
                    if (ordineToDelete != null)
                    {
                        ctx.Ordines.Remove(ordineToDelete);
                        ctx.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Ordine con ID {id} non trovato.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante l'eliminazione dell'ordine con ID {id}: {ex.Message}");
                    return false;
                }
            }
        }

        public List<Ordine> GetAll()
        {
            List<Ordine> risultato = new List<Ordine>();

            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    risultato = ctx.Ordines.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return risultato;
        }

        public bool Insert(Ordine t)
        {
            bool risultato = false;

            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    ctx.Ordines.Add(t);
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

        public bool Update(Ordine t)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    var existingOrdine = ctx.Ordines.Find(t.OrdineId);
                    if (existingOrdine != null)
                    {
                        ctx.Entry(existingOrdine).CurrentValues.SetValues(t);
                        ctx.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Ordine con ID {t.OrdineId} non trovato.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante l'aggiornamento dell'ordine con ID {t.OrdineId}: {ex.Message}");
                    return false;
                }
            }
        }

        public Ordine findById(int id)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    return ctx.Ordines.Single(o => o.OrdineId == id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return new Ordine();
            }
        }
    }
}
