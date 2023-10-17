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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void BtnContaNumeros_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach(var c in rchtxtFrase.Text)
            {
                if (char.IsNumber(c))
                    contador += 1;
            }
            MessageBox.Show("nº de letras: " + contador);
        }

        private void BtnContaLetras_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (var i = 0; i < rchtxtFrase.Text.Length; i++)
            {
                if (char.IsLetter(rchtxtFrase.Text[i]))
                    contador += 1;
            }
            MessageBox.Show($"nº de caracteres: {contador}");
        }

        private void BtnPrimeiroBranco_Click(object sender, EventArgs e)
        {
            int posicao = 0;
            int contador = 0;
            while (contador < rchtxtFrase.Text.Length)
            {
                if (char.IsWhiteSpace(rchtxtFrase.Text[contador]))
                {
                    posicao = contador + 1;
                    break;
                }
                contador++;
            }
            MessageBox.Show($"A posição do 1º espaço em branco é: {posicao}"); 
        }
    }
}
