using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_GestioneNegozio.Models;

namespace wpf_GestioneNegozio.DAL
{
    internal class ProdottoDal : IDal<Prodotto>
    {
        private static ProdottoDal? instance;

        public static ProdottoDal GetInstance()
        {
            if (instance == null)
            {
                instance = new ProdottoDal();
            }
            return instance;
        }

        private ProdottoDal() { }

        public bool Delete(int id)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    var prodottoToDelete = ctx.Prodottos.Find(id);
                    if (prodottoToDelete != null)
                    {
                        ctx.Prodottos.Remove(prodottoToDelete);
                        ctx.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Prodotto con ID {id} non trovato.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante l'eliminazione del prodotto con ID {id}: {ex.Message}");
                    return false;
                }
            }
        }

        public List<Prodotto> GetAll()
        {
            List<Prodotto> risultato = new List<Prodotto>();

            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    risultato = ctx.Prodottos.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return risultato;
        }

        public bool Insert(Prodotto t)
        {
            bool risultato = false;

            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    ctx.Prodottos.Add(t);
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

        public bool Update(Prodotto t)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    var existingProdotto = ctx.Prodottos.Find(t.ProdottoId);
                    if (existingProdotto != null)
                    {
                        ctx.Entry(existingProdotto).CurrentValues.SetValues(t);
                        ctx.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Prodotto con ID {t.ProdottoId} non trovato.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante l'aggiornamento del prodotto con ID {t.ProdottoId}: {ex.Message}");
                    return false;
                }
            }
        }

        public Prodotto findById(int id)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    return ctx.Prodottos.Single(p => p.ProdottoId == id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return new Prodotto();
            }
        }
    }
}
