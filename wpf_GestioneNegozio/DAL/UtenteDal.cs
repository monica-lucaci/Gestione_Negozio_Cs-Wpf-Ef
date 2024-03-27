using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_GestioneNegozio.Models;

namespace wpf_GestioneNegozio.DAL
{
    internal class UtenteDal : IDal<Utente>
    {
        private static UtenteDal? instance;

        public static UtenteDal GetInstance()
        {
            if (instance == null)
            {
                instance = new UtenteDal();
            }
            return instance;
        }

        private UtenteDal() { }

        public bool Delete(int id)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    var utenteToDelete = ctx.Utentes.Find(id);
                    if (utenteToDelete != null)
                    {
                        ctx.Utentes.Remove(utenteToDelete);
                        ctx.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Utente con ID {id} non trovato.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante l'eliminazione dell'utente con ID {id}: {ex.Message}");
                    return false;
                }
            }
        }

        public List<Utente> GetAll()
        {
            List<Utente> risultato = new List<Utente>();

            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    risultato = ctx.Utentes.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return risultato;
        }

        public bool Insert(Utente t)
        {
            bool risultato = false;

            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    ctx.Utentes.Add(t);
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

        public bool Update(Utente t)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    var existingUtente = ctx.Utentes.Find(t.UtenteId);
                    if (existingUtente != null)
                    {
                        ctx.Entry(existingUtente).CurrentValues.SetValues(t);
                        ctx.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Utente con ID {t.UtenteId} non trovato.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante l'aggiornamento dell'utente con ID {t.UtenteId}: {ex.Message}");
                    return false;
                }
            }
        }

        public Utente findById(int id)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    return ctx.Utentes.Single(u => u.UtenteId == id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return new Utente();
            }
        }
    }
}
