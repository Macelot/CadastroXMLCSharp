using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace frmXML
{
    public partial class frmBanco : Form
    {
        public frmBanco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlTextWriter xtw;  //create instance for xmltextwriter.
            int tam = textBox1.TextLength;
            string caminho;
            string ultimaLetra;
            ultimaLetra = textBox1.Text[tam - 1].ToString();
            if (ultimaLetra.Equals("\\"))
            {
                caminho = textBox1.Text;
            }
            else
            {
                caminho = textBox1.Text + "\\";
            }
            

            string fileNameOriginal = "Clientes.mdf";
            string fileNameOriginal2 = "Clientes_log.LDF";
            string sourcePath = @".\";
            string fileName = textBox2.Text+".mdf";
            string fileName2 = textBox2.Text + "_log.LDF";
            string targetPath =  caminho;

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileNameOriginal);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            string sourceFile2 = System.IO.Path.Combine(sourcePath, fileNameOriginal2);
            string destFile2 = System.IO.Path.Combine(targetPath, fileName2);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
            System.IO.File.Copy(sourceFile2, destFile2, true);

            // To copy all the files in one directory to another directory.
            // Get the files in the source folder. (To recursively iterate through
            // all subfolders under the current directory, see
            // "How to: Iterate Through a Directory Tree.")
            // Note: Check for target path was performed previously
            //       in this code example.
            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);
                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    fileName2 = System.IO.Path.GetFileName(s);
                    destFile2 = System.IO.Path.Combine(targetPath, fileName2);

                    System.IO.File.Copy(s, destFile, true);
                    System.IO.File.Copy(s, destFile2, true);



                    //conecta
                }
            }
            else
            {
                MessageBox.Show("Source path does not exist!");
            }

            // Keep console window open in debug mode.
           
        }

        }
    }

