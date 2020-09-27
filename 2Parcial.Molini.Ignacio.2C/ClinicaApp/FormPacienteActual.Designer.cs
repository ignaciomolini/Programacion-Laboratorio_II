namespace ClinicaApp
{
    partial class FormPacienteActual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPacienteActual));
            this.lblPacienteActual = new System.Windows.Forms.Label();
            this.lblDatosPacienteActual = new System.Windows.Forms.Label();
            this.picBoxCara2 = new System.Windows.Forms.PictureBox();
            this.lblDoctorActual = new System.Windows.Forms.Label();
            this.lblDatosDoctorActual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCara2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPacienteActual
            // 
            this.lblPacienteActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacienteActual.Location = new System.Drawing.Point(10, 45);
            this.lblPacienteActual.Name = "lblPacienteActual";
            this.lblPacienteActual.Size = new System.Drawing.Size(188, 64);
            this.lblPacienteActual.TabIndex = 0;
            this.lblPacienteActual.Text = "Paciente siendo atendido: ";
            // 
            // lblDatosPacienteActual
            // 
            this.lblDatosPacienteActual.AutoSize = true;
            this.lblDatosPacienteActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPacienteActual.Location = new System.Drawing.Point(10, 108);
            this.lblDatosPacienteActual.Name = "lblDatosPacienteActual";
            this.lblDatosPacienteActual.Size = new System.Drawing.Size(21, 29);
            this.lblDatosPacienteActual.TabIndex = 1;
            this.lblDatosPacienteActual.Text = "-";
            // 
            // picBoxCara2
            // 
            this.picBoxCara2.ErrorImage = null;
            this.picBoxCara2.Location = new System.Drawing.Point(260, 40);
            this.picBoxCara2.Name = "picBoxCara2";
            this.picBoxCara2.Size = new System.Drawing.Size(140, 140);
            this.picBoxCara2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCara2.TabIndex = 2;
            this.picBoxCara2.TabStop = false;
            // 
            // lblDoctorActual
            // 
            this.lblDoctorActual.AutoSize = true;
            this.lblDoctorActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorActual.Location = new System.Drawing.Point(10, 203);
            this.lblDoctorActual.Name = "lblDoctorActual";
            this.lblDoctorActual.Size = new System.Drawing.Size(95, 25);
            this.lblDoctorActual.TabIndex = 3;
            this.lblDoctorActual.Text = "Doctor: ";
            // 
            // lblDatosDoctorActual
            // 
            this.lblDatosDoctorActual.AutoSize = true;
            this.lblDatosDoctorActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosDoctorActual.Location = new System.Drawing.Point(103, 200);
            this.lblDatosDoctorActual.Name = "lblDatosDoctorActual";
            this.lblDatosDoctorActual.Size = new System.Drawing.Size(21, 29);
            this.lblDatosDoctorActual.TabIndex = 4;
            this.lblDatosDoctorActual.Text = "-";
            // 
            // FormPacienteActual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(428, 251);
            this.Controls.Add(this.lblDatosDoctorActual);
            this.Controls.Add(this.lblDoctorActual);
            this.Controls.Add(this.picBoxCara2);
            this.Controls.Add(this.lblDatosPacienteActual);
            this.Controls.Add(this.lblPacienteActual);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(928, 280);
            this.MaximizeBox = false;
            this.Name = "FormPacienteActual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Paciente Actual";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPacienteActual_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCara2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPacienteActual;
        private System.Windows.Forms.Label lblDatosPacienteActual;
        private System.Windows.Forms.PictureBox picBoxCara2;
        private System.Windows.Forms.Label lblDoctorActual;
        private System.Windows.Forms.Label lblDatosDoctorActual;
    }
}