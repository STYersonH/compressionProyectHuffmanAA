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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("Destinatarios.txt"))
                {
                    MessageBox.Show("aun no existe");
                    string txt = "Destinatarios.txt";
                    StreamWriter guardarDatos = File.CreateText(txt);
                    foreach (DataGridViewRow fila in dgvDestinatarios.Rows)
                    {
                        var des = fila.Cells["cnDestino"].Value;

                        if (des == null) continue;

                        string destinatario = des.ToString();

                        if (!string.IsNullOrWhiteSpace(destinatario))
                        {
                            guardarDatos.Write(destinatario + "\n");
                        }
                    }
                    guardarDatos.Flush();
                    guardarDatos.Close();
                }
                else
                {
                    MessageBox.Show("ya existe");
                    string txt = "Destinatarios.txt";
                    StreamWriter guardarDatos = File.CreateText(txt);
                    foreach (DataGridViewRow fila in dgvDestinatarios.Rows)
                    {
                        var des = fila.Cells["cnDestino"].Value;

                        if (des == null) continue;

                        string destinatario = des.ToString();

                        if (!string.IsNullOrWhiteSpace(destinatario))
                        {
                            guardarDatos.Write(destinatario + "\n");
                        }
                    }
                    guardarDatos.Flush();
                    guardarDatos.Close();
                }

                MessageBox.Show("OK");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar");
            }

            Form5 iniciarHuffman = new Form5();
            iniciarHuffman.Show();

            this.Hide();
        }
    }
}
