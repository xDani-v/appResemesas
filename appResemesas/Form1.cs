using appResemesas.vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appResemesas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vCamiones c = new vCamiones();
            AbrirFormularioEnPestana(c, "Camiones");
        }

        public void AbrirFormularioEnPestana(Form formulario, string nombrePestana)
        {
            // Crear una nueva pestaña
            TabPage nuevaPestana = new TabPage(nombrePestana);

            // Añadir la pestaña al TabControl
            tabControl1.TabPages.Add(nuevaPestana);

            // Configurar el formulario para que se muestre dentro de la pestaña
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Añadir el formulario a la pestaña y mostrarlo
            nuevaPestana.Controls.Add(formulario);
            formulario.Show();
        }
    }
}
