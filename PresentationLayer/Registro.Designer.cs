namespace PresentationLayer
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_error_confirmarcontra = new System.Windows.Forms.Label();
            this.lbl_error_contrasena = new System.Windows.Forms.Label();
            this.lbl_error_email = new System.Windows.Forms.Label();
            this.lbl_error_nombrecompleto = new System.Windows.Forms.Label();
            this.lbl_error_nombreusuario = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.tb_confimar_contraseña = new System.Windows.Forms.TextBox();
            this.tb_contraseña = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_nombre_completo = new System.Windows.Forms.TextBox();
            this.tb_nombre_de_usuario = new System.Windows.Forms.TextBox();
            this.lbl_confirmarContrasena = new System.Windows.Forms.Label();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_nombreCompleto = new System.Windows.Forms.Label();
            this.Lbl_nombreDeUsuario = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.hint_username = new System.Windows.Forms.Label();
            this.hint_nombreCompleto = new System.Windows.Forms.Label();
            this.hint_Email = new System.Windows.Forms.Label();
            this.hint_Contrasena = new System.Windows.Forms.Label();
            this.hint_confirmarContrasena = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PresentationLayer.Properties.Resources.Fondo_Registro;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.hint_confirmarContrasena);
            this.panel1.Controls.Add(this.hint_Contrasena);
            this.panel1.Controls.Add(this.hint_Email);
            this.panel1.Controls.Add(this.hint_nombreCompleto);
            this.panel1.Controls.Add(this.hint_username);
            this.panel1.Controls.Add(this.lbl_error_confirmarcontra);
            this.panel1.Controls.Add(this.lbl_error_contrasena);
            this.panel1.Controls.Add(this.lbl_error_email);
            this.panel1.Controls.Add(this.lbl_error_nombrecompleto);
            this.panel1.Controls.Add(this.lbl_error_nombreusuario);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_registrar);
            this.panel1.Controls.Add(this.Lbl_Titulo);
            this.panel1.Controls.Add(this.tb_confimar_contraseña);
            this.panel1.Controls.Add(this.tb_contraseña);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.tb_nombre_completo);
            this.panel1.Controls.Add(this.lbl_confirmarContrasena);
            this.panel1.Controls.Add(this.lbl_contrasena);
            this.panel1.Controls.Add(this.lbl_Email);
            this.panel1.Controls.Add(this.lbl_nombreCompleto);
            this.panel1.Controls.Add(this.Lbl_nombreDeUsuario);
            this.panel1.Controls.Add(this.tb_nombre_de_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 419);
            this.panel1.TabIndex = 14;
            // 
            // lbl_error_confirmarcontra
            // 
            this.lbl_error_confirmarcontra.AutoSize = true;
            this.lbl_error_confirmarcontra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error_confirmarcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_confirmarcontra.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_confirmarcontra.Location = new System.Drawing.Point(206, 273);
            this.lbl_error_confirmarcontra.Name = "lbl_error_confirmarcontra";
            this.lbl_error_confirmarcontra.Size = new System.Drawing.Size(154, 13);
            this.lbl_error_confirmarcontra.TabIndex = 29;
            this.lbl_error_confirmarcontra.Text = "*Este campo es necesario";
            this.lbl_error_confirmarcontra.Visible = false;
            // 
            // lbl_error_contrasena
            // 
            this.lbl_error_contrasena.AutoSize = true;
            this.lbl_error_contrasena.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_contrasena.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_contrasena.Location = new System.Drawing.Point(207, 231);
            this.lbl_error_contrasena.Name = "lbl_error_contrasena";
            this.lbl_error_contrasena.Size = new System.Drawing.Size(154, 13);
            this.lbl_error_contrasena.TabIndex = 28;
            this.lbl_error_contrasena.Text = "*Este campo es necesario";
            this.lbl_error_contrasena.Visible = false;
            // 
            // lbl_error_email
            // 
            this.lbl_error_email.AutoSize = true;
            this.lbl_error_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_email.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_email.Location = new System.Drawing.Point(207, 191);
            this.lbl_error_email.Name = "lbl_error_email";
            this.lbl_error_email.Size = new System.Drawing.Size(154, 13);
            this.lbl_error_email.TabIndex = 27;
            this.lbl_error_email.Text = "*Este campo es necesario";
            this.lbl_error_email.Visible = false;
            // 
            // lbl_error_nombrecompleto
            // 
            this.lbl_error_nombrecompleto.AutoSize = true;
            this.lbl_error_nombrecompleto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error_nombrecompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_nombrecompleto.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_nombrecompleto.Location = new System.Drawing.Point(207, 146);
            this.lbl_error_nombrecompleto.Name = "lbl_error_nombrecompleto";
            this.lbl_error_nombrecompleto.Size = new System.Drawing.Size(154, 13);
            this.lbl_error_nombrecompleto.TabIndex = 26;
            this.lbl_error_nombrecompleto.Text = "*Este campo es necesario";
            this.lbl_error_nombrecompleto.Visible = false;
            // 
            // lbl_error_nombreusuario
            // 
            this.lbl_error_nombreusuario.AutoSize = true;
            this.lbl_error_nombreusuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error_nombreusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_nombreusuario.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_nombreusuario.Location = new System.Drawing.Point(207, 105);
            this.lbl_error_nombreusuario.Name = "lbl_error_nombreusuario";
            this.lbl_error_nombreusuario.Size = new System.Drawing.Size(154, 13);
            this.lbl_error_nombreusuario.TabIndex = 16;
            this.lbl_error_nombreusuario.Text = "*Este campo es necesario";
            this.lbl_error_nombreusuario.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(84, 309);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(160, 39);
            this.btn_cancelar.TabIndex = 25;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(285, 309);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(160, 39);
            this.btn_registrar.TabIndex = 24;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Hoodson Script Free Demo", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(212, 19);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(109, 44);
            this.Lbl_Titulo.TabIndex = 23;
            this.Lbl_Titulo.Text = "Registro";
            // 
            // tb_confimar_contraseña
            // 
            this.tb_confimar_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confimar_contraseña.Location = new System.Drawing.Point(208, 244);
            this.tb_confimar_contraseña.Name = "tb_confimar_contraseña";
            this.tb_confimar_contraseña.PasswordChar = '*';
            this.tb_confimar_contraseña.Size = new System.Drawing.Size(188, 26);
            this.tb_confimar_contraseña.TabIndex = 22;
            this.tb_confimar_contraseña.TextChanged += new System.EventHandler(this.tb_confimar_contraseña_TextChanged);
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.BackColor = System.Drawing.Color.White;
            this.tb_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contraseña.Location = new System.Drawing.Point(208, 202);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.PasswordChar = '*';
            this.tb_contraseña.Size = new System.Drawing.Size(188, 26);
            this.tb_contraseña.TabIndex = 21;
            this.tb_contraseña.TextChanged += new System.EventHandler(this.tb_contraseña_TextChanged);
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(208, 162);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(188, 26);
            this.tb_email.TabIndex = 20;
            this.tb_email.TextChanged += new System.EventHandler(this.tb_email_TextChanged);
            // 
            // tb_nombre_completo
            // 
            this.tb_nombre_completo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre_completo.Location = new System.Drawing.Point(208, 119);
            this.tb_nombre_completo.Name = "tb_nombre_completo";
            this.tb_nombre_completo.Size = new System.Drawing.Size(188, 26);
            this.tb_nombre_completo.TabIndex = 19;
            this.tb_nombre_completo.TextChanged += new System.EventHandler(this.tb_nombre_completo_TextChanged);
            // 
            // tb_nombre_de_usuario
            // 
            this.tb_nombre_de_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre_de_usuario.Location = new System.Drawing.Point(208, 78);
            this.tb_nombre_de_usuario.Name = "tb_nombre_de_usuario";
            this.tb_nombre_de_usuario.Size = new System.Drawing.Size(188, 26);
            this.tb_nombre_de_usuario.TabIndex = 18;
            this.tb_nombre_de_usuario.TextChanged += new System.EventHandler(this.tb_nombre_de_usuario_TextChanged);
            // 
            // lbl_confirmarContrasena
            // 
            this.lbl_confirmarContrasena.AutoSize = true;
            this.lbl_confirmarContrasena.Font = new System.Drawing.Font("Hoodson Script Free Demo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmarContrasena.Location = new System.Drawing.Point(52, 244);
            this.lbl_confirmarContrasena.Name = "lbl_confirmarContrasena";
            this.lbl_confirmarContrasena.Size = new System.Drawing.Size(141, 25);
            this.lbl_confirmarContrasena.TabIndex = 17;
            this.lbl_confirmarContrasena.Text = "Confirmar contraseña";
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Font = new System.Drawing.Font("Hoodson Script Free Demo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contrasena.Location = new System.Drawing.Point(116, 200);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(77, 25);
            this.lbl_contrasena.TabIndex = 16;
            this.lbl_contrasena.Text = "Contraseña";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Hoodson Script Free Demo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(145, 160);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(48, 25);
            this.lbl_Email.TabIndex = 15;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_nombreCompleto
            // 
            this.lbl_nombreCompleto.AutoSize = true;
            this.lbl_nombreCompleto.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_nombreCompleto.Font = new System.Drawing.Font("Hoodson Script Free Demo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreCompleto.Location = new System.Drawing.Point(74, 120);
            this.lbl_nombreCompleto.Name = "lbl_nombreCompleto";
            this.lbl_nombreCompleto.Size = new System.Drawing.Size(119, 25);
            this.lbl_nombreCompleto.TabIndex = 14;
            this.lbl_nombreCompleto.Text = "Nombre Completo";
            // 
            // Lbl_nombreDeUsuario
            // 
            this.Lbl_nombreDeUsuario.AutoSize = true;
            this.Lbl_nombreDeUsuario.Font = new System.Drawing.Font("Hoodson Script Free Demo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreDeUsuario.Location = new System.Drawing.Point(63, 78);
            this.Lbl_nombreDeUsuario.Name = "Lbl_nombreDeUsuario";
            this.Lbl_nombreDeUsuario.Size = new System.Drawing.Size(130, 25);
            this.Lbl_nombreDeUsuario.TabIndex = 13;
            this.Lbl_nombreDeUsuario.Text = "Nombre de Usuario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.Salir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 31);
            this.panel2.TabIndex = 15;
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(501, 5);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(21, 22);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 5;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // hint_username
            // 
            this.hint_username.BackColor = System.Drawing.Color.White;
            this.hint_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hint_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint_username.ForeColor = System.Drawing.Color.Silver;
            this.hint_username.Location = new System.Drawing.Point(214, 81);
            this.hint_username.Name = "hint_username";
            this.hint_username.Size = new System.Drawing.Size(174, 22);
            this.hint_username.TabIndex = 16;
            this.hint_username.Text = "Nombre de Usuario";
            this.hint_username.Click += new System.EventHandler(this.hint_username_Click);
            // 
            // hint_nombreCompleto
            // 
            this.hint_nombreCompleto.BackColor = System.Drawing.Color.White;
            this.hint_nombreCompleto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hint_nombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint_nombreCompleto.ForeColor = System.Drawing.Color.Silver;
            this.hint_nombreCompleto.Location = new System.Drawing.Point(213, 122);
            this.hint_nombreCompleto.Name = "hint_nombreCompleto";
            this.hint_nombreCompleto.Size = new System.Drawing.Size(175, 20);
            this.hint_nombreCompleto.TabIndex = 30;
            this.hint_nombreCompleto.Text = "Nombre Completo";
            this.hint_nombreCompleto.Click += new System.EventHandler(this.hint_nombreCompleto_Click);
            // 
            // hint_Email
            // 
            this.hint_Email.BackColor = System.Drawing.Color.White;
            this.hint_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hint_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint_Email.ForeColor = System.Drawing.Color.Silver;
            this.hint_Email.Location = new System.Drawing.Point(214, 165);
            this.hint_Email.Name = "hint_Email";
            this.hint_Email.Size = new System.Drawing.Size(174, 20);
            this.hint_Email.TabIndex = 31;
            this.hint_Email.Text = "Email";
            this.hint_Email.Click += new System.EventHandler(this.hint_Email_Click);
            // 
            // hint_Contrasena
            // 
            this.hint_Contrasena.BackColor = System.Drawing.Color.White;
            this.hint_Contrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hint_Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint_Contrasena.ForeColor = System.Drawing.Color.Silver;
            this.hint_Contrasena.Location = new System.Drawing.Point(214, 205);
            this.hint_Contrasena.Name = "hint_Contrasena";
            this.hint_Contrasena.Size = new System.Drawing.Size(174, 20);
            this.hint_Contrasena.TabIndex = 32;
            this.hint_Contrasena.Text = "Contraseña";
            this.hint_Contrasena.Click += new System.EventHandler(this.hint_Contrasena_Click);
            // 
            // hint_confirmarContrasena
            // 
            this.hint_confirmarContrasena.BackColor = System.Drawing.Color.White;
            this.hint_confirmarContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hint_confirmarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint_confirmarContrasena.ForeColor = System.Drawing.Color.Silver;
            this.hint_confirmarContrasena.Location = new System.Drawing.Point(212, 247);
            this.hint_confirmarContrasena.Name = "hint_confirmarContrasena";
            this.hint_confirmarContrasena.Size = new System.Drawing.Size(176, 20);
            this.hint_confirmarContrasena.TabIndex = 33;
            this.hint_confirmarContrasena.Text = "Confirmar Contraseña";
            this.hint_confirmarContrasena.Click += new System.EventHandler(this.hint_confirmarContrasena_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.TextBox tb_confimar_contraseña;
        private System.Windows.Forms.TextBox tb_contraseña;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_nombre_completo;
        private System.Windows.Forms.TextBox tb_nombre_de_usuario;
        private System.Windows.Forms.Label lbl_confirmarContrasena;
        private System.Windows.Forms.Label lbl_contrasena;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_nombreCompleto;
        private System.Windows.Forms.Label Lbl_nombreDeUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label lbl_error_nombreusuario;
        private System.Windows.Forms.Label lbl_error_confirmarcontra;
        private System.Windows.Forms.Label lbl_error_contrasena;
        private System.Windows.Forms.Label lbl_error_email;
        private System.Windows.Forms.Label lbl_error_nombrecompleto;
        private System.Windows.Forms.Label hint_confirmarContrasena;
        private System.Windows.Forms.Label hint_Contrasena;
        private System.Windows.Forms.Label hint_Email;
        private System.Windows.Forms.Label hint_nombreCompleto;
        private System.Windows.Forms.Label hint_username;
    }
}