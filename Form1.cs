using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace almacenamientoDeDatos
{
    public partial class frmInicial : Form
    {
    
        /// <summary>
        ///  Juan Pablo Roldan Patiño
        ///  2023
        ///  Probando distintos metodos para guardar información tales como csv o archivos planos
        /// </summary>
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            frmTxt txt = new frmTxt("personas.txt");

            Hide();
            txt.Show();

        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            frmCsv csv = new frmCsv();

            Hide();
            csv.Show();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            frmXml xml = new frmXml();

            Hide();
            xml.Show();
        }

        private void btnRtf_Click(object sender, EventArgs e)
        {
            frmRtf rtf = new frmRtf();

            Hide();
            rtf.Show();
        }
    }
}
