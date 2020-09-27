namespace CentralTelefonicaForm
{
    partial class FrmLlamadasBDD
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
            this.richTextBoxLlamadas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxLlamadas
            // 
            this.richTextBoxLlamadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLlamadas.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLlamadas.Name = "richTextBoxLlamadas";
            this.richTextBoxLlamadas.Size = new System.Drawing.Size(800, 450);
            this.richTextBoxLlamadas.TabIndex = 0;
            this.richTextBoxLlamadas.Text = "";
            // 
            // FrmLlamadasBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxLlamadas);
            this.Name = "FrmLlamadasBDD";
            this.Text = "LlamadasBaseDeDatos";
            this.Load += new System.EventHandler(this.LlamadasBaseDeDatos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxLlamadas;
    }
}