using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pmetodos
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void BtnRemover1_Click(object sender, EventArgs e)
        {
            //txtPalavra1.Text = txtPalavra1.Text.ToLower();
            //(?) txtPalavra2.Text = txtPalavra2.Text.ToUpper();

            int posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            //a         ss             t
            //casa      assessoria     Fatec
            while (posicao >= 0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) + 
                    txtPalavra2.Text.Substring(posicao + 
                    txtPalavra1.Text.Length, 
                    txtPalavra2.Text.Length - posicao - 
                    txtPalavra1.Text.Length);
                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void BtnRemover2_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void BtnInverter_Click(object sender, EventArgs e)
        {
            //converte a string para vetor para poder inverter
            char[] vetor = txtPalavra1.Text.ToCharArray();
            Array.Reverse(vetor);
            //esvaziar o campo 2 + voltar o vetor para string
            txtPalavra2.Text = "";
            /*foreach (char c in vetor)
                txtPalavra2.Text += c;*/
            //ou
            txtPalavra2.Text = new string(vetor);

        }
    }
}
