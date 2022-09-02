using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FileCompressionTool
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            try
            {
                if(!File.Exists("DatosUsuario.txt"))
                {
                    MessageBox.Show("aun no existe");
                    string txt = "DatosUsuario.txt";
                    StreamWriter guardarDatos = File.CreateText(txt);
                    guardarDatos.Write(tbNombre.Text + "\n");
                    guardarDatos.Write(tbCorreo.Text + "\n");
                    guardarDatos.Write(tbContra.Text + "\n");
                    guardarDatos.Flush();
                    guardarDatos.Close();
                }
                else
                {
                    MessageBox.Show("ya existe");
                    string txt = "DatosUsuario.txt";
                    StreamWriter guardarDatos = File.CreateText(txt);
                    guardarDatos.Write(tbNombre.Text + "\n");
                    guardarDatos.Write(tbCorreo.Text + "\n");
                    guardarDatos.Write(tbContra.Text + "\n");
                    guardarDatos.Flush();
                    guardarDatos.Close();
                }

                MessageBox.Show("OK");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar");
            }

            Form4 obtenerDestinatarios = new Form4();
            obtenerDestinatarios.Show();

            this.Hide();

        }
    }
}
