using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Algorithm_Implementation;

namespace FileCompressionTool
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnEnviarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Seleccionar Archivo";
            open.Multiselect = true;
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
            StreamReader sr = new StreamReader("DatosUsuario.txt");
            string linea;

            linea = sr.ReadLine();
            string usuario = linea;

            linea = sr.ReadLine();
            string correoElect = linea;

            linea = sr.ReadLine();
            string contra = linea;

            sr.Close();

            Correo correo = new Correo
            {
                correo = correoElect,
                alias = "HUFFMAN CORREO",
                asunto = "Envio de archivos comprimidos",
                contrasenia = contra,
                puerto = 25,
                smtp = "smtp.gmail.com",
                cuerpo = "estos son los archivos comprimidos, usalos sabiamente",
                destinatarios = new List<string>(),
                adjuntos = new List<string>()
            };

            //agrega los archivos que se eligieron
            foreach (DataGridViewRow fila in dgvArchivos.Rows)
            {
                string archivo = fila.Cells["cnArchivos"].Value.ToString();

                if (!string.IsNullOrWhiteSpace(archivo))
                {
                    string filePath = archivo;
                    string binPath = filePath;                          // set the path for .bin file
                    string codingSchemePath = filePath;
                    string baseRuta = filePath;

                    // Remove the existing extension of input file and change it intp _codingScheme.txt
                    int index = codingSchemePath.IndexOf(".");
                    if (index > 0)
                    {
                        baseRuta = codingSchemePath.Substring(0, index);
                    }
                    string ocurrencia = baseRuta + "_Ocurrencia.txt";
                    string caracteres = baseRuta + "_Caracteres.bin";
                    codingSchemePath = baseRuta + "_codingScheme.txt";      // concate the string
                    

                    index = binPath.IndexOf(".");
                    if (index > 0)
                    {
                        binPath = binPath.Substring(0, index);
                    }

                    if (filePath.Contains("txt"))
                    {
                        binPath = binPath + "txt.bin";         // concate the string with .bin
                        ocurrencia = baseRuta + "txt_Ocurrencia.txt";
                        caracteres = baseRuta + "txt_Caracteres.bin";
                    }
                    else if (filePath.Contains("pdf"))
                    {
                        binPath = binPath + "pdf.bin";         // concate the string with .bin
                        ocurrencia = baseRuta + "pdf_Ocurrencia.txt";
                        caracteres = baseRuta + "pdf_Caracteres.bin";
                    }
                    else if (filePath.Contains("docx"))
                    {
                        binPath = binPath + "docx.bin";         // concate the string with .bin
                        ocurrencia = baseRuta + "docx_Ocurrencia.txt";
                        caracteres = baseRuta + "docx_Caracteres.bin";
                    }


                    // Get the extension of input file
                    string extension = Path.GetExtension(filePath);
                    if (extension == ".docx")
                    {
                        // call the function CompressDocxFile for compressing the .docx file using given .bn file
                        Program.CompressDocxFile(filePath, binPath, codingSchemePath, ocurrencia, caracteres);
                    }
                    else if (extension == ".txt")
                    {
                        // Call the function to compress the text file
                        Program.CompressTextFile(filePath, binPath, codingSchemePath, ocurrencia, caracteres);
                    }
                    else if (extension == ".pdf")
                    {
                        // Call the function to compress the pdf file
                        Program.CompressPdfFile(filePath, binPath, codingSchemePath, ocurrencia, caracteres);
                    }

                    correo.adjuntos.Add(binPath); //funcion clave
                    correo.adjuntos.Add(ocurrencia);
                    correo.adjuntos.Add(caracteres);

                }
            }

            StreamReader sR = new StreamReader("Destinatarios.txt");
            string line;

            while ((line = sR.ReadLine()) != null)
            {
                correo.destinatarios.Add(line);
            }

            sR.Close();

            if (Correo.Send(correo))
            {
                MessageBox.Show("Correo enviado");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form5 menu = new Form5();
            menu.Show();

            this.Hide();
        }
    }
}
