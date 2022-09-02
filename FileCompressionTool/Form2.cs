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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            if (!File.Exists("DatosUsuario.txt"))
            {
                Form3 registradorDatos = new Form3();
                registradorDatos.Show();
            }
            else
            {
                Form5 registradorDatos = new Form5();
                registradorDatos.Show();
            }

            this.Hide();
        }
    }
}
