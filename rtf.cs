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
    public partial class frmRtf : Form
    {
        public List<Persona> personas = new List<Persona>();

        public frmRtf()
        {
            InitializeComponent();

            leerArchivo();
            llenarArchivo();
            dgvPersonas.DataSource = personas;

            dgvPersonas.Columns["id"].HeaderText = "ID";
            dgvPersonas.Columns["name"].HeaderText = "Nombre";

        }

        public void llenarArchivo()
        {
            RichTextBox rtb = new RichTextBox();

            foreach (Persona p in personas)
            {
                rtb.AppendText($"{p.id}|{p.name}\r\n");
            }

            using (FileStream fs = new FileStream("..\\..\\utils\\personas.rtf", FileMode.Create))
            {
                rtb.SaveFile(fs, RichTextBoxStreamType.RichText);
            }

            rtb.Dispose();
        }

        public void leerArchivo()
        {
            RichTextBox rtb = new RichTextBox();
            rtb.LoadFile("..\\..\\utils\\personas.rtf", RichTextBoxStreamType.RichText);

            string[] lineas = rtb.Text.Split('\n');

            foreach (string linea in lineas)
            {
                string[] vec = linea.Split('|');
                if (!string.IsNullOrWhiteSpace(linea))
                {
                    int id = Convert.ToInt32(vec[0]);
                    string name = vec[1];
                    bool idRepetido = false;

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

                }
            }

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

            if (txtEditarId.Text.Trim() == "" || txtEditar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el ID y el nuevo nombre");
                return;

            }

            if (int.TryParse(txtEditarId.Text, out id))
            {
                foreach (Persona p in personas)
                {
                    if (p.id == id)
                    {
                        p.name = txtEditar.Text;
                        llenarArchivo();
                        MessageBox.Show("Nombre actualizado :)");
                        idEncontrado = true;
                        break;
                    }
                }

                if (!idEncontrado)
                {
                    MessageBox.Show("ID no encontrado :(");
                }
                
            }else{
                MessageBox.Show("ID no válido :(");
            }

            txtEditarId.Clear();
            txtEditar.Clear();
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = personas;

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool idEncontrado = false;
            int id = 0;

            if (txtEliminar.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el ID a eliminar");
                return;
            }

            if (int.TryParse(txtEliminar.Text, out id))
            {
                foreach (Persona p in personas)
                {
                    if (p.id == id)
                    {
                        personas.Remove(p);
                        llenarArchivo();
                        MessageBox.Show("Persona eliminada :)");
                        idEncontrado = true;
                        break;
                    }
                }

                if (!idEncontrado)
                {
                    MessageBox.Show("ID no encontrado :(");
                }
            }
            else
            {
                MessageBox.Show("ID no válido :(");
            }

            txtEliminar.Clear();
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = personas;
        }
    }
}
