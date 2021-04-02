using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocio
{
    public class Cliente{


        /*
        public List<ClassLibrary1.cliente> GetClientes()
        {
            using (ClassLibrary1.PeruVirtualEntities db = new ClassLibrary1.PeruVirtualEntities())
            {
                return db.cliente.ToList();
            }
        }
        public bool IsEmailTaken(string email)
        {
            using (ClassLibrary1.PeruVirtualEntities db = new ClassLibrary1.PeruVirtualEntities())
            {
                var query = (from c in db.cliente
                             where c.correo == email
                             select new
                             {
                                 c.correo
                             });
                if (query.Any())
                {
                    return true;
                }
            }
            return false;
        }
        */
    }
}
