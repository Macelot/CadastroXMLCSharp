using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace frmXML
{
    public partial class Form2 : Form
    {
        public Form2()
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
            if (ultimaLetra.Equals("\\")) {
                caminho = textBox1.Text;
            }else{
                caminho = textBox1.Text + "\\";
            }
            caminho = caminho + textBox2.Text;
            xtw = new XmlTextWriter(caminho + ".xml", Encoding.UTF8); //assign  file path and encoding 
            xtw.WriteStartDocument();//write start document
            xtw.WriteStartElement("CustomerDetails"); //create root element 
            xtw.WriteEndElement();//end root element 
            // xtw.Close(); //close file. It is automatically saved.
        }
    }
}
