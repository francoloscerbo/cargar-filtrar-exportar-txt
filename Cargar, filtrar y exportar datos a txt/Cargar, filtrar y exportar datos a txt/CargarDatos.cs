using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cargar__filtrar_y_exportar_datos_a_txt
{
    public partial class CargarDatos : Form
    {
        List<string[]> empleados = new List<string[]>();
        public CargarDatos()
        {
            InitializeComponent();
        }

        private void CargarDatos_Load(object sender, EventArgs e)
        {
            cmbCivil.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbCivil.Items.Add("Soltero/a");
            cmbCivil.Items.Add("Casado/a");
            cmbCivil.Items.Add("Divorciado/a");
            cmbCivil.Items.Add("Viudoo/a");

            boxDNI.MaxLength = 8;
            BoxNombre.MaxLength = 30;
            BoxApellido.MaxLength = 30;
            BoxHIjos.MaxLength = 9;
            dtpFechaNac.MaxDate = DateTime.Today;

            listViewDatos.View = View.Details;
            listViewDatos.Columns.Add("DNI", 70);
            listViewDatos.Columns.Add("Nombre", 60);
            listViewDatos.Columns.Add("Apellido", 60);
            listViewDatos.Columns.Add("Fecha Nacimiento", 70);
            listViewDatos.Columns.Add("Estado civil", 70);
            listViewDatos.Columns.Add("Cant Hijos", 70);
            listViewDatos.Columns.Add("Sexo", 60);

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            //valido que el dni tenga entre 0 y 8 digitos
            if (!int.TryParse(boxDNI.Text, out int dni) || dni <= 0 || boxDNI.Text.Length >= 9)
            {
                MessageBox.Show("Ingrese un DNI valido (entre 0 y 7 digitos numericos)");
                return;
            }

            //validar que tenga entre 0 y 9 hijos
            if(!int.TryParse(BoxHIjos.Text, out int cantidadHijos) || BoxHIjos.Text.Length >= 9)
            {
                MessageBox.Show("Ingrese un nuemero de hijos validos (entre 0 y 9)");
                return;
            }

            //validar que el dni no se haya cargado antes
            foreach(ListViewItem item in listViewDatos.Items)
            {
                if (item.SubItems[0].Text == boxDNI.Text)
                {
                    MessageBox.Show("El DNI ya fue cargado canteriormente");
                    return;
                }
            }

            //a sexo lo paso como string para despues guardarlo 
            string sexo = "";

            if (radioButtonHombre.Checked)
            {
                sexo = "Hombre";
            }
            else if(radioButtonMujer.Checked)
            {
                sexo = "Mujer";
            }
            else
            {
                sexo = "Otro";
            }

            //cargo todos los datos en un txt por un ";" 
            string linea = $"{boxDNI.Text};{BoxNombre.Text};{BoxApellido.Text};{dtpFechaNac.Text};{cmbCivil.Text};{BoxHIjos.Text};{sexo}";

            try
            {
                //cargo todos los datos en el "Empleados.txt"
                using(FileStream fileStream =  new FileStream("Empleados.txt", FileMode.Append, FileAccess.Write))
                using(StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine(linea);
                }

                MessageBox.Show("Datos cargados con exito");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos {ex.Message}");
            }

            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivo de texto (*.txt|*.txt";

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePach = openFileDialog.FileName;

                    listViewDatos.Items.Clear();

                    try
                    {
                        string[] lineas = File.ReadAllLines(filePach);

                        foreach(string line in lineas)
                        {
                            string[] data = line.Split(';');

                            //me aseguro que esten completos los 7 campos
                            if(data.Length == 6)
                            {
                                ListViewItem item = new ListViewItem(data[0]); //dni
                                item.SubItems.Add(data[1]); //nombre
                                item.SubItems.Add(data[2]); //apellido
                                item.SubItems.Add(data[3]); //fecha de nacimiento
                                item.SubItems.Add(data[4]); //estado civil
                                item.SubItems.Add(data[5]); //cantidad de hijos
                                item.SubItems.Add(data[6]); //sexo

                                listViewDatos.Items.Add(item);
                            }
                        }

                    }catch(Exception ex)
                    {
                        MessageBox.Show($"Error al cargar los datos {ex.Message}");
                    }
                }
            }

            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listViewDatos.Items.Clear();

            // ruta del archivo "Empleados.txt"
            string filePath = "Empleados.txt";

            // verifico que el archivo "Empleados.txt" exista
            if (File.Exists(filePath))
            {
                // se leen las lineas del archivo
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    // divido los campos por un ";"
                    string[] data = line.Split(';');

                    if (data.Length == 7)
                    {
                        //formateo el datetime
                        DateTime fechaNacimiento;

                        if (DateTime.TryParse(data[3], out fechaNacimiento))
                        {
                            data[3] = fechaNacimiento.ToString("dd/MM/yyyy");
                        }

                        // agrego todos los datos a la listviewdatos
                        ListViewItem item = new ListViewItem(data);
                        listViewDatos.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("El archivo 'Empleados.txt' no existe.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vuelvo al inicio
            Inicio inicio1 = new Inicio();
            inicio1.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cierro programa
            Application.Exit();
        }
    }
}
