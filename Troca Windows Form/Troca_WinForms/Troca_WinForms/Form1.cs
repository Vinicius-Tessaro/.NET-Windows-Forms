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
    public partial class Form1 : Form
    {
        Thread Formulario2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Formulario2 = new Thread(newform2);
            Formulario2.TrySetApartmentState(ApartmentState.STA);
            Formulario2.Start();
        }

        private void newform2()
        {
            Application.Run(new Form2());
        }
    }
}
