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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escolheu copiar");
        }

        private void ColarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escolheu colar");
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count()>0)
            {
                MessageBox.Show("Form já existe");
                //da erro se forms nao tem nada
                Application.OpenForms["frmExercicio2"].BringToFront();
                /*ou
                Application.OpenForms["frmExercicio2"].Activate();
                */

            }
            else
            {
                frmExercicio2 Frm2 = new frmExercicio2();
                Frm2.MdiParent = this;
                Frm2.WindowState = FormWindowState.Maximized;
                Frm2.Show();
            }
        }

        private void Exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                //da erro se forms nao tem nada
                Application.OpenForms["frmExercicio3"].BringToFront();
                /*ou
                Application.OpenForms["frmExercicio3"].Activate();
                */

            }
            else
            {
                frmExercicio3 Frm3 = new frmExercicio3();
                Frm3.MdiParent = this;
                Frm3.WindowState = FormWindowState.Maximized;
                Frm3.Show();
            }
        }

        private void Exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                //da erro se forms nao tem nada
                Application.OpenForms["frmExercicio4"].BringToFront();
                /*ou
                Application.OpenForms["frmExercicio4"].Activate();
                */

            }
            else
            {
                frmExercicio4 Frm4 = new frmExercicio4();
                Frm4.MdiParent = this;
                Frm4.WindowState = FormWindowState.Maximized;
                Frm4.Show();
            }
        }

        private void Exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio5>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                //da erro se forms nao tem nada
                Application.OpenForms["frmExercicio5"].BringToFront();
                /*ou
                Application.OpenForms["frmExercicio5"].Activate();
                */

            }
            else
            {
                frmExercicio5 Frm5 = new frmExercicio5();
                Frm5.MdiParent = this;
                Frm5.WindowState = FormWindowState.Maximized;
                Frm5.Show();
            }
        }
    }
}
