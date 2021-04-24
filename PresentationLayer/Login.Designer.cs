namespace PresentationLayer
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.topPanel = new System.Windows.Forms.Panel();
            this.language_icon = new System.Windows.Forms.PictureBox();
            this.Lbl_topPanel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.english = new System.Windows.Forms.PictureBox();
            this.espanol = new System.Windows.Forms.PictureBox();
            this.lblRegistrate = new System.Windows.Forms.LinkLabel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.hint_password = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.hint_username = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.FacebookLoginBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.language_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.english)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espanol)).BeginInit();
            this.passwordPanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.language_icon);
            this.topPanel.Controls.Add(this.Lbl_topPanel);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.Maximizar);
            this.topPanel.Controls.Add(this.Minimizar);
            this.topPanel.Controls.Add(this.Restaurar);
            this.topPanel.Controls.Add(this.Salir);
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.Name = "topPanel";
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // language_icon
            // 
            this.language_icon.BackColor = System.Drawing.Color.Transparent;
            this.language_icon.BackgroundImage = global::PresentationLayer.Properties.Resources.idioma_icon_2;
            resources.ApplyResources(this.language_icon, "language_icon");
            this.language_icon.Name = "language_icon";
            this.language_icon.TabStop = false;
            this.language_icon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.language_icon_MouseClick);
            // 
            // Lbl_topPanel
            // 
            resources.ApplyResources(this.Lbl_topPanel, "Lbl_topPanel");
            this.Lbl_topPanel.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_topPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_topPanel.Name = "Lbl_topPanel";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Maximizar
            // 
            resources.ApplyResources(this.Maximizar, "Maximizar");
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Minimizar
            // 
            resources.ApplyResources(this.Minimizar, "Minimizar");
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Restaurar
            // 
            resources.ApplyResources(this.Restaurar, "Restaurar");
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.TabStop = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Salir
            // 
            resources.ApplyResources(this.Salir, "Salir");
            this.Salir.Name = "Salir";
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PresentationLayer.Properties.Resources.MachuPicchuLogin;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.english);
            this.panel1.Controls.Add(this.espanol);
            this.panel1.Controls.Add(this.lblRegistrate);
            this.panel1.Controls.Add(this.passwordPanel);
            this.panel1.Controls.Add(this.usernamePanel);
            this.panel1.Controls.Add(this.FacebookLoginBtn);
            this.panel1.Controls.Add(this.LoginBtn);
            this.panel1.Name = "panel1";
            // 
            // english
            // 
            this.english.BackColor = System.Drawing.Color.Transparent;
            this.english.BackgroundImage = global::PresentationLayer.Properties.Resources.idioma_ingles_1;
            resources.ApplyResources(this.english, "english");
            this.english.Name = "english";
            this.english.TabStop = false;
            this.english.Click += new System.EventHandler(this.english_Click);
            // 
            // espanol
            // 
            this.espanol.BackColor = System.Drawing.Color.Transparent;
            this.espanol.BackgroundImage = global::PresentationLayer.Properties.Resources.idioma_español_1;
            resources.ApplyResources(this.espanol, "espanol");
            this.espanol.Name = "espanol";
            this.espanol.TabStop = false;
            this.espanol.Click += new System.EventHandler(this.espanol_Click);
            // 
            // lblRegistrate
            // 
            resources.ApplyResources(this.lblRegistrate, "lblRegistrate");
            this.lblRegistrate.LinkColor = System.Drawing.Color.LightGray;
            this.lblRegistrate.Name = "lblRegistrate";
            this.lblRegistrate.TabStop = true;
            this.lblRegistrate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegistrate_LinkClicked);
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.White;
            this.passwordPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passwordPanel.Controls.Add(this.hint_password);
            this.passwordPanel.Controls.Add(this.passwordTB);
            resources.ApplyResources(this.passwordPanel, "passwordPanel");
            this.passwordPanel.Name = "passwordPanel";
            // 
            // hint_password
            // 
            resources.ApplyResources(this.hint_password, "hint_password");
            this.hint_password.BackColor = System.Drawing.Color.Transparent;
            this.hint_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hint_password.ForeColor = System.Drawing.Color.Silver;
            this.hint_password.Name = "hint_password";
            this.hint_password.Click += new System.EventHandler(this.hint_password_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.passwordTB, "passwordTB");
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordTB_TextChanged);
            this.passwordTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTB_KeyDown);
            // 
            // usernamePanel
            // 
            this.usernamePanel.BackColor = System.Drawing.Color.White;
            this.usernamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usernamePanel.Controls.Add(this.hint_username);
            this.usernamePanel.Controls.Add(this.usernameTB);
            resources.ApplyResources(this.usernamePanel, "usernamePanel");
            this.usernamePanel.Name = "usernamePanel";
            // 
            // hint_username
            // 
            resources.ApplyResources(this.hint_username, "hint_username");
            this.hint_username.BackColor = System.Drawing.Color.Transparent;
            this.hint_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hint_username.ForeColor = System.Drawing.Color.Silver;
            this.hint_username.Name = "hint_username";
            this.hint_username.Click += new System.EventHandler(this.hint_username_Click);
            // 
            // usernameTB
            // 
            this.usernameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.usernameTB, "usernameTB");
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.TextChanged += new System.EventHandler(this.usernameTB_TextChanged);
            // 
            // FacebookLoginBtn
            // 
            this.FacebookLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.FacebookLoginBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.FacebookLoginBtn, "FacebookLoginBtn");
            this.FacebookLoginBtn.ForeColor = System.Drawing.Color.Transparent;
            this.FacebookLoginBtn.Name = "FacebookLoginBtn";
            this.FacebookLoginBtn.UseVisualStyleBackColor = false;
            this.FacebookLoginBtn.Click += new System.EventHandler(this.FacebookLoginBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.White;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.LoginBtn, "LoginBtn");
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 4500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.language_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.english)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espanol)).EndInit();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.usernamePanel.ResumeLayout(false);
            this.usernamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button FacebookLoginBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel usernamePanel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.LinkLabel lblRegistrate;
        private System.Windows.Forms.Label hint_username;
        private System.Windows.Forms.Label hint_password;
        private System.Windows.Forms.PictureBox language_icon;
        private System.Windows.Forms.PictureBox english;
        private System.Windows.Forms.PictureBox espanol;
    }
}