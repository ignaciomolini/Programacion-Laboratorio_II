namespace ClinicaApp
{
    partial class FormPacienteProximo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPacienteProximo));
            this.lblProxPaciente = new System.Windows.Forms.Label();
            this.lblDatosProxPaciente = new System.Windows.Forms.Label();
            this.lblProxDoctor = new System.Windows.Forms.Label();
            this.lblDatosProxDoctor = new System.Windows.Forms.Label();
            this.picBoxCara2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCara2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProxPaciente
            // 
            this.lblProxPaciente.AutoSize = true;
            this.lblProxPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProxPaciente.Location = new System.Drawing.Point(10, 45);
            this.lblProxPaciente.Name = "lblProxPaciente";
            this.lblProxPaciente.Size = new System.Drawing.Size(208, 25);
            this.lblProxPaciente.TabIndex = 0;
            this.lblProxPaciente.Text = "Proximo paciente: ";
            // 
            // lblDatosProxPaciente
            // 
            this.lblDatosProxPaciente.AutoSize = true;
            this.lblDatosProxPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosProxPaciente.Location = new System.Drawing.Point(10, 80);
            this.lblDatosProxPaciente.Name = "lblDatosProxPaciente";
            this.lblDatosProxPaciente.Size = new System.Drawing.Size(21, 29);
            this.lblDatosProxPaciente.TabIndex = 1;
            this.lblDatosProxPaciente.Text = "-";
            // 
            // lblProxDoctor
            // 
            this.lblProxDoctor.AutoSize = true;
            this.lblProxDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProxDoctor.Location = new System.Drawing.Point(10, 203);
            this.lblProxDoctor.Name = "lblProxDoctor";
            this.lblProxDoctor.Size = new System.Drawing.Size(88, 25);
            this.lblProxDoctor.TabIndex = 3;
            this.lblProxDoctor.Text = "Doctor:";
            // 
            // lblDatosProxDoctor
            // 
            this.lblDatosProxDoctor.AutoSize = true;
            this.lblDatosProxDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosProxDoctor.Location = new System.Drawing.Point(106, 200);
            this.lblDatosProxDoctor.Name = "lblDatosProxDoctor";
            this.lblDatosProxDoctor.Size = new System.Drawing.Size(21, 29);
            this.lblDatosProxDoctor.TabIndex = 4;
            this.lblDatosProxDoctor.Text = "-";
            // 
            // picBoxCara2
            // 
            this.picBoxCara2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.picBoxCara2.ErrorImage = null;
            this.picBoxCara2.Location = new System.Drawing.Point(260, 40);
            this.picBoxCara2.Name = "picBoxCara2";
            this.picBoxCara2.Size = new System.Drawing.Size(140, 140);
            this.picBoxCara2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCara2.TabIndex = 5;
            this.picBoxCara2.TabStop = false;
            // 
            // FormPacienteProximo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(428, 251);
            this.Controls.Add(this.picBoxCara2);
            this.Controls.Add(this.lblDatosProxDoctor);
            this.Controls.Add(this.lblProxDoctor);
            this.Controls.Add(this.lblDatosProxPaciente);
            this.Controls.Add(this.lblProxPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(928, -1);
            this.MaximizeBox = false;
            this.Name = "FormPacienteProximo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Paciente Proximo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPacienteProximo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCara2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProxPaciente;
        private System.Windows.Forms.Label lblDatosProxPaciente;
        private System.Windows.Forms.Label lblProxDoctor;
        private System.Windows.Forms.Label lblDatosProxDoctor;
        private System.Windows.Forms.PictureBox picBoxCara2;
    }
}