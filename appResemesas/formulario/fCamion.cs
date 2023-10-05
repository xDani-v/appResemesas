using entidades;
using logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appResemesas.formulario
{
    public partial class fCamion : Form
    {
        public fCamion()
        {
            InitializeComponent();
        }

        camion crearObjeto()
        {
            decimal peso = decimal.Parse(textBox1.Text);
            string chofe = textBox2.Text;
            string estado = comboBox1.Text;


            camion nuevo = new camion(0, peso,chofe,estado);

            return nuevo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            camion nuevo = crearObjeto();

            // Llamar al método createautor de la capa de negocio
            if (new camionLogica().createCamion(nuevo))
            {
                MessageBox.Show("camion creado con éxito.");
                this.DialogResult = DialogResult.OK;  // Establece el resultado del diálogo como OK
                this.Close();  // Cierra el formulario
            }
            else
            {
                MessageBox.Show("Error al crear el autor.");
            }
        }
    }
}
