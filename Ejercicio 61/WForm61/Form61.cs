using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WForm61
{
    public partial class Form61 : Form
    {
        PersonaDAO basePersonas;

        public Form61()
        {
            InitializeComponent();
        }

        private void Form61_Load(object sender, EventArgs e)
        {
            basePersonas = new PersonaDAO();
            textBoxLeerId.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxNombre.Text != "" && textBoxApellido.Text != "")
                {
                    Persona auxPersona = new Persona(textBoxNombre.Text, textBoxApellido.Text);                    

                    if (basePersonas.Guardar(auxPersona))
                    {
                        textBoxNombre.Text = "";
                        textBoxApellido.Text = "";
                        MessageBox.Show("Se agrego la persona!");
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {          
            try
            {
                if(checkBoxLeer.Checked)
                {                   
                    if(int.TryParse(textBoxLeerId.Text, out int id))
                    {
                        Persona auxPersona = basePersonas.LeerPorID(id);
                        listBoxLectura.Items.Clear();
                        listBoxLectura.Items.Add(auxPersona);                     
                    }
                }
                else
                {
                    List<Persona> listaPersonas = new List<Persona>();
                    listaPersonas = basePersonas.Leer();
                    listBoxLectura.Items.Clear();

                    foreach (Persona item in listaPersonas)
                    {
                        listBoxLectura.Items.Add(item);
                    }
                }              
            }catch(ArgumentNullException)
            {
                MessageBox.Show("Debe ingresar un id existente!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona auxPersona = (Persona)listBoxLectura.SelectedItem;

                auxPersona.Nombre = textBoxNombre.Text; 
                auxPersona.Apellido = textBoxApellido.Text;

                if((auxPersona.Nombre != "" && auxPersona.Apellido != "") && basePersonas.Modificar(auxPersona))
                {
                    btnLeer_Click(sender, e);
                    MessageBox.Show("Se modifico la persona!");   
                }            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona auxPersona = (Persona)listBoxLectura.SelectedItem;

                if (!(auxPersona is null) && basePersonas.Borrar(auxPersona.Id))
                {
                    btnLeer_Click(sender, e);
                    MessageBox.Show("Se elimino la persona!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxLectura_SelectedIndexChanged(object sender, EventArgs e)
        {
            Persona auxPersona = (Persona)listBoxLectura.SelectedItem;

            textBoxNombre.Text = auxPersona.Nombre;
            textBoxApellido.Text = auxPersona.Apellido;
        }

        private void checkBoxLeer_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxLeer.Checked == true)
            {
                textBoxLeerId.Enabled = true;
            }
            else
            {
                textBoxLeerId.Enabled = false;
                textBoxLeerId.Text = "";
            }
        }
    }
}
