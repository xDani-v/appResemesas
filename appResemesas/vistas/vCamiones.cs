using appResemesas.formulario;
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

namespace appResemesas.vistas
{
    public partial class vCamiones : Form
    {
        camionLogica negocio = new camionLogica();

        public vCamiones()
        {
            InitializeComponent();
            cargar();
        }

        void cargar()
        {
            // Llamar a la función ListarClientes y asignar el resultado al DataGridView
            dataGridView1.DataSource = negocio.viewCamiones().ToList();
        }

 

        private void vCamiones_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fCamion formularioCrear = new fCamion();
            DialogResult result = formularioCrear.ShowDialog();

            // Si el formulario se cerró después de un 'Guardar exitoso', recarga los datos
            if (result == DialogResult.OK)
            {
                cargar();  // Suponiendo que 'Cargar()' es tu método para cargar datos en la tabla
            }
        }
    }
}
