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
    public partial class frmClienteCadastro : Form
    {
        public frmClienteCadastro()
        {
            InitializeComponent();
        }

        string msgErro;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xd = new XmlDocument();                        //object creation for XmlDocument class 
                FileStream lfile = new FileStream(textBox4.Text+"file.xml", FileMode.Open);//open an xml file using file stream
                xd.Load(lfile);                                            //load opened file in xml document
                XmlElement cl = xd.CreateElement("Customer");              //create an xml element
                cl.SetAttribute("Name", textBox1.Text);                            //set attribute for that element
                XmlElement na = xd.CreateElement("Idade");               //create an xml element
                XmlText natext = xd.CreateTextNode(textBox2.Text);           //create an xml element
                XmlElement email = xd.CreateElement("Email");               //create an xml element
                XmlText emailtext = xd.CreateTextNode(textBox3.Text);           //create an xml element

                email.AppendChild(emailtext);                                    //append address text to address node
                na.AppendChild(natext);                                    //append address text to address node
                cl.AppendChild(email);                                        //append address node to root element
                cl.AppendChild(na);                                        //append address node to root element
                xd.DocumentElement.AppendChild(cl);                        //append root element to xml document
                lfile.Close();                                             //close the file stream
                xd.Save(@"c:\file.xml");                                         //save the xmldocument content to the file
                msgErro = "nao"; // alimentamos a a variavel msgErro com o valor nao           
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                msgErro = "sim";
            }
            finally {
                if (msgErro == "nao") { //tanto faz posso dizer msgErro ==nao ou msgErro!=sim
                    MessageBox.Show("Cliente Cadastrado com sucesso");
                }
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox4.Text = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void frmClienteCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
