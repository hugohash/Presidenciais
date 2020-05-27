using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Presidenciais.registo;

namespace Presidenciais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormResultados novoForm = new FormResultados();
            novoForm.MdiParent = this.MdiParent;
            novoForm.Show();
        }

        private void estatisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVisualiza novoForm = new FormVisualiza();
            novoForm.MdiParent = this.MdiParent;
            novoForm.ShowDialog();
        }

       
        private void totaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTotais novoForm = new FormTotais();
            novoForm.MdiParent = this.MdiParent;
            novoForm.Show();
        }

        
    }
}
