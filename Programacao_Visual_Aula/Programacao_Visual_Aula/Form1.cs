using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacao_Visual_Aula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double AV1A, AV1B, MedAV1, AV2, MedFinal;

            double.TryParse(AV1_A.Text, out AV1A);
            double.TryParse(AV1_B.Text, out AV1B);
            double.TryParse(AV2Text.Text, out AV2);

            MedAV1 = (AV1A + AV1B) / 2;
            MedFinal = (MedAV1 + AV2)/2;

            AV1_MED.Text = MedAV1.ToString();
            Media_Final.Text = MedFinal.ToString();

            if (MedFinal > 6.0)
                MessageBox.Show("---APROVADO---");
            else
                MessageBox.Show("---REPROVADO---");
        }

    }
}
