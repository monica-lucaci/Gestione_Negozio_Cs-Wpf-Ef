using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_GestioneNegozio.DAL
{
    internal interface IDal<T>
    {
        List<T> GetAll();
        T findById(int id);
        bool Insert(T t);
        bool Update(T t);
        bool Delete(int id);
       
         

    }
}
