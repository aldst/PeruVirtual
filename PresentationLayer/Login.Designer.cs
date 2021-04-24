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
            this.Lbl_topPanel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ingles = new System.Windows.Forms.Button();
            this.espanol = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.idioma_icon = new System.Windows.Forms.PictureBox();
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idioma_icon)).BeginInit();
            this.passwordPanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.Controls.Add(this.Lbl_topPanel);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.Maximizar);
            this.topPanel.Controls.Add(this.Minimizar);
            this.topPanel.Controls.Add(this.Restaurar);
            this.topPanel.Controls.Add(this.Salir);
            this.topPanel.Name = "topPanel";
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.ingles);
            this.panel1.Controls.Add(this.espanol);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.idioma_icon);
            this.panel1.Controls.Add(this.lblRegistrate);
            this.panel1.Controls.Add(this.passwordPanel);
            this.panel1.Controls.Add(this.usernamePanel);
            this.panel1.Controls.Add(this.FacebookLoginBtn);
            this.panel1.Controls.Add(this.LoginBtn);
            this.panel1.Name = "panel1";
            // 
            // ingles
            // 
            resources.ApplyResources(this.ingles, "ingles");
            this.ingles.BackColor = System.Drawing.Color.Transparent;
            this.ingles.BackgroundImage = global::PresentationLayer.Properties.Resources.idioma_ingles;
            this.ingles.Name = "ingles";
            this.ingles.UseVisualStyleBackColor = false;
            this.ingles.Click += new System.EventHandler(this.ingles_Click);
            // 
            // espanol
            // 
            resources.ApplyResources(this.espanol, "espanol");
            this.espanol.BackColor = System.Drawing.Color.Transparent;
            this.espanol.BackgroundImage = global::PresentationLayer.Properties.Resources.idioma_español;
            this.espanol.Name = "espanol";
            this.espanol.UseVisualStyleBackColor = false;
            this.espanol.Click += new System.EventHandler(this.espanol_Click);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // idioma_icon
            // 
            resources.ApplyResources(this.idioma_icon, "idioma_icon");
            this.idioma_icon.BackColor = System.Drawing.Color.Transparent;
            this.idioma_icon.BackgroundImage = global::PresentationLayer.Properties.Resources.idioma_icon;
            this.idioma_icon.Name = "idioma_icon";
            this.idioma_icon.TabStop = false;
            this.idioma_icon.Click += new System.EventHandler(this.pictureBox2_Click);
            this.idioma_icon.DoubleClick += new System.EventHandler(this.idioma_icon_DoubleClick);
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
            resources.ApplyResources(this.passwordPanel, "passwordPanel");
            this.passwordPanel.BackColor = System.Drawing.Color.White;
            this.passwordPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passwordPanel.Controls.Add(this.hint_password);
            this.passwordPanel.Controls.Add(this.passwordTB);
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
            resources.ApplyResources(this.passwordTB, "passwordTB");
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordTB_TextChanged);
            this.passwordTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTB_KeyDown);
            // 
            // usernamePanel
            // 
            resources.ApplyResources(this.usernamePanel, "usernamePanel");
            this.usernamePanel.BackColor = System.Drawing.Color.White;
            this.usernamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usernamePanel.Controls.Add(this.hint_username);
            this.usernamePanel.Controls.Add(this.usernameTB);
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
            resources.ApplyResources(this.usernameTB, "usernameTB");
            this.usernameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.TextChanged += new System.EventHandler(this.usernameTB_TextChanged);
            // 
            // FacebookLoginBtn
            // 
            resources.ApplyResources(this.FacebookLoginBtn, "FacebookLoginBtn");
            this.FacebookLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.FacebookLoginBtn.FlatAppearance.BorderSize = 0;
            this.FacebookLoginBtn.ForeColor = System.Drawing.Color.Transparent;
            this.FacebookLoginBtn.Name = "FacebookLoginBtn";
            this.FacebookLoginBtn.UseVisualStyleBackColor = false;
            this.FacebookLoginBtn.Click += new System.EventHandler(this.FacebookLoginBtn_Click);
            // 
            // LoginBtn
            // 
            resources.ApplyResources(this.LoginBtn, "LoginBtn");
            this.LoginBtn.BackColor = System.Drawing.Color.White;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 4500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idioma_icon)).EndInit();
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
        private System.Windows.Forms.PictureBox idioma_icon;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button espanol;
        private System.Windows.Forms.Button ingles;
        private System.Windows.Forms.ImageList imageList1;
    }
}