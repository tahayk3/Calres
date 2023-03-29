
namespace CapaPresentacion.Modales
{
    partial class MdPrivacidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdPrivacidad));
            this.LblAviso = new System.Windows.Forms.Label();
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
            this.LblAviso.Location = new System.Drawing.Point(303, 264);
            this.LblAviso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAviso.Name = "LblAviso";
            this.LblAviso.Size = new System.Drawing.Size(584, 210);
            this.LblAviso.TabIndex = 269;
            this.LblAviso.Text = resources.GetString("LblAviso.Text");
            this.LblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 84);
            this.label2.TabIndex = 266;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDerechosReservados
            // 
            this.lblDerechosReservados.AutoSize = true;
            this.lblDerechosReservados.BackColor = System.Drawing.Color.White;
            this.lblDerechosReservados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerechosReservados.Location = new System.Drawing.Point(450, 134);
            this.lblDerechosReservados.Name = "lblDerechosReservados";
            this.lblDerechosReservados.Size = new System.Drawing.Size(310, 25);
            this.lblDerechosReservados.TabIndex = 265;
            this.lblDerechosReservados.Text = "\"CALIFICADOR FINANCIERO\"";
            // 
            // lblOpcionAcercaDe
            // 
            this.lblOpcionAcercaDe.BackColor = System.Drawing.Color.White;
            this.lblOpcionAcercaDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOpcionAcercaDe.Location = new System.Drawing.Point(290, 90);
            this.lblOpcionAcercaDe.Name = "lblOpcionAcercaDe";
            this.lblOpcionAcercaDe.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lblOpcionAcercaDe.Size = new System.Drawing.Size(620, 460);
            this.lblOpcionAcercaDe.TabIndex = 264;
            // 
            // MdPrivacidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.LblAviso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDerechosReservados);
            this.Controls.Add(this.lblOpcionAcercaDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MdPrivacidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MdPrivacidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblAviso;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDerechosReservados;
        private System.Windows.Forms.Label lblOpcionAcercaDe;
    }
}