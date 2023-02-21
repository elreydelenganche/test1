using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);
            txtNombre.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNac.Value;
            //operador ternario
            string verga = cbVerga.Checked == true ? "Le gusta la verga" : "Es puto...";
            string tipo = "";
            if (rbMacho.Checked)
                tipo = "Macho";
            else if (rbHembra.Checked)
                tipo = "Hembra";
            else
                tipo = "X";

            string colorFav = comboBox1.SelectedItem.ToString();

            string numFav = numericUpDown1.Value.ToString();

            MessageBox.Show("Nombre: " + nombre + "fecha: " + fecha);

        }

       
    }
}
