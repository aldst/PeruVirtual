using Datos;
using MySql.Data.MySqlClient;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Registro : Form
    {
        private UsuarioService usuarioService = new UsuarioService();


        Utilidades util = new Utilidades();

        public Registro()
        {
            InitializeComponent();
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(util.DirPath() + @"\Resources\Hoodson free font .ttf");
            Lbl_Titulo.Font = new Font(pfc.Families[0], 25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Lbl_nombreDeUsuario.Font = new Font(pfc.Families[0], 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_nombreCompleto.Font = new Font(pfc.Families[0], 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_Email.Font = new Font(pfc.Families[0], 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_contrasena.Font = new Font(pfc.Families[0], 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lbl_confirmarContrasena.Font = new Font(pfc.Families[0], 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (tb_nombre_de_usuario.Text.Length == 0) { lbl_error_nombreusuario.Visible = true; }
            if (tb_nombre_completo.Text.Length == 0) { lbl_error_nombrecompleto.Visible = true; }
            if (tb_email.Text.Length == 0) { lbl_error_email.Visible = true; }
            if (tb_contraseña.Text.Length == 0) { lbl_error_contrasena.Visible = true; }
            if (tb_confimar_contraseña.Text.Length == 0) { lbl_error_confirmarcontra.Visible = true; }

            if (lbl_error_confirmarcontra.Visible || lbl_error_contrasena.Visible || lbl_error_email.Visible ||
                lbl_error_nombreusuario.Visible || lbl_error_nombrecompleto.Visible)
            {
                return;
            }

            if (tb_contraseña.Text != tb_confimar_contraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            usuario user = new usuario();
            user.nombre = tb_nombre_completo.Text;
            user.username = tb_nombre_de_usuario.Text;
            user.correo = tb_email.Text;
            user.contrasena = tb_contraseña.Text;

            int confirmacion = usuarioService.Registro(user);
            switch(confirmacion)
            {
                case 0: MessageBox.Show("Registro Completo"); this.Close(); break;
                case 1: MessageBox.Show("El nombre de usuario ya existe"); break;
                case 2: MessageBox.Show("El correo ya se encuentra registrado");  break;
                case 3: MessageBox.Show("Ocurrio un error en el servidor, intentelo más tarde"); break;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_nombre_de_usuario_TextChanged(object sender, EventArgs e)
        {
            lbl_error_nombreusuario.Visible = false;
            hint_username.Visible = false;
            if(tb_nombre_de_usuario.Text.Length == 0)
            {
                hint_username.Visible = true;
            }
        }

        private void tb_nombre_completo_TextChanged(object sender, EventArgs e)
        {
            lbl_error_nombrecompleto.Visible = false;
            hint_nombreCompleto.Visible = false;
            if (tb_nombre_completo.Text.Length == 0)
            {
                hint_nombreCompleto.Visible = true;
            }
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            lbl_error_email.Visible = false;
            hint_Email.Visible = false;
            if (tb_email.Text.Length == 0)
            {
                hint_Email.Visible = true;
            }
        }

        private void tb_contraseña_TextChanged(object sender, EventArgs e)
        {
            lbl_error_contrasena.Visible = false;
            hint_Contrasena.Visible = false;
            if (tb_contraseña.Text.Length == 0)
            {
                hint_Contrasena.Visible = true;
            }
        }
        private void tb_confimar_contraseña_TextChanged(object sender, EventArgs e)
        {
            lbl_error_confirmarcontra.Visible = false;
            hint_confirmarContrasena.Visible = false;
            if (tb_confimar_contraseña.Text.Length == 0)
            {
                hint_confirmarContrasena.Visible = true;
            }
        }

        private void hint_username_Click(object sender, EventArgs e)
        {
            hint_username.Visible = false;
            ActiveControl = tb_nombre_de_usuario;
            /*if (passwordTB.Text.Length == 0)
            {
                hint_password.Visible = true;
            }*/
        }

        private void hint_nombreCompleto_Click(object sender, EventArgs e)
        {
            hint_nombreCompleto.Visible = false;
            ActiveControl = tb_nombre_completo;
        }

        private void hint_Email_Click(object sender, EventArgs e)
        {
            hint_Email.Visible = false;
            ActiveControl = tb_email;
        }

        private void hint_Contrasena_Click(object sender, EventArgs e)
        {
            hint_Contrasena.Visible = false;
            ActiveControl = tb_contraseña;
        }

        private void hint_confirmarContrasena_Click(object sender, EventArgs e)
        {
            hint_confirmarContrasena.Visible = false;
            ActiveControl = tb_confimar_contraseña;
        }
    }
}
