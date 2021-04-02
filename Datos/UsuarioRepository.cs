using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{

    public class UsuarioRepository
    {
      

        public List<usuario> GetUsuarios()
        {
            using (PeruVirtualEntities db = new PeruVirtualEntities())
            {
                return db.usuario.ToList();
            }
        }

        public List<usuario> FindUsuario(string username, string contrasena)
        {
            using (PeruVirtualEntities db = new PeruVirtualEntities())
            {
                var users = from b in db.usuario
                            where b.username.Equals(username)
                            where b.contrasena.Equals(contrasena)
                            select b;
                return users.ToList();
            }
        }

        public bool FindByUsername(string username)
        {
            using (PeruVirtualEntities db = new PeruVirtualEntities())
            {
                var users = from b in db.usuario
                            where b.username.Equals(username)
                            select b;
                if (users.ToList().Count()==0)
                {
                    return false;
                }
                return true;
            }
        }
        public bool FindByEmail(string email)
        {
            using (PeruVirtualEntities db = new PeruVirtualEntities())
            {
                var users = from b in db.usuario
                            where b.correo.Equals(email)
                            select b;
                if (users.ToList().Count() == 0)
                {
                    return false;
                }
                return true;
            }
        }
        public int InsertarUsuario(usuario user)
        {
            //0 : exito
            //1 : el username ya existe
            //2 : el correo ya existe
            //3 : error de servidor
            string passEncrypt = Encriptar(user.contrasena);
            user.contrasena = passEncrypt;
            if (FindByUsername(user.username)) { return 1; };
            if (FindByEmail(user.correo)) { return 2; };
            using (PeruVirtualEntities db = new PeruVirtualEntities())
            {
                try
                {
                    db.usuario.Add(user);
                    Console.WriteLine(user.nombre);
                    Console.WriteLine(user.username);
                    Console.WriteLine(user.correo);
                    Console.WriteLine(user.contrasena);
                    db.SaveChanges();

                    return 0;
                }
                catch(Exception ex)
                {

                }
                return 3;
            }
        }
        /// Encripta una cadena
        public string Encriptar( string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

 

        /*static void Main(string[] args)
        {
            /*var user = new usuario();
            user.username = "bbqms";
            user.contrasena = "bryanxd123";
            user.correo = "";
            user.nombre = "";
            using (PeruVirtualEntities db = new PeruVirtualEntities())
            {
                    var users = from b in db.usuario
                                select b;
                    foreach(var i in users.ToList())
                    {
                     Console.WriteLine(i.ToString());
                    }
                    
            }
            
            //Console.ReadKey();
        }*/

    }

}
