using Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class UsuarioService
    {
        UsuarioRepository usuarioRep = new UsuarioRepository();
        public bool Login(String username, String contrasena)
        {
            List<usuario> users = usuarioRep.FindUsuario(username, Encriptar(contrasena));
            if (users.Count != 0)
            {
                return true;
            }
            return false;
        }

        public int Registro(usuario user)
        {
           return usuarioRep.InsertarUsuario(user);
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
        public string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /*static void Main(string[] args)
        {
            UsuarioRepository usuarioRep = new UsuarioRepository();
            var users = usuarioRep.GetUsuarios();

            Console.WriteLine(users.ToString());
            Console.ReadKey();
        }*/

        /*
        public int AccesClient(string nombreUsuario, string contrasenia)
        {
            using (ClassLibrary1.PeruVirtualEntities db = new ClassLibrary1.PeruVirtualEntities())
            {
                var query = (from u in db.usuario
                             where u.nomUsuario == nombreUsuario && u.contrasenia == contrasenia
                             select new
                             {
                                 u.idCliente,
                                 u.idUsuario
                             });
                if (query.Any())
                {
                    return query.Single().idCliente;
                }
            }
            return 0;
        }

        public void CreateUser(int idcliente, string nombreUsuario, string contrasenia)
        {
            using (ClassLibrary1.PeruVirtualEntities db = new ClassLibrary1.PeruVirtualEntities())
            {
                ClassLibrary1.usuario user = new ClassLibrary1.usuario{
                                                                        idCliente = idcliente,
                                                                        nomUsuario = nombreUsuario,
                                                                        contrasenia = contrasenia
                                                                        };
                db.usuario.Add(user);
                db.SaveChanges();
            }
        }
        */
    }
}
