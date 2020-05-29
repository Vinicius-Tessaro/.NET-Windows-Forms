using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ler_salvar_arquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Arquivos de texto(*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            saveFileDialog1.Title = "Salva um arquivo de texto";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                byte[] bytes = Encoding.ASCII.GetBytes(richTextBox1.Text);
                int Nbytes = Encoding.ASCII.GetCharCount(bytes);
                fs.Write(bytes,0,Nbytes);
                txtName1.Text = saveFileDialog1.FileName;
                fs.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var sr = new StreamReader(openFileDialog1.FileName);
                openFileDialog1.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
                openFileDialog1.Title = "Le um arquivo de Texto";
                string arqtxt = sr.ReadToEnd();
                sr.Close();
                richTextBox2.Text = arqtxt;
                txtName2.Text = openFileDialog1.FileName;
                sr.Close();
            }
        }
    }
}
