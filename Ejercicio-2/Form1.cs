using Ejercicio_2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnVer.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled= false;
        }

        Servicio service = new Servicio();

        private void btnCrear_Click(object sender, EventArgs e)
        { 

            FormDatos vtnDatos = new FormDatos();

            if (vtnDatos.ShowDialog() == DialogResult.OK)
            {
                
                bool seCreo = service.AgregarPersona(Convert.ToInt32(vtnDatos.tbDni.Text),vtnDatos.tbNombre.Text);

                if (seCreo != false)
                {
                    MessageBox.Show("Se creo correctamente.");
                }
                else
                {
                    MessageBox.Show("No se creo la persona.");
                }
            }
          
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lbMostrar.Items.Clear();
            for (int i = 0; i < service.VerCantidadDePersonas(); i++)
            {
                lbMostrar.Items.Add(service.VerPersona(i).Describir().ToString());
                
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int idx = lbMostrar.SelectedIndex;

            if (idx != -1)
            {
                Persona persona = service.VerPersona(idx);
                MessageBox.Show($"DNI: {persona.Dni} - Nombre: {persona.Nombre}");
            }
        }

        private void lbMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVer.Enabled = lbMostrar.SelectedIndex != -1;
            btnModificar.Enabled = lbMostrar.SelectedIndex != -1;
            btnEliminar.Enabled = lbMostrar.SelectedIndex != -1;
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            FormDatos vtnDatos = new FormDatos();

            int pos = lbMostrar.SelectedIndex;

            if(pos != -1)
            {
                Persona persona = service.VerPersona(pos);
                vtnDatos.tbDni.Text = Convert.ToString(persona.Dni);
                vtnDatos.tbNombre.Text = persona.Nombre;

                if (vtnDatos.ShowDialog() == DialogResult.OK)
                {
                    string nvNombre = vtnDatos.tbNombre.Text;
                    persona.Nombre = nvNombre;
                }
                btnListar_Click(null, null);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idx = lbMostrar.SelectedIndex;
            if (idx != -1)
            {
                Persona pers = service.VerPersona(idx);
                service.EliminarPersona(pers);
                MessageBox.Show($"Se elimino la persona con el nombre : {pers.Nombre}");
            }

            btnListar_Click(null, null);
        }
    }
}
