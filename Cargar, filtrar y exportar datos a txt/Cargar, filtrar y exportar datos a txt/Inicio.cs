using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cargar__filtrar_y_exportar_datos_a_txt
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnNuevoPerfil_Click(object sender, EventArgs e)
        {
            CargarDatos cargardatos = new CargarDatos();
            cargardatos.Show();
            this.Hide();
        }

        private void btnFiltrado_Click(object sender, EventArgs e)
        {
            filtrado filtrado = new filtrado();
            filtrado.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
