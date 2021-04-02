using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }

    class Utilidades
    {
        public string DirPath()
        {
            //Prod
            //return Environment.CurrentDirectory;
            //Dev
            return Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName).FullName;


        }
    }
}
