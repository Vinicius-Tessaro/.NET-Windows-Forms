using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Troca_WinForms
{
    public partial class Form2 : Form
    {
        Thread Formulario1;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Formulario1 = new Thread(newform1);
            Formulario1.TrySetApartmentState(ApartmentState.STA);
            Formulario1.Start();
        }

        private void newform1()
        {
            Application.Run(new Form1());
        }
    }
}
