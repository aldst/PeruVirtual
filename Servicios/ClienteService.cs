using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ClienteService
    {
        /*
        private UsuarioService usuarioService = new UsuarioService();
        public void CreateClient(string email, string contrasenia, string nombreUsuario, string nombre)
        {
            using (ClassLibrary1.PeruVirtualEntities db = new ClassLibrary1.PeruVirtualEntities())
            {
                ClassLibrary1.cliente client = new ClassLibrary1.cliente { correo = email, nombre = nombre };
                db.cliente.Add(client);
                db.SaveChanges();
                var query = (from c in db.cliente
                             where c.correo == email
                             select new
                             {
                                 c.idCliente
                             });
                if (query.Any())
                {
                    this.usuarioService.CreateUser(query.Single().idCliente, nombreUsuario, contrasenia);
                }
            }
        }
        public ClassLibrary1.cliente getClient(int id)
        {
            using (ClassLibrary1.PeruVirtualEntities db = new ClassLibrary1.PeruVirtualEntities())
            {
                var query = db.cliente.Where(c => c.idCliente == id);
                if (query.Any())
                {
                    return query.Single(); 
                }
            }
            return null;
        }
        */
    }
}
