using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    //Clase qeu representa el codigo otorgado por el response para el almacenamiento del codigo del cliente.
    public class Code
    {
        public string code;
        public string user_code;
        public string verification_uri;
        public int expires_in;
        public int interval;
    }
}
