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
using System.Xml.Linq;

namespace almacenamientoDeDatos
{

    public partial class frmXml : Form
    {
        public static List<Persona> personas = new List<Persona>();

        public frmXml()
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
            XElement xElem = new XElement("Personas",
                personas.Select(p => new XElement("Persona",
                    new XElement("ID", p.id),
                    new XElement("Nombre", p.name)
                ))
            );
            xElem.Save("..\\..\\utils\\personas.xml");
        }

        public void leerArchivo()
        {
            if (File.Exists("..\\..\\utils\\personas.xml"))
            {
                XElement xElem = XElement.Load("..\\..\\utils\\personas.xml");
                foreach (var personaElement in xElem.Elements("Persona"))
                {
                    int id = Convert.ToInt32(personaElement.Element("ID").Value);
                    string nombre = personaElement.Element("Nombre").Value;

                    bool idRepetido = false;

                    foreach (Persona p in personas)
                    {
                        if (p.id == id)
                        {
                            idRepetido = true;
                        }
                    }

                    if (idRepetido == false)
                    {
                        personas.Add(new Persona(id, nombre));
                    }
                }
            }
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

        private void imgAtras_Click(object sender, EventArgs e)
        {
            frmInicial inicio = new frmInicial();
            Hide();
            inicio.Show();
        }
    }

   


}
