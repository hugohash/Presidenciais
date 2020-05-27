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
    public partial class FormTotais : Form
    {
        public List<string> distritos = new List<string>();

        public FormTotais()
        {
            InitializeComponent();
        }

        private void FormTotais_Load(object sender, EventArgs e)
        {
            int TotalvotacaoMRS = 0;
            int TotalvotacaoSN = 0;
            int TotalvotacaoMM = 0;
            int TotalvotacaoVS = 0;
            int TotalvotacaoMB = 0;
            int TotalvotacaoPM = 0;
            int TotalvotacaoES = 0;
            int TotalvotacaoHN = 0;
            int TotalvotacaoJS = 0;
            int TotalvotacaoCF = 0;
            int TotalvotacaoBranco = 0;
            int TotalvotacaoNulos = 0;

            foreach (var item in ListaResultados)
            {
                
                TotalvotacaoMRS += item.votacaoMRS;
                TotalvotacaoSN += item.votacaoSN;
                TotalvotacaoMM += item.votacaoMM;
                TotalvotacaoVS += item.votacaoVS;
                TotalvotacaoMB += item.votacaoMB;
                TotalvotacaoPM += item.votacaoPM;
                TotalvotacaoES += item.votacaoES;
                TotalvotacaoHN += item.votacaoHN;
                TotalvotacaoJS += item.votacaoJS;
                TotalvotacaoCF += item.votacaoCF;
                TotalvotacaoBranco += item.votacaoBranco;
                TotalvotacaoNulos += item.votacaoNulos;
            }

            // sets the totals on the textboxes
            textBox1.Text = TotalvotacaoMRS.ToString();
            textBox2.Text = TotalvotacaoSN.ToString();
            textBox3.Text = TotalvotacaoMM.ToString();
            textBox4.Text = TotalvotacaoVS.ToString();
            textBox5.Text = TotalvotacaoMB.ToString();
            textBox6.Text = TotalvotacaoPM.ToString();
            textBox7.Text = TotalvotacaoES.ToString();
            textBox8.Text = TotalvotacaoHN.ToString();
            textBox9.Text = TotalvotacaoJS.ToString();
            textBox10.Text = TotalvotacaoCF.ToString();
            textBox11.Text = TotalvotacaoBranco.ToString();
            textBox12.Text = TotalvotacaoNulos.ToString();
        }

        
    }    
}
