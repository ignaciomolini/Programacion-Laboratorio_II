using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioEj56
{
    public partial class Notepad : Form
    {
        private string path = null; // variable donde guardo el nombre del archivo

        public Notepad()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\Nacho\source\repos\Ejercicio 56"; //ruta de inicio, desp puedo elegir la que quiera
            openFileDialog.Filter = "txt files (*.txt)|*.txt"; //tipo de archivo que puedo abrir

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    using (StreamReader sr = new StreamReader(path, UTF8Encoding.Default)) // con el using no hace falta cerrarlo
                    {
                        richTextBox.Text = sr.ReadToEnd();
                    }              
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();  
            saveFileDialog.InitialDirectory = @"C:\Users\Nacho\source\repos\Ejercicio 56";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog.FileName;
                    using (StreamWriter sw = new StreamWriter(path, false, UTF8Encoding.Default))
                    {
                        sw.WriteLine(richTextBox.Text);
                    }        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }      
        }

        private void guardarCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(path, false, UTF8Encoding.Default))
                    {
                        sw.WriteLine(richTextBox.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                this.guardarComoToolStripMenuItem_Click(sender, e);
            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            toolSSLabelCaracteres.Text = this.ContarSoloCaracteres() + " Caracteres";
            //toolSSLabelCaracteres.Text = richTextBox.TextLength.ToString() + " Caracteres"; 
            //la de arriba cuenta todo, saltos de linea y espacios
        }

        private int ContarSoloCaracteres() 
        {
            int cantidadCaracteres = 0;
            char espacio = ' ';
            char saltoDeLinea = '\n';

            foreach(char c in richTextBox.Text)
            {
                if(c != espacio && c != saltoDeLinea)
                {
                    cantidadCaracteres += 1;
                }
            }

            return cantidadCaracteres;
        }
    }
}
