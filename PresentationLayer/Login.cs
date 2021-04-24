using Servicios;
using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Threading;

namespace PresentationLayer
{
    public partial class Login : Form
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

        Form newForm = new Form();

        //Inicializacion de Servicios
        private UsuarioService usuarioService = new UsuarioService();
        private Facebooklogin facebookLogin = new Facebooklogin();
        //VO
        private VO.Code code = new VO.Code();
        private VO.Autho autho = new VO.Autho();
        private VO.FacebookUser facebookUser = new VO.FacebookUser();
        public VO.Session session;

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (
                int nLeftRect, // X-coordinate of upper-left corner or padding at start
                int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
                int nRightRect, // X-coordinate of lower-right corner or Width of the object
                int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                                //RADIUS, how round do you want it to be?
                int nheightRect, //height of ellipse 
                int nweightRect //width of ellipse
            );

        public Login()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            InitializeComponent();
            Console.WriteLine(LoginBtn.Text);

            Bitmap resized = new Bitmap(Properties.Resources.FBIcon, new Size(25, 25));
            FacebookLoginBtn.Image = resized;
            FacebookLoginBtn.ImageAlign = ContentAlignment.MiddleCenter;
            FacebookLoginBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            FacebookLoginBtn.TextAlign = ContentAlignment.MiddleCenter;
            FacebookLoginBtn.Padding = new Padding(15,0,0,0);

            usernamePanel.Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, usernamePanel.Width, usernamePanel.Height, 15, 15));
            passwordPanel.Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, passwordPanel.Width, passwordPanel.Height, 15, 15));


            RectangleF RectLogin = new RectangleF(0, 0, LoginBtn.Width, LoginBtn.Height);
            RectangleF RectLoginFB = new RectangleF(0, 0, FacebookLoginBtn.Width, FacebookLoginBtn.Height);

            using (GraphicsPath GraphPath = GetRoundPath(RectLogin, 30))
            {
                LoginBtn.Region = new Region(GraphPath);
            }
            using (GraphicsPath GraphPath = GetRoundPath(RectLoginFB, 30))
            {
                FacebookLoginBtn.Region = new Region(GraphPath);
            }
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(util.DirPath() + @"\Resources\Hoodson free font .ttf");
            Lbl_topPanel.Font = new Font(pfc.Families[0], 23F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            ActiveControl = usernameTB;

        }

        private async void FacebookLoginBtn_Click(object sender, EventArgs e)
        {
            this.code = await facebookLogin.getCode();
            newForm = new Form();
            newForm.Size = new Size(600, 400);
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.FormBorderStyle = FormBorderStyle.None;

            WebBrowser FacebookBrowser = new WebBrowser();
            newForm.Controls.Add(FacebookBrowser);
            FacebookBrowser.Dock = DockStyle.Fill;


            Panel CodePanel = new Panel();
            newForm.Controls.Add(CodePanel);
            CodePanel.Dock = DockStyle.Bottom;
            CodePanel.Height = 50;
            CodePanel.BackColor = Color.Red;
            Label lblCode = new Label();
            CodePanel.Controls.Add(lblCode);

            lblCode.Dock = DockStyle.Fill;
            lblCode.TextAlign = ContentAlignment.MiddleCenter;
            lblCode.Text = "Tu código es: " + this.code.user_code;
            lblCode.Font = new Font(lblCode.Font.Name, 15);
            lblCode.ForeColor = Color.White;


            newForm.Show();
            FacebookBrowser.Navigate(this.code.verification_uri.ToString());            
            timer1.Enabled = true;
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
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
                        //Resize();
                    }
                    else
                    {
                        Restaurar.Visible = false;
                        Maximizar.Visible = true;
                        WindowState = FormWindowState.Normal;
                        //Resize();
                    }

                }
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            this.autho = await facebookLogin.getAuth(this.code.code);
            if (autho.access_token != null)
            {
                Form cargandoForm = new Form();
                cargandoForm.Size = new Size(200, 200);
                PictureBox gif = new PictureBox();
                cargandoForm.Controls.Add(gif);
                gif.Dock = DockStyle.Fill;
                gif.Image = Properties.Resources.obteniendo_mapa;
                gif.BackColor = Color.Transparent;
                gif.SizeMode = PictureBoxSizeMode.StretchImage;
                cargandoForm.BackColor = Color.AntiqueWhite;
                cargandoForm.TransparencyKey = Color.AntiqueWhite;
                cargandoForm.FormBorderStyle = FormBorderStyle.None;
                cargandoForm.StartPosition = FormStartPosition.CenterScreen;
                cargandoForm.Show();
                await Task.Delay(2000);

                
                this.facebookUser=await facebookLogin.getUser(autho.access_token);
                session = new VO.Session(facebookUser.name, facebookUser.email);
                Console.WriteLine(session.Nombre + " " + session.Email);

                timer1.Stop();
                timer1.Enabled = false;
                newForm.Close();

                Hide();
                cargandoForm.Close();
                Main main = new Main();
                main.Show();
            }
        }

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

        private void Maximizar_Click(object sender, EventArgs e)
        {
            
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {

        }

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

        private void lblRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registroForm = new Registro();
            //registroForm.Parent = this.Parent;
            registroForm.StartPosition = FormStartPosition.CenterParent;
            registroForm.ShowDialog();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            if(usernameTB.Text.Length == 0)
            {
                MessageBox.Show("El nombre de usuario no puede estar vacio.","Complete los campos");
                return;
            }
            if (passwordTB.Text.Length == 0)
            {
                MessageBox.Show("La contraseña no puede estar vacia.", "Complete los campos");
                return;
            }

            var login = usuarioService.Login(usernameTB.Text, passwordTB.Text);

            if(login)
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
            {
                MessageBox.Show("No se encuentra registrado.", "Lo sentimos...");
            }
        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {
            if(usernameTB.Text.Length == 0)
            {
                hint_username.Visible = true;
            }
            else
            {
                hint_username.Visible = false;
            }
        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {
            if (passwordTB.Text.Length == 0)
            {
                hint_password.Visible = true;
            }
            else
            {
                hint_password.Visible = false;
            }
        }

        private void hint_password_Click(object sender, EventArgs e)
        {
            hint_password.Visible = false;
            ActiveControl = passwordTB;
            if (usernameTB.Text.Length == 0)
            {
                hint_username.Visible = true;
            }
        }

        private void hint_username_Click(object sender, EventArgs e)
        {
            hint_username.Visible = false;
            ActiveControl = usernameTB;
            if (passwordTB.Text.Length == 0) {
                hint_password.Visible = true;
            }
        }

        private void passwordTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn.PerformClick();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            espanol.Visible = true;
            ingles.Visible = true;
        }

        private void idioma_icon_DoubleClick(object sender, EventArgs e)
        {
            espanol.Visible = false;
            ingles.Visible = false;
        }

        private void espanol_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-PE");
            this.Controls.Clear();
            InitializeComponent();
        }

        private void ingles_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            this.Controls.Clear();
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

    }
}
