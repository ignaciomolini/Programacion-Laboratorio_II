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
using IO;

namespace FormularioEj56
{
    public partial class Notepad : Form
    {
        private string path = null; // variable donde guardo el nombre del archivo
        private PuntoTxt puntoTxt = new PuntoTxt();
        private PuntoDat puntoDat = new PuntoDat();

        public Notepad()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\Nacho\source\repos\Ejercicio 58"; //ruta de inicio, desp puedo elegir la que quiera
            openFileDialog.Filter = "all files (*.*)|*.*|txt files (*.txt)|*.txt|archivos de datos (*.dat)|*.dat"; //tipo de archivo que puedo abrir

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;    
                    if (Path.GetExtension(path) == ".txt")
                    {
                        richTextBox.Text = puntoTxt.Leer(path);
                    }
                    else if(Path.GetExtension(path) == ".dat")
                    {
                        puntoDat = puntoDat.Leer(path);
                        richTextBox.Text = puntoDat.Contenido;
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
            saveFileDialog.InitialDirectory = @"C:\Users\Nacho\source\repos\Ejercicio 58";
            saveFileDialog.Filter = "all files (*.*)|*.*|txt files (*.txt)|*.txt|archivos de datos (*.dat)|*.dat|All files (*.*)|*.*";

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog.FileName;
                    if(Path.GetExtension(path) == ".txt")
                    {
                        puntoTxt.GuardarComo(path, richTextBox.Text);
                    }
                    else if(Path.GetExtension(path) == ".dat")
                    {
                        puntoDat.Contenido = richTextBox.Text;
                        puntoDat.GuardarComo(path, puntoDat);      
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
                    if (Path.GetExtension(path) == ".txt")
                    {
                        puntoTxt.Guardar(path, richTextBox.Text);
                    }
                    else if (Path.GetExtension(path) == ".dat")
                    {
                        puntoDat.Contenido = richTextBox.Text;
                        puntoDat.Guardar(path, puntoDat);
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
