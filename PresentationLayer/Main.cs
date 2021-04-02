using PresentationLayer.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Main : Form
    {
        //---------------Para mover la ventana------------------------//
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //-----------------------------------------------------------//


        private Utilidades util = new Utilidades();


        public string Selected = "Machu Picchu";

        RoundedButton Button_Explorar2 = new RoundedButton();

        PrivateFontCollection pfc = new PrivateFontCollection();

        public Main()
        {
            InitializeComponent();
            this.Icon = Resources.MachuIcon;
            VideoPlayer.uiMode = "none";
            VideoPlayer.settings.volume = 0;
            VideoPlayer.enableContextMenu = false;
            VideoPlayer.URL = util.DirPath() + @"\Videos\MachuPicchu.mp4";
            VideoPlayer.settings.setMode("loop", true);
            VideoPlayer.Ctlenabled = false;
            VideoPlayer.stretchToFit = true;

            Button_Explorar2.Anchor = Button_Explorar.Anchor;
            Button_Explorar2.BackgroundImage = Button_Explorar.BackgroundImage;
            Button_Explorar2.BackgroundImageLayout = Button_Explorar.BackgroundImageLayout;
            Button_Explorar2.MouseClick += Opciones_Antiguo_Nuevo;
            Button_Explorar2.FlatStyle = FlatStyle.Flat;
            Resize();
            Button_Explorar.Visible = false;
            //Console.WriteLine(Button_Explorar.Location);

            //VideoPlayer.Ctlcontrols.play();

            pfc.AddFontFile(util.DirPath() + @"\Resources\Hoodson free font .ttf");
            Lbl_panelTop.Font = new Font(pfc.Families[0], 23F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            LblTitulo.Font = new Font(pfc.Families[0], 40F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Button_Explorar2.Font = new Font(pfc.Families[0], 21.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }
        //------------Manejo de Ventana-------------------------------//
        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {

            }
        }
        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Restaurar_Click(object sender, EventArgs e)
        {
            Restaurar.Visible = false;
            Maximizar.Visible = true;
            WindowState = FormWindowState.Normal;
            Resize();
        }
        private void Maximizar_Click(object sender, EventArgs e)
        {
            Restaurar.Visible = true;
            Maximizar.Visible = false;
            WindowState = FormWindowState.Maximized;
            Resize();
        }
        private void TaskPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 2)
                {
                    if (WindowState == FormWindowState.Normal)
                    {
                        Restaurar.Visible = true;
                        Maximizar.Visible = false;
                        WindowState = FormWindowState.Maximized;
                        Resize();
                    }
                    else
                    {
                        Restaurar.Visible = false;
                        Maximizar.Visible = true;
                        WindowState = FormWindowState.Normal;
                        Resize();
                    }

                }
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
        //-----------------------------------------------------------//


        //-----------------------Opciones----------------------------//
        private void MachuPicchu_Click(object sender, EventArgs e)
        {
            if (Selected == "Machu Picchu") return;
            LblTitulo.Text = "Machu Picchu";
            LblTitulo.Font = new Font(pfc.Families[0], 40F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            VideoPlayer.URL = util.DirPath() + @"\Videos\MachuPicchu.mp4";
            Selected = "Machu Picchu";
            if (MachuPicchu.BorderStyle == BorderStyle.None)
            {
                MachuPicchu.BorderStyle = BorderStyle.FixedSingle;
                Caral.BorderStyle = BorderStyle.None;
                Nazca.BorderStyle = BorderStyle.None;
                Sacsayhuaman.BorderStyle = BorderStyle.None;
                //Paracas.BorderStyle = BorderStyle.None;

                MachuPicchu.Padding = new Padding(2);
                Caral.Padding = new Padding(0);
                Nazca.Padding = new Padding(0);
                Sacsayhuaman.Padding = new Padding(0);
                //Paracas.Padding = new Padding(0);
            }
    
                        }

        private void Caral_Click(object sender, EventArgs e)
        {
            if (Selected == "Caral") return;
            LblTitulo.Text = "Caral";
            LblTitulo.Font = new Font(pfc.Families[0], 40F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            VideoPlayer.URL = util.DirPath() + @"\Videos\Caral.mp4";
            Selected = "Caral";
            if (Caral.BorderStyle == BorderStyle.None)
            {
                MachuPicchu.BorderStyle = BorderStyle.None;
                Caral.BorderStyle = BorderStyle.FixedSingle;
                Sacsayhuaman.BorderStyle = BorderStyle.None;
                Nazca.BorderStyle = BorderStyle.None;
                //Paracas.BorderStyle = BorderStyle.None;

                MachuPicchu.Padding = new Padding(0);
                Caral.Padding = new Padding(2);
                Sacsayhuaman.Padding = new Padding(0);
                Nazca.Padding = new Padding(0);
                //Paracas.Padding = new Padding(0);

            }
        }
        private void Sacsayhuaman_Click(object sender, EventArgs e)
        {
            if (Selected == "Sacsayhuaman") return;
            LblTitulo.Text = "Sacsayhuaman";
            LblTitulo.Font = new Font(pfc.Families[0], 40F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            VideoPlayer.URL = util.DirPath() + @"\Videos\Sacsayhuaman.mp4";
            Selected = "Sacsayhuaman";
            if (Sacsayhuaman.BorderStyle == BorderStyle.None)
            {
                MachuPicchu.BorderStyle = BorderStyle.None;
                Caral.BorderStyle = BorderStyle.None;
                Sacsayhuaman.BorderStyle = BorderStyle.FixedSingle;
                Nazca.BorderStyle = BorderStyle.None;
                //Paracas.BorderStyle = BorderStyle.None;

                MachuPicchu.Padding = new Padding(0);
                Caral.Padding = new Padding(0);
                Sacsayhuaman.Padding = new Padding(2);
                Nazca.Padding = new Padding(0);
                //Paracas.Padding = new Padding(0);
            }
        }
        private void Nazca_Click(object sender, EventArgs e)
        {
            if (Selected == "Nazca") return;
            LblTitulo.Text = "Nazca";
            LblTitulo.Font = new Font(pfc.Families[0], 40F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            VideoPlayer.URL = util.DirPath() + @"\Videos\Nazca.mp4";
            Selected = "Nazca";
            if (Nazca.BorderStyle == BorderStyle.None)
            {
                MachuPicchu.BorderStyle = BorderStyle.None;
                Caral.BorderStyle = BorderStyle.None;
                Sacsayhuaman.BorderStyle = BorderStyle.None;
                Nazca.BorderStyle = BorderStyle.FixedSingle;
                //Paracas.BorderStyle = BorderStyle.None;

                MachuPicchu.Padding = new Padding(0);
                Caral.Padding = new Padding(0);
                Sacsayhuaman.Padding = new Padding(0);
                Nazca.Padding = new Padding(2);
                //Paracas.Padding = new Padding(0);
            }

        }
        
        private void Paracas_Click(object sender, EventArgs e)
        {
            if (Selected == "Paracas") return;
            LblTitulo.Text = "Paracas";
            LblTitulo.Font = new Font(pfc.Families[0], 40F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            VideoPlayer.URL = util.DirPath() + @"\Videos\Paracas.mp4";
            Selected = "Paracas";
            if (Sacsayhuaman.BorderStyle == BorderStyle.None)
            {
                MachuPicchu.BorderStyle = BorderStyle.None;
                Caral.BorderStyle = BorderStyle.None;
                Sacsayhuaman.BorderStyle = BorderStyle.None;
                Nazca.BorderStyle = BorderStyle.None;
                //Paracas.BorderStyle = BorderStyle.FixedSingle;

                MachuPicchu.Padding = new Padding(0);
                Caral.Padding = new Padding(0);
                Sacsayhuaman.Padding = new Padding(0);
                Nazca.Padding = new Padding(0);
                //Paracas.Padding = new Padding(2);
            }
        }
        //----------------------------------------------------------//



        private void Resize()
        {
            PanelOpciones.Height =  this.Height/6;
            PanelVideo.Width = this.Width / 4 * 3;
            MachuPicchu.Size = new Size(Width / 4, PanelOpciones.Height);
            Caral.Size = new Size(Width / 4, PanelOpciones.Height);
            Sacsayhuaman.Size = new Size(Width / 4, PanelOpciones.Height);
            Nazca.Size = new Size(Width / 4, PanelOpciones.Height);
            //Paracas.Size = new Size(Width / 5, PanelOpciones.Height);

            MachuPicchu.Location = new Point(Width / 4 * 0, MachuPicchu.Location.Y);
            Caral.Location = new Point(Width / 4 * 1, Caral.Location.Y);
            Sacsayhuaman.Location = new Point(Width / 4 * 2, Sacsayhuaman.Location.Y);
            Nazca.Location = new Point(Width / 4 * 3, Nazca.Location.Y);
            //Paracas.Location = new Point(Width / 5 * 4, Paracas.Location.Y);
            //Console.WriteLine(PanelExplorar.Size);
            PanelVideo.Controls.Add(Button_Explorar2);
            Button_Explorar2.Size = new Size( (int) (PanelVideo.Width / 5.12) , (int) (PanelVideo.Height/9.5));
            Button_Explorar2.Left = (PanelVideo.Width / 2) - (Button_Explorar2.Width / 2);
            Button_Explorar2.Top = (PanelVideo.Height ) - (Button_Explorar2.Height+10);
            Button_Explorar2.BringToFront();
        }


        private void MachuPicchu_MouseEnter(object sender, EventArgs e)
        {
            MachuPicchu.Image = Resources.MacchuPicchuSelected;
        }

        private void MachuPicchu_MouseLeave(object sender, EventArgs e)
        {
            MachuPicchu.Image = Resources.MacchuPicchu;
        }

        private void Caral_MouseEnter(object sender, EventArgs e)
        {
            Caral.Image = Resources.CaralSelected;
        }

        private void Caral_MouseLeave(object sender, EventArgs e)
        {
            Caral.Image = Resources.Caral;
        }

        private void Nazca_MouseEnter(object sender, EventArgs e)
        {
            Nazca.Image = Resources.NazcaSelected;
        }

        private void Nazca_MouseLeave(object sender, EventArgs e)
        {
            Nazca.Image = Resources.Nazca;

        }
        private void Sacsayhuaman_MouseEnter(object sender, EventArgs e)
        {
            Sacsayhuaman.Image = Resources.SacsayhumanaSelected;

        }

        private void Sacsayhuaman_MouseLeave(object sender, EventArgs e)
        {
            Sacsayhuaman.Image = Resources.Sacsayhuman;

        }
        private void Paracas_MouseEnter(object sender, EventArgs e)
        {
            //Paracas.Image = Resources.ParacasSelected;
        }

        private void Paracas_MouseLeave(object sender, EventArgs e)
        {
            //Paracas.Image = Resources.Paracas;

        }


        private void VideoPlayer_MouseDownEvent(object sender, AxWMPLib._WMPOCXEvents_MouseDownEvent e)
        {
            return;
        }

        //-------------------------Boton Antiguo-Nuevo--------------------//
        private void Opciones_Antiguo_Nuevo(object sender, EventArgs e)
        {
            Opciones opciones = new Opciones();

            opciones.Selected = Selected;
            //opciones.setSeleccionado(Selected);
            opciones.StartPosition = FormStartPosition.CenterParent;
            opciones.ShowDialog();
        }

        private void CloseSession_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que desea cerrar sesión? \nSera enviado a la pantalla principal.", "Confirmación de cierre de sesión", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
                Login login = new Login();
                login.Show();
            }
            else if (result == DialogResult.No)
            {

            }

        }

    }
    class RoundedButton : Button
    {
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, 50))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.Black, 1.75f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }
    }
}
