namespace CapaVista_Seguridad
{
    partial class FrmMantenimiento2K
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
            this.navegador1 = new CapaVista_Navegador.Navegador();
            this.SeguridadBtnReporte = new System.Windows.Forms.Button();
            this.SeguridadBtnAyuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(2, 26);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1438, 111);
            this.navegador1.TabIndex = 0;
            // 
            // SeguridadBtnReporte
            // 
            this.SeguridadBtnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.SeguridadBtnReporte.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_reporte;
            this.SeguridadBtnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnReporte.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.SeguridadBtnReporte.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnReporte.Location = new System.Drawing.Point(1446, 128);
            this.SeguridadBtnReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadBtnReporte.Name = "SeguridadBtnReporte";
            this.SeguridadBtnReporte.Size = new System.Drawing.Size(87, 80);
            this.SeguridadBtnReporte.TabIndex = 26;
            this.SeguridadBtnReporte.UseVisualStyleBackColor = false;
            this.SeguridadBtnReporte.Click += new System.EventHandler(this.BtnReporte);
            // 
            // SeguridadBtnAyuda
            // 
            this.SeguridadBtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(201)))), ((int)(((byte)(161)))));
            this.SeguridadBtnAyuda.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_ayudaN;
            this.SeguridadBtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnAyuda.FlatAppearance.BorderSize = 0;
            this.SeguridadBtnAyuda.Location = new System.Drawing.Point(1438, 46);
            this.SeguridadBtnAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.SeguridadBtnAyuda.Name = "SeguridadBtnAyuda";
            this.SeguridadBtnAyuda.Size = new System.Drawing.Size(76, 76);
            this.SeguridadBtnAyuda.TabIndex = 27;
            this.SeguridadBtnAyuda.UseVisualStyleBackColor = false;
            this.SeguridadBtnAyuda.Click += new System.EventHandler(this.SeguridadBtnAyudaExamen_Click);
            // 
            // FrmMantenimiento2K
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 448);
            this.Controls.Add(this.SeguridadBtnAyuda);
            this.Controls.Add(this.SeguridadBtnReporte);
            this.Controls.Add(this.navegador1);
            this.Name = "FrmMantenimiento2K";
            this.Text = "2001 - FrmExamen";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador navegador1;
        private System.Windows.Forms.Button SeguridadBtnReporte;
        private System.Windows.Forms.Button SeguridadBtnAyuda;
    }
}