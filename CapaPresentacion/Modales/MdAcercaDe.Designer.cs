
namespace CapaPresentacion.Modales
{
    partial class MdAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdAcercaDe));
            this.LblAviso = new System.Windows.Forms.Label();
            this.LblVersion = new System.Windows.Forms.Label();
            this.LblSistemaVentas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDerechosReservados = new System.Windows.Forms.Label();
            this.lblOpcionAcercaDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblAviso
            // 
            this.LblAviso.AutoSize = true;
            this.LblAviso.BackColor = System.Drawing.Color.White;
            this.LblAviso.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAviso.Location = new System.Drawing.Point(308, 274);
            this.LblAviso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAviso.Name = "LblAviso";
            this.LblAviso.Size = new System.Drawing.Size(568, 210);
            this.LblAviso.TabIndex = 263;
            this.LblAviso.Text = resources.GetString("LblAviso.Text");
            this.LblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblAviso.Click += new System.EventHandler(this.LblAviso_Click);
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.BackColor = System.Drawing.Color.White;
            this.LblVersion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersion.Location = new System.Drawing.Point(504, 255);
            this.LblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(155, 21);
            this.LblVersion.TabIndex = 262;
            this.LblVersion.Text = "Version 1.1.2021";
            // 
            // LblSistemaVentas
            // 
            this.LblSistemaVentas.AutoSize = true;
            this.LblSistemaVentas.BackColor = System.Drawing.Color.White;
            this.LblSistemaVentas.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSistemaVentas.Location = new System.Drawing.Point(416, 228);
            this.LblSistemaVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSistemaVentas.Name = "LblSistemaVentas";
            this.LblSistemaVentas.Size = new System.Drawing.Size(330, 29);
            this.LblSistemaVentas.TabIndex = 261;
            this.LblSistemaVentas.Text = "CALIFICADOR FINANCIERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 42);
            this.label2.TabIndex = 260;
            this.label2.Text = "Copyright 2021 (Documentación y Software) SOLUCIONES EMPRESARIALES,\r\nQuetzaltenan" +
    "go, Guatemala. Todos los Derechos Reservados. ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDerechosReservados
            // 
            this.lblDerechosReservados.AutoSize = true;
            this.lblDerechosReservados.BackColor = System.Drawing.Color.White;
            this.lblDerechosReservados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerechosReservados.Location = new System.Drawing.Point(479, 167);
            this.lblDerechosReservados.Name = "lblDerechosReservados";
            this.lblDerechosReservados.Size = new System.Drawing.Size(232, 18);
            this.lblDerechosReservados.TabIndex = 259;
            this.lblDerechosReservados.Text = "\"DERECHOS RESERVADOS\"";
            // 
            // lblOpcionAcercaDe
            // 
            this.lblOpcionAcercaDe.BackColor = System.Drawing.Color.White;
            this.lblOpcionAcercaDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOpcionAcercaDe.Location = new System.Drawing.Point(305, 130);
            this.lblOpcionAcercaDe.Name = "lblOpcionAcercaDe";
            this.lblOpcionAcercaDe.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lblOpcionAcercaDe.Size = new System.Drawing.Size(590, 384);
            this.lblOpcionAcercaDe.TabIndex = 258;
            // 
            // MdAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.LblAviso);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.LblSistemaVentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDerechosReservados);
            this.Controls.Add(this.lblOpcionAcercaDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MdAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MdAcercaDe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblAviso;
        internal System.Windows.Forms.Label LblVersion;
        internal System.Windows.Forms.Label LblSistemaVentas;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDerechosReservados;
        private System.Windows.Forms.Label lblOpcionAcercaDe;
    }
}