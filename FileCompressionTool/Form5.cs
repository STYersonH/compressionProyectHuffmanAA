using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FileCompressionTool
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        private void btnEnviarArchivo_Click(object sender, EventArgs e)
        {
            Form6 enviarArchivos = new Form6();
            enviarArchivos.Show();

            this.Hide();
        }

        private void btnObtenerArchivoOriginal_Click(object sender, EventArgs e)
        {
            Form7 decodificar = new Form7();
            decodificar.Show();

            this.Hide();
        }

    }
}
