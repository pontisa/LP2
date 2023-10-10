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
    }
}
