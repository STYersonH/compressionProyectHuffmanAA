using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Algorithm_Implementation;

namespace FileCompressionTool
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnEnviarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Seleccionar Archivo";
            open.Multiselect = true;
            open.DefaultExt = "bin";
            // brows only for the files that have .bin extension
            open.Filter = "Only Binary File (*.bin*)|*.bin*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                var archivos = open.FileNames;
                foreach (var item in archivos)
                {
                    dgvArchivos.Rows.Add(item);
                }
            }

            open.Dispose();

            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow fila in dgvArchivos.Rows)
            {
                string archivo = fila.Cells["cnArchivos"].Value.ToString();

                if (!string.IsNullOrWhiteSpace(archivo))
                {
                    string filePath = archivo;         // get the file path in filePath variable from open dialog box
                    string binPath = filePath;
                    string ExtractPath = filePath;

                    // remove the extension of file and add new extension _extracted.txt
                    int index = ExtractPath.IndexOf(".");
                    if (index > 0)
                    {
                        ExtractPath = ExtractPath.Substring(0, index);
                    }

                    if (archivo.Contains("txt"))
                    {
                        ExtractPath = ExtractPath + "_extracted.txt";       // concatination of string
                        Program.ExtractTextFile(binPath, ExtractPath);
                    }
                    else if (archivo.Contains("pdf"))
                    {
                        ExtractPath = ExtractPath + "_extracted.pdf";       // concatination of string
                        Program.ExtractPdfFile(binPath, ExtractPath);
                    }
                    else if (archivo.Contains("docx"))
                    {
                        ExtractPath = ExtractPath + "_extracted.docx";       // concatination of string
                        Program.ExtractDocxFile(binPath, ExtractPath);
                    }
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form5 menu = new Form5();
            menu.Show();

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
