using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pmatrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExercicio1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";

            for(var i = 0; i < 20; i++)
            {
                auxiliar = Interaction.InputBox("Digite um nº","Entrada de Dados","3");
                if(!int.TryParse(auxiliar,out vetor[i]))
                {
                    MessageBox.Show("número inválido!");
                    i--; //se deu erro volte no mesmo
                }
            }
            auxiliar = "";
            for (var j = 19; j >= 0; j--)
            {
                auxiliar += vetor[j];
            }
            MessageBox.Show(auxiliar);
        }
    }
}
