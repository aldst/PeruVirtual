using System;
using System.Drawing.Text;
using System.IO;
using System.Reflection;

namespace PresentationLayer
{
    partial class Main
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
            System.Windows.Forms.PictureBox pictureBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PanelTask = new System.Windows.Forms.Panel();
            this.CloseSession = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.Lbl_panelTop = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.Nazca = new System.Windows.Forms.PictureBox();
            this.Sacsayhuaman = new System.Windows.Forms.PictureBox();
            this.Caral = new System.Windows.Forms.PictureBox();
            this.MachuPicchu = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.Separacion = new System.Windows.Forms.Panel();
            this.PanelVideo = new System.Windows.Forms.Panel();
            this.Button_Explorar = new System.Windows.Forms.Button();
            this.ingles = new System.Windows.Forms.PictureBox();
            this.VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.espanol = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            this.PanelTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nazca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sacsayhuaman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachuPicchu)).BeginInit();
            this.PanelVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espanol)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImage = global::PresentationLayer.Properties.Resources.idioma_icon_2;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PanelTask
            // 
            this.PanelTask.BackColor = System.Drawing.Color.Black;
            this.PanelTask.Controls.Add(pictureBox2);
            this.PanelTask.Controls.Add(this.CloseSession);
            this.PanelTask.Controls.Add(this.Restaurar);
            this.PanelTask.Controls.Add(this.Minimizar);
            this.PanelTask.Controls.Add(this.Maximizar);
            this.PanelTask.Controls.Add(this.Salir);
            this.PanelTask.Controls.Add(this.Lbl_panelTop);
            this.PanelTask.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.PanelTask, "PanelTask");
            this.PanelTask.ForeColor = System.Drawing.Color.Transparent;
            this.PanelTask.Name = "PanelTask";
            this.PanelTask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskPanel_MouseDown);
            // 
            // CloseSession
            // 
            resources.ApplyResources(this.CloseSession, "CloseSession");
            this.CloseSession.Name = "CloseSession";
            this.CloseSession.TabStop = false;
            this.CloseSession.Click += new System.EventHandler(this.CloseSession_Click);
            // 
            // Restaurar
            // 
            resources.ApplyResources(this.Restaurar, "Restaurar");
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.TabStop = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            resources.ApplyResources(this.Minimizar, "Minimizar");
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            resources.ApplyResources(this.Maximizar, "Maximizar");
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Salir
            // 
            resources.ApplyResources(this.Salir, "Salir");
            this.Salir.Name = "Salir";
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Lbl_panelTop
            // 
            resources.ApplyResources(this.Lbl_panelTop, "Lbl_panelTop");
            this.Lbl_panelTop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_panelTop.Name = "Lbl_panelTop";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.BackColor = System.Drawing.Color.Black;
            this.PanelOpciones.Controls.Add(this.Nazca);
            this.PanelOpciones.Controls.Add(this.Sacsayhuaman);
            this.PanelOpciones.Controls.Add(this.Caral);
            this.PanelOpciones.Controls.Add(this.MachuPicchu);
            resources.ApplyResources(this.PanelOpciones, "PanelOpciones");
            this.PanelOpciones.Name = "PanelOpciones";
            // 
            // Nazca
            // 
            this.Nazca.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Nazca, "Nazca");
            this.Nazca.Name = "Nazca";
            this.Nazca.TabStop = false;
            this.Nazca.Click += new System.EventHandler(this.Nazca_Click);
            this.Nazca.MouseEnter += new System.EventHandler(this.Nazca_MouseEnter);
            this.Nazca.MouseLeave += new System.EventHandler(this.Nazca_MouseLeave);
            // 
            // Sacsayhuaman
            // 
            this.Sacsayhuaman.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Sacsayhuaman, "Sacsayhuaman");
            this.Sacsayhuaman.Name = "Sacsayhuaman";
            this.Sacsayhuaman.TabStop = false;
            this.Sacsayhuaman.Click += new System.EventHandler(this.Sacsayhuaman_Click);
            this.Sacsayhuaman.MouseEnter += new System.EventHandler(this.Sacsayhuaman_MouseEnter);
            this.Sacsayhuaman.MouseLeave += new System.EventHandler(this.Sacsayhuaman_MouseLeave);
            // 
            // Caral
            // 
            this.Caral.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Caral, "Caral");
            this.Caral.Name = "Caral";
            this.Caral.TabStop = false;
            this.Caral.Click += new System.EventHandler(this.Caral_Click);
            this.Caral.MouseEnter += new System.EventHandler(this.Caral_MouseEnter);
            this.Caral.MouseLeave += new System.EventHandler(this.Caral_MouseLeave);
            // 
            // MachuPicchu
            // 
            this.MachuPicchu.BackColor = System.Drawing.Color.White;
            this.MachuPicchu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MachuPicchu.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.MachuPicchu, "MachuPicchu");
            this.MachuPicchu.Name = "MachuPicchu";
            this.MachuPicchu.TabStop = false;
            this.MachuPicchu.Click += new System.EventHandler(this.MachuPicchu_Click);
            this.MachuPicchu.MouseEnter += new System.EventHandler(this.MachuPicchu_MouseEnter);
            this.MachuPicchu.MouseLeave += new System.EventHandler(this.MachuPicchu_MouseLeave);
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LblTitulo, "LblTitulo");
            this.LblTitulo.Name = "LblTitulo";
            // 
            // Separacion
            // 
            this.Separacion.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.Separacion, "Separacion");
            this.Separacion.Name = "Separacion";
            // 
            // PanelVideo
            // 
            this.PanelVideo.Controls.Add(this.Button_Explorar);
            this.PanelVideo.Controls.Add(this.ingles);
            this.PanelVideo.Controls.Add(this.VideoPlayer);
            resources.ApplyResources(this.PanelVideo, "PanelVideo");
            this.PanelVideo.Name = "PanelVideo";
            // 
            // Button_Explorar
            // 
            resources.ApplyResources(this.Button_Explorar, "Button_Explorar");
            this.Button_Explorar.BackColor = System.Drawing.Color.Transparent;
            this.Button_Explorar.BackgroundImage = global::PresentationLayer.Properties.Resources.Azul_Moderno_Negro_y_Blanco;
            this.Button_Explorar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Explorar.FlatAppearance.BorderSize = 0;
            this.Button_Explorar.ForeColor = System.Drawing.Color.Black;
            this.Button_Explorar.Name = "Button_Explorar";
            this.Button_Explorar.Tag = "9";
            this.Button_Explorar.UseVisualStyleBackColor = false;
            // 
            // ingles
            // 
            this.ingles.BackColor = System.Drawing.Color.Transparent;
            this.ingles.BackgroundImage = global::PresentationLayer.Properties.Resources.idioma_ingles_1;
            resources.ApplyResources(this.ingles, "ingles");
            this.ingles.Name = "ingles";
            this.ingles.TabStop = false;
            // 
            // VideoPlayer
            // 
            resources.ApplyResources(this.VideoPlayer, "VideoPlayer");
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayer.OcxState")));
            this.VideoPlayer.MouseDownEvent += new AxWMPLib._WMPOCXEvents_MouseDownEventHandler(this.VideoPlayer_MouseDownEvent);
            // 
            // espanol
            // 
            this.espanol.BackColor = System.Drawing.Color.Transparent;
            this.espanol.BackgroundImage = global::PresentationLayer.Properties.Resources.idioma_español_1;
            resources.ApplyResources(this.espanol, "espanol");
            this.espanol.Name = "espanol";
            this.espanol.TabStop = false;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.espanol);
            this.Controls.Add(this.PanelVideo);
            this.Controls.Add(this.Separacion);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PanelOpciones);
            this.Controls.Add(this.PanelTask);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.PanelTask.ResumeLayout(false);
            this.PanelTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Nazca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sacsayhuaman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Caral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachuPicchu)).EndInit();
            this.PanelVideo.ResumeLayout(false);
            this.PanelVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espanol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTask;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label Lbl_panelTop;
        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.PictureBox MachuPicchu;
        private System.Windows.Forms.PictureBox Nazca;
        private System.Windows.Forms.PictureBox Sacsayhuaman;
        private System.Windows.Forms.PictureBox Caral;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.Panel Separacion;
        private System.Windows.Forms.Panel PanelVideo;
        private System.Windows.Forms.Button Button_Explorar;
        private AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
        private System.Windows.Forms.PictureBox CloseSession;
        private System.Windows.Forms.PictureBox ingles;
        private System.Windows.Forms.PictureBox espanol;
    }
}