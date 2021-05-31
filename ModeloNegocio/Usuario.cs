using Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocio
{
    public class Usuario
    {
        public string correo { get; set; }
        public string contrasena { get; set; }
        public string username { get; set; }
        public string nombre { get; set; }

        String myConnectionString = "database=database-peruvirtual;server=database-peruvirtual.ca4xsdueyhbp.sa-east-1.rds.amazonaws.com;user id=admin;password=aldst367622543;port=3306;";
           // "Database=peruvirtual;Data Source=goesdb.c2mojpcyafa7.us-east-1.rds.amazonaws.com;User Id=root;Password=bryanxd123";

        public String Insertar()
        {
            // If the connection string is null, use a default.
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);
            string myInsertQuery = "Insert into usuario(username,contrasena,correo,nombre) values('"+  "','bryanxd123','bbqms @hotmail.com','Bryan Miramira')";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = myConnection;
            myConnection.Open();
            try
            {
                myCommand.ExecuteNonQuery();
                return "Registro Completo";

            }
            catch (MySqlException ex)
            {
                return ex.ToString();
            }

            /*using (MySqlDataReader reader = myCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    datos += reader["Database"].ToString();
                }
            }*/
            //MessageBox.Show(datos);
            myCommand.Connection.Close();
        }

        public List<usuario> GetUsuarios()
        {
            using (PeruVirtualEntities db = new PeruVirtualEntities()) 
            {
                List<usuario> users = db.usuario.ToList();
                return users;
            }
        }

/*        public bool IsUsernameTaken(string username)
        {
            using (ClassLibrary1.PeruVirtualEntities db = new ClassLibrary1.PeruVirtualEntities())
            {
                var query = (from u in db.usuario
                             where u.nomUsuario == username
                             select new
                             {
                                 u.nomUsuario
                             });
                if (query.Any())
                {
                    return true;
                }
            }
            return false;
        }*/
    }
}
