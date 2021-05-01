namespace PresentationLayer
{
    partial class Opciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opciones));
            this.panelAntiguo = new System.Windows.Forms.Panel();
            this.btnAntiguo = new System.Windows.Forms.Button();
            this.panelActual = new System.Windows.Forms.Panel();
            this.btnActual = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.panelAntiguo.SuspendLayout();
            this.panelActual.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAntiguo
            // 
            this.panelAntiguo.Controls.Add(this.btnAntiguo);
            this.panelAntiguo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAntiguo.Location = new System.Drawing.Point(0, 33);
            this.panelAntiguo.Margin = new System.Windows.Forms.Padding(0);
            this.panelAntiguo.Name = "panelAntiguo";
            this.panelAntiguo.Size = new System.Drawing.Size(200, 406);
            this.panelAntiguo.TabIndex = 0;
            // 
            // btnAntiguo
            // 
            this.btnAntiguo.BackColor = System.Drawing.Color.Black;
            this.btnAntiguo.BackgroundImage = global::PresentationLayer.Properties.Resources.WhatsApp_Image_2021_05_01_at_3_07_46_AM;
            this.btnAntiguo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAntiguo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAntiguo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAntiguo.Location = new System.Drawing.Point(0, 0);
            this.btnAntiguo.Margin = new System.Windows.Forms.Padding(0);
            this.btnAntiguo.Name = "btnAntiguo";
            this.btnAntiguo.Size = new System.Drawing.Size(200, 406);
            this.btnAntiguo.TabIndex = 0;
            this.btnAntiguo.TabStop = false;
            this.btnAntiguo.UseVisualStyleBackColor = true;
            this.btnAntiguo.Click += new System.EventHandler(this.btnAntiguo_Click);
            // 
            // panelActual
            // 
            this.panelActual.Controls.Add(this.btnActual);
            this.panelActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActual.Location = new System.Drawing.Point(200, 33);
            this.panelActual.Margin = new System.Windows.Forms.Padding(0);
            this.panelActual.Name = "panelActual";
            this.panelActual.Size = new System.Drawing.Size(232, 406);
            this.panelActual.TabIndex = 1;
            // 
            // btnActual
            // 
            this.btnActual.BackgroundImage = global::PresentationLayer.Properties.Resources.WhatsApp_Image_2021_05_01_at_3_07_43_AM;
            this.btnActual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActual.Location = new System.Drawing.Point(0, 0);
            this.btnActual.Margin = new System.Windows.Forms.Padding(0);
            this.btnActual.Name = "btnActual";
            this.btnActual.Size = new System.Drawing.Size(232, 406);
            this.btnActual.TabIndex = 0;
            this.btnActual.TabStop = false;
            this.btnActual.UseVisualStyleBackColor = true;
            this.btnActual.Click += new System.EventHandler(this.btnActual_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.Salir);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(432, 33);
            this.topPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Opciones";
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(400, 5);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(25, 25);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 3;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(432, 439);
            this.Controls.Add(this.panelActual);
            this.Controls.Add(this.panelAntiguo);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opciones";
            this.panelAntiguo.ResumeLayout(false);
            this.panelActual.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAntiguo;
        private System.Windows.Forms.Panel panelActual;
        private System.Windows.Forms.Button btnAntiguo;
        private System.Windows.Forms.Button btnActual;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Salir;
    }
}