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

namespace almacenamientoDeDatos
{
    public partial class frmCsv : Form
    {
        public static List<Persona> personas = new List<Persona>();

        public frmCsv()
        {
            InitializeComponent();

            //personas.Add(new Persona(0,"Nombre"));

            leerArchivo();
            llenarArchivo();

            dgvPersonas.DataSource = personas;

            dgvPersonas.Columns["id"].HeaderText = "ID";
            dgvPersonas.Columns["name"].HeaderText = "Nombre";
        }

        public void llenarArchivo()
        {

            StreamWriter sw = new StreamWriter("..\\..\\utils\\personas.csv");

            foreach (Persona p in personas)
            {
                sw.WriteLine($"{p.id},{p.name}");

            }
            sw.Close();
        }

        public void leerArchivo()
        {
            StreamReader sr = new StreamReader("..\\..\\utils\\personas.csv");
            string linea;
            bool idRepetido = false;
            linea = sr.ReadLine();

            while (linea != null)
            {
                string[] vec = linea.Split(',');
                try
                {

                    foreach (Persona p in personas)
                    {
                        if (p.id == Convert.ToInt32(vec[0]))
                        {
                            idRepetido = true;
                        }
                    }

                    if (idRepetido == false)
                    {
                        personas.Add(new Persona(Convert.ToInt32(vec[0]), vec[1]));
                    }



                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e);
                }

                linea = sr.ReadLine();
            }
            sr.Close();
        }

        private void imgAtras_Click(object sender, EventArgs e)
        {
            frmInicial inicio = new frmInicial();
            Hide();
            inicio.Show();
        }



        private void btnCrear_Click(object sender, EventArgs e)
        {
            Random n = new Random();
            int id = 0;
            bool idRepetido = false;


            if (txtAgregar.Text.Trim() != "")
            {
                do
                {
                    id = n.Next(1000000, 9999999);

                    if (personas.Count > 0)
                    {
                        foreach (Persona p in personas)
                        {
                            if (id == p.id)
                            {
                                idRepetido = true;
                                break;
                            }
                        }
                    }

                } while (idRepetido == true);


                personas.Add(new Persona(id, txtAgregar.Text));
                llenarArchivo();
                MessageBox.Show("Persona registrada :)");
                txtAgregar.Clear();
            }
            else
            {
                MessageBox.Show("Agregue el nombre pues :(");
            }

            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = personas;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool idEncontrado = false;
            int id = 0;

            if (txtId.Text.Trim() == "" || txtEditar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el ID y el nuevo nombre");
                return;
            }


            foreach (Persona p in personas)
            {

                if (int.TryParse(txtId.Text.Trim(), out id) && id == p.id)
                {

                    idEncontrado = true;
                    p.name = txtEditar.Text;
                    txtEditar.Clear();
                    txtId.Clear();

                    MessageBox.Show("El nombre ha sido modificado correctamente");
                }

            }


            if (idEncontrado == false)
            {
                MessageBox.Show("Ingrese un ID correcto");
            }

            llenarArchivo();

            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = personas;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool eliminado = false;
            int id = 0;


            foreach (Persona p in personas)
            {

                if (int.TryParse(txtEliminar.Text.Trim(), out id) && id == p.id)
                {

                    eliminado = true;
                    personas.Remove(p);
                    MessageBox.Show("La persona ha sido eliminada correctamente");
                    txtEliminar.Clear();
                    llenarArchivo();
                    break;
                }

            }

            if (eliminado == false)
            {
                MessageBox.Show("La persona no se pudo eliminar (posiblemente sea inmortal)");
            }

            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = personas;
        }
    }
}
