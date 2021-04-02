using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Session
    {
        private string nombre;
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }
        private string email;
        public string Email{
            get { return email; }
            set { email = value; }
        }

        public Session(string nombre, string email)
        {
            this.nombre = nombre;
            this.email = email;
        }

    }
}
