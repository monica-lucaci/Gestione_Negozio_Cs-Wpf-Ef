using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_GestioneNegozio.Models;

namespace wpf_GestioneNegozio.DAL
{
    internal class CategoriumDal : IDal<Categorium>
    {

        private static CategoriumDal? istance;
        public static CategoriumDal getIstance()
        {
            if (istance == null)
            {
                istance = new CategoriumDal();
            }
            return istance;
        }
        private CategoriumDal() { }

        public bool Delete(int categoriaId)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    var categoriaToDelete = ctx.Categoria.Find(categoriaId);
                    if (categoriaToDelete != null)
                    {
                        ctx.Categoria.Remove(categoriaToDelete);
                        ctx.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Categoria con ID {categoriaId} non trovata.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante l'eliminazione della categoria con ID {categoriaId}: {ex.Message}");
                    return false;
                }
            }
        }


        public List<Categorium> GetAll()
        {
            List<Categorium> risultato = new List<Categorium>();

            using(DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    risultato = ctx.Categoria.ToList();

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            return risultato;
        }

        public bool Insert(Categorium t)
        {
            bool risultato = false;

            using(DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    ctx.Categoria.Add(t);
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

        public bool Update(Categorium t)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    var existingCategoria = ctx.Categoria.Find(t.CategoriaId);
                    if (existingCategoria != null)
                    {
                  
                        ctx.Entry(existingCategoria).CurrentValues.SetValues(t);
                        ctx.SaveChanges();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Categoria con ID {t.CategoriaId} non trovata.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante l'aggiornamento della categoria con ID {t.CategoriaId}: {ex.Message}");
                    return false;
                }
            }
        }


        public Categorium findById(int id)
        {
            using (DbGestioneNegozioContext ctx = new DbGestioneNegozioContext())
            {
                try
                {
                    return ctx.Categoria.Single(l=>l.CategoriaId == id);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                return new Categorium();
            }
        }
    }
}
