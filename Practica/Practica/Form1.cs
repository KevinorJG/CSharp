using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica.Clases;

namespace Practica
{
    public partial class Form1 : Form
    {
        int i = 0;
        List<Alumno> lista = new List<Alumno>();
        public Form1()
        {
            InitializeComponent();
            
        }
        public void Limpiar()
        {
            textBoxNombre.Clear();
            textBoxApellidos.Clear();
            textBoxCarnet.Clear();
            textBoxFacultad.Clear();
            textBoxFacultad.Clear();
            textBoxEdad.Clear();
            comboBoxCarrerras.SelectedItem = null;

        }
        public DialogResult Advertencia => MessageBox.Show
            ("¿Esta seguro de eliminar? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        public void Actualizar()
        {
            dataGridViewLista.DataSource = null;
            dataGridViewLista.DataSource = lista;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String name = textBoxNombre.Text,
                   last_Name = textBoxApellidos.Text,
                   carnet = textBoxCarnet.Text,
                   carrera = comboBoxCarrerras.SelectedItem.ToString(),
                   facultad = textBoxFacultad.Text;
            int age = int.Parse(textBoxEdad.Text);

            Alumno alumno = new Alumno(name, last_Name, age, carnet, carrera, facultad);
            lista.Add(alumno);
            dataGridViewLista.DataSource = null;
            dataGridViewLista.DataSource = lista;
            dataGridViewLista.ReadOnly = true;
            Limpiar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Advertencia == DialogResult.Yes)
            {
                MessageBox.Show("El indice es : " + i);
                if (i != -1)
                {
                    lista.RemoveAt(i);
                    Actualizar();
                }
            }
            else
            {
                MessageBox.Show("¡Operación cancelada!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridViewLista_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (i != -1)
            {
                MessageBox.Show("Carnet: "
                    + (string)dataGridViewLista.Rows[i].Cells[0].Value + "\nCarrera: "
                    + (string)dataGridViewLista.Rows[i].Cells[1].Value + "\nFacultad: "
                    + (string)dataGridViewLista.Rows[i].Cells[2].Value + "\nNombre: "
                    + (string)dataGridViewLista.Rows[i].Cells[3].Value + " "
                    + (string)dataGridViewLista.Rows[i].Cells[4].Value + "\nEdad: "
                    + (int)dataGridViewLista.Rows[i].Cells[5].Value, "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void itemBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Advertencia == DialogResult.Yes)
                {
                    
                    if (i != -1)
                    {
                        lista.RemoveAt(i);
                        Actualizar();
                    }
                }
                else
                {
                    MessageBox.Show("¡Operación cancelada!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        private void dataGridViewLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
           
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewLista.ReadOnly = false;

        }

        private void deshabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewLista.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
