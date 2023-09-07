using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Cargar__filtrar_y_exportar_datos_a_txt
{
    public partial class filtrado : Form
    {
        private List<string> datos = new List<string>();
        public filtrado()
        {
            InitializeComponent();

            //le doy las dos opciones en el primer ComboBox
            cmbFiltrado.Items.Add("Sexo");
            cmbFiltrado.Items.Add("Estado Civil");

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // obtengo el valor del filtro seleccionado
            string filtro = cmbFiltrado.SelectedItem?.ToString();

            // obtengo el valor del elemento seleccionado
            string valor = cmbElemento.SelectedItem?.ToString();

            // limpio la listviewdatos antes de mostrar los resultados 
            listViewDatos.Items.Clear();

            // creo la ruta de "Empleados.txt"
            string filePath = "Empleados.txt";

            // verifico que el archvio "Empleados.txt" exista
            if (File.Exists(filePath))
            {
                // Leer las líneas del archivo
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    // divido los datos por un ";"
                    string[] data = line.Split(';');

                    //verifico que esten los 7 datos cargados
                    if (data.Length == 7)
                    {
                        string sexo = data[6];
                        string estadoCivil = data[4];

                        // verifico que el usuario haya elegido una opcion entre el sexo y estado civil
                        if ((filtro == "Sexo" && sexo == valor) || (filtro == "Estado Civil" && estadoCivil == valor))
                        {
                            // agrego los datos a listviewdatos
                            ListViewItem item = new ListViewItem(data);
                            listViewDatos.Items.Add(item);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El archivo 'Empleados.txt' no existe.");
            }
        }

        private void filtrado_Load(object sender, EventArgs e)
        {

            cmbElemento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltrado.DropDownStyle = ComboBoxStyle.DropDownList;

            listViewDatos.View = View.Details;
            listViewDatos.Columns.Add("DNI",70);
            listViewDatos.Columns.Add("Nombre", 100);
            listViewDatos.Columns.Add("Apellido", 100);
            listViewDatos.Columns.Add("Fecha Nacimiento", 100);
            listViewDatos.Columns.Add("Estado civil", 100);
            listViewDatos.Columns.Add("Cant Hijos", 100);
            listViewDatos.Columns.Add("Sexo", 100);


            listViewDatos.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio1 = new Inicio();
            inicio1.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbFiltrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbElemento.Items.Clear();

            //configuro el segundo combobox segun lo elegido en el primer combobox

            if (cmbFiltrado.SelectedItem.ToString() == "Sexo")
            {
                cmbElemento.Items.Add("Hombre");
                cmbElemento.Items.Add("Mujer");
                cmbElemento.Items.Add("Otro");
            }
            else if (cmbFiltrado.SelectedItem.ToString() == "Estado Civil")
            {
                cmbElemento.Items.Add("Soltero/a");
                cmbElemento.Items.Add("Casado/a");
                cmbElemento.Items.Add("Viudo/a");
                cmbElemento.Items.Add("Separado/a");
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                //exporto los datos a un txt
                //le digo que sea un archivo .txt
                saveFileDialog.Filter = "Archivos de Texto (*.txt)|*.txt";
                saveFileDialog.Title = "Guardar archivo de texto";

                //le doy un nombre predeterminado
                saveFileDialog.FileName = "Empleados_exportados.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            foreach (ListViewItem item in listViewDatos.Items)
                            {
                                //extraigo los datos del listview para exportarlos al nuevo txt
                                string[] datos = new string[item.SubItems.Count];
                                for (int i = 0; i < item.SubItems.Count; i++)
                                {
                                    datos[i] = item.SubItems[i].Text;
                                }
                                string linea = string.Join(";", datos);
                                writer.WriteLine(linea);
                            }
                        }

                        MessageBox.Show("Datos exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al exportar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
