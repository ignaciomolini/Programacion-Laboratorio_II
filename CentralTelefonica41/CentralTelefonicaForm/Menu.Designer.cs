namespace CentralTelefonicaForm
{
    partial class FrmMenu
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
            this.buttonGenerarLlamada = new System.Windows.Forms.Button();
            this.buttonFacturacionTotal = new System.Windows.Forms.Button();
            this.buttonFacturacionLocal = new System.Windows.Forms.Button();
            this.buttonFacturacionProvincial = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenerarLlamada
            // 
            this.buttonGenerarLlamada.Location = new System.Drawing.Point(12, 12);
            this.buttonGenerarLlamada.Name = "buttonGenerarLlamada";
            this.buttonGenerarLlamada.Size = new System.Drawing.Size(303, 66);
            this.buttonGenerarLlamada.TabIndex = 0;
            this.buttonGenerarLlamada.Text = "Generar Llamada";
            this.buttonGenerarLlamada.UseVisualStyleBackColor = true;
            this.buttonGenerarLlamada.Click += new System.EventHandler(this.buttonGenerarLlamada_Click);
            // 
            // buttonFacturacionTotal
            // 
            this.buttonFacturacionTotal.Location = new System.Drawing.Point(12, 84);
            this.buttonFacturacionTotal.Name = "buttonFacturacionTotal";
            this.buttonFacturacionTotal.Size = new System.Drawing.Size(303, 67);
            this.buttonFacturacionTotal.TabIndex = 1;
            this.buttonFacturacionTotal.Text = "Facturación Total";
            this.buttonFacturacionTotal.UseVisualStyleBackColor = true;
            this.buttonFacturacionTotal.Click += new System.EventHandler(this.buttonFacturacionTotal_Click);
            // 
            // buttonFacturacionLocal
            // 
            this.buttonFacturacionLocal.Location = new System.Drawing.Point(12, 157);
            this.buttonFacturacionLocal.Name = "buttonFacturacionLocal";
            this.buttonFacturacionLocal.Size = new System.Drawing.Size(303, 67);
            this.buttonFacturacionLocal.TabIndex = 2;
            this.buttonFacturacionLocal.Text = "Facturación Local";
            this.buttonFacturacionLocal.UseVisualStyleBackColor = true;
            this.buttonFacturacionLocal.Click += new System.EventHandler(this.buttonFacturacionLocal_Click);
            // 
            // buttonFacturacionProvincial
            // 
            this.buttonFacturacionProvincial.Location = new System.Drawing.Point(12, 230);
            this.buttonFacturacionProvincial.Name = "buttonFacturacionProvincial";
            this.buttonFacturacionProvincial.Size = new System.Drawing.Size(303, 67);
            this.buttonFacturacionProvincial.TabIndex = 3;
            this.buttonFacturacionProvincial.Text = "Facturación Provincial";
            this.buttonFacturacionProvincial.UseVisualStyleBackColor = true;
            this.buttonFacturacionProvincial.Click += new System.EventHandler(this.buttonFacturacionProvincial_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(12, 303);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(303, 66);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 382);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonFacturacionProvincial);
            this.Controls.Add(this.buttonFacturacionLocal);
            this.Controls.Add(this.buttonFacturacionTotal);
            this.Controls.Add(this.buttonGenerarLlamada);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefonica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerarLlamada;
        private System.Windows.Forms.Button buttonFacturacionTotal;
        private System.Windows.Forms.Button buttonFacturacionLocal;
        private System.Windows.Forms.Button buttonFacturacionProvincial;
        private System.Windows.Forms.Button buttonSalir;
    }
}