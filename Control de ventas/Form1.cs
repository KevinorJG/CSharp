using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_ventas
{
    public partial class Form1 : Form
    {
        double precio = 0;

        public Form1()
        {
            InitializeComponent();
           

        }

        private void comboBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProductos.SelectedIndex == -1) { MessageBox.Show("Seleccion una opcion"); }
            else if(comboBoxProductos.SelectedIndex == 0) { precio = 250.00;  }
            else if(comboBoxProductos.SelectedIndex == 1) { precio = 150.00;  }
            else if(comboBoxProductos.SelectedIndex == 2) { precio = 350.00;  }

            labelPrice.Text = precio.ToString("C");

        }

        private void labelActualFecha_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var DateAndTime = DateTime.Now;
            var Date = DateAndTime.Date.ToString("dd/MM/yyyy" + " hh:mm:ss tt");

            labelActualFecha.Text = Date;
            labelPrice.Text = 0.ToString("C");
            checkImg.Visible = false;

        }

        private void comboBoxPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            //Validad campos
            if(comboBoxProductos.SelectedIndex == -1){ MessageBox.Show("Debe de seleccionar un producto"); }
                else if (!Information.IsNumeric(textBoxCantidad.Text)) { MessageBox.Show("Debe de ingresar una cantidad"); }
                     else if (comboBoxPago.SelectedIndex == -1) { MessageBox.Show("Debe seleccionr un tipo de pago"); }

            else
            {
                double descuento = 0, recargo = 0, precioFinal;
                int cantidad;

                //captura de datos
                cantidad = int.Parse(textBoxCantidad.Text);

                //calculos
                double subtotal = precio * cantidad;
                if (comboBoxPago.SelectedIndex == 0) { descuento = 0.05 * subtotal; }
                else { recargo = 0.1 * subtotal; }

                precioFinal = subtotal - descuento + recargo;

                //Generador de boleta
                var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var Charsarr = new char[8];
                var random = new Random();

                for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }

                var resultString = new String(Charsarr);
                



                //
                ListViewItem fila = new ListViewItem(comboBoxProductos.SelectedItem.ToString());
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString("C"));
                fila.SubItems.Add(comboBoxPago.SelectedItem.ToString());
                fila.SubItems.Add(descuento.ToString("C"));
                fila.SubItems.Add(recargo.ToString("C"));
                fila.SubItems.Add(precioFinal.ToString("C"));
                fila.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy" + " hh:mm:ss tt"));
                fila.SubItems.Add(resultString);

                listView1.Items.Add(fila);

                if(listView1.SelectedIndices.Count != -1)
                {
                    checkImg.Visible = true;
                }
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            textBoxCantidad.Clear();
            comboBoxProductos.Text = "(Seleccione un producto)";
            comboBoxPago.Text = "(Seleccione tipo pago)";
            labelPrice.Text = 0.ToString("C");
            textBoxCantidad.Focus();
            checkImg.Visible = false;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Está seguro de salir", "Ventana", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(rs == DialogResult.Yes) { this.Close(); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
