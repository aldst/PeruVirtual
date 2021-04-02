using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Opciones : Form
    {

        public string Selected = "";


        private Utilidades util = new Utilidades();
        PrivateFontCollection pfc = new PrivateFontCollection();

        public Opciones()
        {
            InitializeComponent();
            btnAntiguo.FlatAppearance.BorderSize = 0;
            btnActual.FlatAppearance.BorderSize = 0;
            pfc.AddFontFile(util.DirPath() + @"\Resources\Hoodson free font .ttf");
            label1.Font = new Font(pfc.Families[0], 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnActual_Click(object sender, EventArgs e)
        {
            Process p;
            switch (Selected)
            {
                case "Machu Picchu":
                    p = Process.Start(util.DirPath() + @"\Lugares\MachuPicchu\MachuPicchu.exe");
                    p.WaitForInputIdle();
                    break;
                case "Caral":
                    p = Process.Start(util.DirPath() + @"\Lugares\Caral\TheRealCaral.exe");
                    p.WaitForInputIdle();
                    break;
                case "Sacsayhuaman": MessageBox.Show("Sin implementar"); break;
                case "Nazca": MessageBox.Show("Sin implementar"); break;
                case "Paracas": MessageBox.Show("Sin implementar"); break;
                default: break;
            }
        }

        private void btnAntiguo_Click(object sender, EventArgs e)
        {
            Process p;
            switch (Selected)
            {
                case "Machu Picchu": MessageBox.Show("Sin implementar");  break;
                case "Caral": MessageBox.Show("Sin implementar"); break;
                case "Sacsayhuaman": MessageBox.Show("Sin implementar"); break;
                case "Nazca": MessageBox.Show("Sin implementar"); break;
                case "Paracas": MessageBox.Show("Sin implementar"); break;
                default: break;
            }
        }

        public void setSeleccionado(String seleccionado)
        {
            Selected = seleccionado;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Close();
        }
    }
}
