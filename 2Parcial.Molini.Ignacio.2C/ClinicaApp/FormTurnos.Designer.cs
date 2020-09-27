namespace ClinicaApp
{
    partial class FormTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTurnos));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.listBoxPacientes = new System.Windows.Forms.ListBox();
            this.listBoxEspecialistas = new System.Windows.Forms.ListBox();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.lblEspecialistas = new System.Windows.Forms.Label();
            this.radioBtnManual = new System.Windows.Forms.RadioButton();
            this.radioBtnAutomatico = new System.Windows.Forms.RadioButton();
            this.lblAsignacion = new System.Windows.Forms.Label();
            this.lblManual = new System.Windows.Forms.Label();
            this.lblAutomatico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelTitulo.Font = new System.Drawing.Font("Book Antiqua", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Teal;
            this.labelTitulo.Location = new System.Drawing.Point(330, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(271, 51);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Clínica UTN";
            // 
            // listBoxPacientes
            // 
            this.listBoxPacientes.BackColor = System.Drawing.Color.MediumAquamarine;
            this.listBoxPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPacientes.FormattingEnabled = true;
            this.listBoxPacientes.ItemHeight = 16;
            this.listBoxPacientes.Location = new System.Drawing.Point(12, 80);
            this.listBoxPacientes.Name = "listBoxPacientes";
            this.listBoxPacientes.Size = new System.Drawing.Size(910, 180);
            this.listBoxPacientes.TabIndex = 3;
            // 
            // listBoxEspecialistas
            // 
            this.listBoxEspecialistas.BackColor = System.Drawing.Color.MediumAquamarine;
            this.listBoxEspecialistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEspecialistas.FormattingEnabled = true;
            this.listBoxEspecialistas.ItemHeight = 16;
            this.listBoxEspecialistas.Location = new System.Drawing.Point(12, 290);
            this.listBoxEspecialistas.Name = "listBoxEspecialistas";
            this.listBoxEspecialistas.Size = new System.Drawing.Size(910, 180);
            this.listBoxEspecialistas.TabIndex = 4;
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPacientes.Location = new System.Drawing.Point(8, 57);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(88, 20);
            this.lblPacientes.TabIndex = 5;
            this.lblPacientes.Text = "Pacientes";
            // 
            // lblEspecialistas
            // 
            this.lblEspecialistas.AutoSize = true;
            this.lblEspecialistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialistas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEspecialistas.Location = new System.Drawing.Point(8, 267);
            this.lblEspecialistas.Name = "lblEspecialistas";
            this.lblEspecialistas.Size = new System.Drawing.Size(115, 20);
            this.lblEspecialistas.TabIndex = 6;
            this.lblEspecialistas.Text = "Especialistas";
            // 
            // radioBtnManual
            // 
            this.radioBtnManual.AutoSize = true;
            this.radioBtnManual.Location = new System.Drawing.Point(230, 488);
            this.radioBtnManual.Name = "radioBtnManual";
            this.radioBtnManual.Size = new System.Drawing.Size(14, 13);
            this.radioBtnManual.TabIndex = 7;
            this.radioBtnManual.TabStop = true;
            this.radioBtnManual.UseVisualStyleBackColor = true;
            // 
            // radioBtnAutomatico
            // 
            this.radioBtnAutomatico.AutoSize = true;
            this.radioBtnAutomatico.Checked = true;
            this.radioBtnAutomatico.Location = new System.Drawing.Point(310, 488);
            this.radioBtnAutomatico.Name = "radioBtnAutomatico";
            this.radioBtnAutomatico.Size = new System.Drawing.Size(14, 13);
            this.radioBtnAutomatico.TabIndex = 8;
            this.radioBtnAutomatico.TabStop = true;
            this.radioBtnAutomatico.UseVisualStyleBackColor = true;
            this.radioBtnAutomatico.CheckedChanged += new System.EventHandler(this.radioBtnAutomatico_CheckedChanged);
            // 
            // lblAsignacion
            // 
            this.lblAsignacion.AutoSize = true;
            this.lblAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAsignacion.Location = new System.Drawing.Point(8, 483);
            this.lblAsignacion.Name = "lblAsignacion";
            this.lblAsignacion.Size = new System.Drawing.Size(178, 20);
            this.lblAsignacion.TabIndex = 9;
            this.lblAsignacion.Text = "Asignación de turnos";
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblManual.Location = new System.Drawing.Point(211, 504);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(48, 13);
            this.lblManual.TabIndex = 10;
            this.lblManual.Text = "Manual";
            // 
            // lblAutomatico
            // 
            this.lblAutomatico.AutoSize = true;
            this.lblAutomatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutomatico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAutomatico.Location = new System.Drawing.Point(284, 504);
            this.lblAutomatico.Name = "lblAutomatico";
            this.lblAutomatico.Size = new System.Drawing.Size(70, 13);
            this.lblAutomatico.TabIndex = 11;
            this.lblAutomatico.Text = "Automático";
            // 
            // FormTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(934, 531);
            this.Controls.Add(this.lblAutomatico);
            this.Controls.Add(this.lblManual);
            this.Controls.Add(this.lblAsignacion);
            this.Controls.Add(this.radioBtnAutomatico);
            this.Controls.Add(this.radioBtnManual);
            this.Controls.Add(this.lblEspecialistas);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.listBoxEspecialistas);
            this.Controls.Add(this.listBoxPacientes);
            this.Controls.Add(this.labelTitulo);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-7, -1);
            this.Name = "FormTurnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ClínicaUtn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTurnos_FormClosing);
            this.Load += new System.EventHandler(this.FormTurnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ListBox listBoxPacientes;
        private System.Windows.Forms.ListBox listBoxEspecialistas;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.Label lblEspecialistas;
        private System.Windows.Forms.RadioButton radioBtnManual;
        private System.Windows.Forms.RadioButton radioBtnAutomatico;
        private System.Windows.Forms.Label lblAsignacion;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.Label lblAutomatico;
    }
}