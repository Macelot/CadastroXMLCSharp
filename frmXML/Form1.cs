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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteCadastro frm2;
            frm2 = new frmClienteCadastro();
            frm2.MdiParent = this;
            frm2.Show(); 
        }

        private void consutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteConsulta f2 = new frmClienteConsulta();
            f2.Show();
        }

        private void criarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2;
            frm2 = new Form2();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProdutoCadastro f3 = new frmProdutoCadastro();
            f3.Show();
        }

        private void criarArquivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XmlTextWriter xtw;  //create instance for xmltextwriter. 
            xtw = new XmlTextWriter(@"c:\produtos.xml", Encoding.UTF8); //assign  file path and encoding 
            xtw.WriteStartDocument();//write start document
            xtw.WriteStartElement("ProdutoInfo"); //create root element 
            xtw.WriteEndElement();//end root element 
            xtw.Close(); //close file. It is automatically saved.
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutoConsulta f4 = new frmProdutoConsulta();
            f4.Show();

        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista f5 = new lista();
            f5.Show();
        }

        private void criaMDFELDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanco varFrm;
            varFrm = new frmBanco();
            varFrm.MdiParent = this;
            varFrm.Show();
        }

    }
}

