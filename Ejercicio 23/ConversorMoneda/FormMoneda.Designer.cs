namespace ConversorMoneda
{
    partial class FormMoneda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoneda));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.labelEuro = new System.Windows.Forms.Label();
            this.labelDolar = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.textBoxDolar = new System.Windows.Forms.TextBox();
            this.textBoxEuro = new System.Windows.Forms.TextBox();
            this.buttonDolar = new System.Windows.Forms.Button();
            this.buttonPeso = new System.Windows.Forms.Button();
            this.buttonCotizacion = new System.Windows.Forms.Button();
            this.labelCotizacion = new System.Windows.Forms.Label();
            this.labelEuroV = new System.Windows.Forms.Label();
            this.labelDolarV = new System.Windows.Forms.Label();
            this.labelPesoV = new System.Windows.Forms.Label();
            this.textBoxEuroEuro = new System.Windows.Forms.TextBox();
            this.textBoxPesoEuro = new System.Windows.Forms.TextBox();
            this.textBoxDolarDolar = new System.Windows.Forms.TextBox();
            this.textBoxEuroPeso = new System.Windows.Forms.TextBox();
            this.textBoxEuroDolar = new System.Windows.Forms.TextBox();
            this.textBoxPesoPeso = new System.Windows.Forms.TextBox();
            this.textBoxPesoDolar = new System.Windows.Forms.TextBox();
            this.textBoxDolarEuro = new System.Windows.Forms.TextBox();
            this.textBoxDolarPeso = new System.Windows.Forms.TextBox();
            this.textBoxCotPeso = new System.Windows.Forms.TextBox();
            this.textBoxCotDolar = new System.Windows.Forms.TextBox();
            this.textBoxCotEuro = new System.Windows.Forms.TextBox();
            this.buttonEuro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Hopstarter-Soft-Scraps-Lock-Lock.ico");
            this.imageList.Images.SetKeyName(1, "Hopstarter-Soft-Scraps-Lock-Unlock.ico");
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuro.Location = new System.Drawing.Point(39, 79);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(47, 20);
            this.labelEuro.TabIndex = 0;
            this.labelEuro.Text = "Euro";
            // 
            // labelDolar
            // 
            this.labelDolar.AutoSize = true;
            this.labelDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolar.Location = new System.Drawing.Point(39, 132);
            this.labelDolar.Name = "labelDolar";
            this.labelDolar.Size = new System.Drawing.Size(52, 20);
            this.labelDolar.TabIndex = 1;
            this.labelDolar.Text = "Dolar";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.Location = new System.Drawing.Point(39, 184);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(49, 20);
            this.labelPeso.TabIndex = 2;
            this.labelPeso.Text = "Peso";
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(98, 186);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(100, 20);
            this.textBoxPeso.TabIndex = 3;
            // 
            // textBoxDolar
            // 
            this.textBoxDolar.Location = new System.Drawing.Point(98, 134);
            this.textBoxDolar.Name = "textBoxDolar";
            this.textBoxDolar.Size = new System.Drawing.Size(100, 20);
            this.textBoxDolar.TabIndex = 4;
            // 
            // textBoxEuro
            // 
            this.textBoxEuro.Location = new System.Drawing.Point(98, 81);
            this.textBoxEuro.Name = "textBoxEuro";
            this.textBoxEuro.Size = new System.Drawing.Size(100, 20);
            this.textBoxEuro.TabIndex = 5;
            // 
            // buttonDolar
            // 
            this.buttonDolar.Location = new System.Drawing.Point(220, 132);
            this.buttonDolar.Name = "buttonDolar";
            this.buttonDolar.Size = new System.Drawing.Size(75, 23);
            this.buttonDolar.TabIndex = 7;
            this.buttonDolar.Text = "->";
            this.buttonDolar.UseVisualStyleBackColor = true;
            this.buttonDolar.Click += new System.EventHandler(this.buttonDolar_Click);
            // 
            // buttonPeso
            // 
            this.buttonPeso.Location = new System.Drawing.Point(220, 184);
            this.buttonPeso.Name = "buttonPeso";
            this.buttonPeso.Size = new System.Drawing.Size(75, 23);
            this.buttonPeso.TabIndex = 8;
            this.buttonPeso.Text = "->";
            this.buttonPeso.UseVisualStyleBackColor = true;
            this.buttonPeso.Click += new System.EventHandler(this.buttonPeso_Click);
            // 
            // buttonCotizacion
            // 
            this.buttonCotizacion.ImageKey = "Hopstarter-Soft-Scraps-Lock-Unlock.ico";
            this.buttonCotizacion.ImageList = this.imageList;
            this.buttonCotizacion.Location = new System.Drawing.Point(235, 15);
            this.buttonCotizacion.Name = "buttonCotizacion";
            this.buttonCotizacion.Size = new System.Drawing.Size(41, 32);
            this.buttonCotizacion.TabIndex = 9;
            this.buttonCotizacion.UseVisualStyleBackColor = true;
            this.buttonCotizacion.Click += new System.EventHandler(this.buttonCotizacion_Click);
            // 
            // labelCotizacion
            // 
            this.labelCotizacion.AutoSize = true;
            this.labelCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCotizacion.Location = new System.Drawing.Point(105, 20);
            this.labelCotizacion.Name = "labelCotizacion";
            this.labelCotizacion.Size = new System.Drawing.Size(93, 20);
            this.labelCotizacion.TabIndex = 10;
            this.labelCotizacion.Text = "Cotizacion";
            // 
            // labelEuroV
            // 
            this.labelEuroV.AutoSize = true;
            this.labelEuroV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuroV.Location = new System.Drawing.Point(367, 51);
            this.labelEuroV.Name = "labelEuroV";
            this.labelEuroV.Size = new System.Drawing.Size(47, 20);
            this.labelEuroV.TabIndex = 13;
            this.labelEuroV.Text = "Euro";
            // 
            // labelDolarV
            // 
            this.labelDolarV.AutoSize = true;
            this.labelDolarV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolarV.Location = new System.Drawing.Point(496, 51);
            this.labelDolarV.Name = "labelDolarV";
            this.labelDolarV.Size = new System.Drawing.Size(52, 20);
            this.labelDolarV.TabIndex = 14;
            this.labelDolarV.Text = "Dolar";
            // 
            // labelPesoV
            // 
            this.labelPesoV.AutoSize = true;
            this.labelPesoV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesoV.Location = new System.Drawing.Point(621, 51);
            this.labelPesoV.Name = "labelPesoV";
            this.labelPesoV.Size = new System.Drawing.Size(49, 20);
            this.labelPesoV.TabIndex = 15;
            this.labelPesoV.Text = "Peso";
            // 
            // textBoxEuroEuro
            // 
            this.textBoxEuroEuro.Location = new System.Drawing.Point(339, 81);
            this.textBoxEuroEuro.Name = "textBoxEuroEuro";
            this.textBoxEuroEuro.Size = new System.Drawing.Size(100, 20);
            this.textBoxEuroEuro.TabIndex = 16;
            // 
            // textBoxPesoEuro
            // 
            this.textBoxPesoEuro.Location = new System.Drawing.Point(339, 186);
            this.textBoxPesoEuro.Name = "textBoxPesoEuro";
            this.textBoxPesoEuro.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesoEuro.TabIndex = 17;
            // 
            // textBoxDolarDolar
            // 
            this.textBoxDolarDolar.Location = new System.Drawing.Point(469, 134);
            this.textBoxDolarDolar.Name = "textBoxDolarDolar";
            this.textBoxDolarDolar.Size = new System.Drawing.Size(100, 20);
            this.textBoxDolarDolar.TabIndex = 18;
            // 
            // textBoxEuroPeso
            // 
            this.textBoxEuroPeso.Location = new System.Drawing.Point(595, 81);
            this.textBoxEuroPeso.Name = "textBoxEuroPeso";
            this.textBoxEuroPeso.Size = new System.Drawing.Size(100, 20);
            this.textBoxEuroPeso.TabIndex = 19;
            // 
            // textBoxEuroDolar
            // 
            this.textBoxEuroDolar.Location = new System.Drawing.Point(469, 81);
            this.textBoxEuroDolar.Name = "textBoxEuroDolar";
            this.textBoxEuroDolar.Size = new System.Drawing.Size(100, 20);
            this.textBoxEuroDolar.TabIndex = 20;
            // 
            // textBoxPesoPeso
            // 
            this.textBoxPesoPeso.Location = new System.Drawing.Point(595, 186);
            this.textBoxPesoPeso.Name = "textBoxPesoPeso";
            this.textBoxPesoPeso.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesoPeso.TabIndex = 21;
            // 
            // textBoxPesoDolar
            // 
            this.textBoxPesoDolar.Location = new System.Drawing.Point(469, 186);
            this.textBoxPesoDolar.Name = "textBoxPesoDolar";
            this.textBoxPesoDolar.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesoDolar.TabIndex = 22;
            // 
            // textBoxDolarEuro
            // 
            this.textBoxDolarEuro.Location = new System.Drawing.Point(339, 134);
            this.textBoxDolarEuro.Name = "textBoxDolarEuro";
            this.textBoxDolarEuro.Size = new System.Drawing.Size(100, 20);
            this.textBoxDolarEuro.TabIndex = 23;
            // 
            // textBoxDolarPeso
            // 
            this.textBoxDolarPeso.Location = new System.Drawing.Point(595, 134);
            this.textBoxDolarPeso.Name = "textBoxDolarPeso";
            this.textBoxDolarPeso.Size = new System.Drawing.Size(100, 20);
            this.textBoxDolarPeso.TabIndex = 24;
            // 
            // textBoxCotPeso
            // 
            this.textBoxCotPeso.Location = new System.Drawing.Point(595, 22);
            this.textBoxCotPeso.Name = "textBoxCotPeso";
            this.textBoxCotPeso.Size = new System.Drawing.Size(100, 20);
            this.textBoxCotPeso.TabIndex = 25;
            this.textBoxCotPeso.Leave += new System.EventHandler(this.textBoxCotPeso_Leave);
            // 
            // textBoxCotDolar
            // 
            this.textBoxCotDolar.Location = new System.Drawing.Point(469, 22);
            this.textBoxCotDolar.Name = "textBoxCotDolar";
            this.textBoxCotDolar.Size = new System.Drawing.Size(100, 20);
            this.textBoxCotDolar.TabIndex = 26;
            this.textBoxCotDolar.Leave += new System.EventHandler(this.textBoxCotDolar_Leave);
            // 
            // textBoxCotEuro
            // 
            this.textBoxCotEuro.Location = new System.Drawing.Point(339, 22);
            this.textBoxCotEuro.Name = "textBoxCotEuro";
            this.textBoxCotEuro.Size = new System.Drawing.Size(100, 20);
            this.textBoxCotEuro.TabIndex = 27;
            this.textBoxCotEuro.Leave += new System.EventHandler(this.textBoxCotEuro_Leave);
            // 
            // buttonEuro
            // 
            this.buttonEuro.Location = new System.Drawing.Point(220, 79);
            this.buttonEuro.Name = "buttonEuro";
            this.buttonEuro.Size = new System.Drawing.Size(75, 23);
            this.buttonEuro.TabIndex = 28;
            this.buttonEuro.Text = "->";
            this.buttonEuro.UseVisualStyleBackColor = true;
            this.buttonEuro.Click += new System.EventHandler(this.buttonEuro_Click);
            // 
            // FormMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(726, 234);
            this.Controls.Add(this.buttonEuro);
            this.Controls.Add(this.textBoxCotEuro);
            this.Controls.Add(this.textBoxCotDolar);
            this.Controls.Add(this.textBoxCotPeso);
            this.Controls.Add(this.textBoxDolarPeso);
            this.Controls.Add(this.textBoxDolarEuro);
            this.Controls.Add(this.textBoxPesoDolar);
            this.Controls.Add(this.textBoxPesoPeso);
            this.Controls.Add(this.textBoxEuroDolar);
            this.Controls.Add(this.textBoxEuroPeso);
            this.Controls.Add(this.textBoxDolarDolar);
            this.Controls.Add(this.textBoxPesoEuro);
            this.Controls.Add(this.textBoxEuroEuro);
            this.Controls.Add(this.labelPesoV);
            this.Controls.Add(this.labelDolarV);
            this.Controls.Add(this.labelEuroV);
            this.Controls.Add(this.labelCotizacion);
            this.Controls.Add(this.buttonCotizacion);
            this.Controls.Add(this.buttonPeso);
            this.Controls.Add(this.buttonDolar);
            this.Controls.Add(this.textBoxEuro);
            this.Controls.Add(this.textBoxDolar);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.labelDolar);
            this.Controls.Add(this.labelEuro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMoneda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de monedas";
            this.Load += new System.EventHandler(this.FormMoneda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.Label labelDolar;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.TextBox textBoxDolar;
        private System.Windows.Forms.TextBox textBoxEuro;
        private System.Windows.Forms.Button buttonDolar;
        private System.Windows.Forms.Button buttonPeso;
        private System.Windows.Forms.Button buttonCotizacion;
        private System.Windows.Forms.Label labelCotizacion;
        private System.Windows.Forms.Label labelEuroV;
        private System.Windows.Forms.Label labelDolarV;
        private System.Windows.Forms.Label labelPesoV;
        private System.Windows.Forms.TextBox textBoxEuroEuro;
        private System.Windows.Forms.TextBox textBoxPesoEuro;
        private System.Windows.Forms.TextBox textBoxDolarDolar;
        private System.Windows.Forms.TextBox textBoxEuroPeso;
        private System.Windows.Forms.TextBox textBoxEuroDolar;
        private System.Windows.Forms.TextBox textBoxPesoPeso;
        private System.Windows.Forms.TextBox textBoxPesoDolar;
        private System.Windows.Forms.TextBox textBoxDolarEuro;
        private System.Windows.Forms.TextBox textBoxDolarPeso;
        private System.Windows.Forms.TextBox textBoxCotPeso;
        private System.Windows.Forms.TextBox textBoxCotDolar;
        private System.Windows.Forms.TextBox textBoxCotEuro;
        private System.Windows.Forms.Button buttonEuro;
    }
}