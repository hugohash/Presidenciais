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
using static Presidenciais.Service;

namespace Presidenciais
{
    public partial class FormVisualiza : Form
    {
        public FormVisualiza()
        {
            InitializeComponent();
        }

        private void FormVisualiza_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        void fillGrid()
        {
            {
                dataGridView1.Rows.Clear();
                int linha = 0;

                foreach (var item in ListaResultados)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[linha].Cells[0].Value = item.Distrito;
                    dataGridView1.Rows[linha].Cells[1].Value = item.votacaoMRS;
                    dataGridView1.Rows[linha].Cells[2].Value = item.votacaoSN;
                    dataGridView1.Rows[linha].Cells[3].Value = item.votacaoMM;
                    dataGridView1.Rows[linha].Cells[4].Value = item.votacaoVS;
                    dataGridView1.Rows[linha].Cells[5].Value = item.votacaoMB;
                    dataGridView1.Rows[linha].Cells[6].Value = item.votacaoPM;
                    dataGridView1.Rows[linha].Cells[7].Value = item.votacaoES;
                    dataGridView1.Rows[linha].Cells[8].Value = item.votacaoHN;
                    dataGridView1.Rows[linha].Cells[9].Value = item.votacaoJS;
                    dataGridView1.Rows[linha].Cells[10].Value = item.votacaoCF;
                    dataGridView1.Rows[linha].Cells[11].Value = item.votacaoBranco;
                    dataGridView1.Rows[linha].Cells[12].Value = item.votacaoNulos;
                    linha++;


                }
            }
        }

        
    }
}
