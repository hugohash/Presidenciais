using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Presidenciais.registo;


namespace Presidenciais
{
    public partial class FormResultados : Form
    {
        public FormResultados()
        {
            InitializeComponent();
        }

        private void FormResultados_Load(object sender, EventArgs e)
        {
            loadRegioes();
            loadResultados();
        }

        /// <summary>
        /// opens regioes from a text file and fills the combobox
        /// </summary>
        private void loadRegioes()
        {
            string NomeFich = "Regioes.txt";
            if (File.Exists(NomeFich))
            {
                StreamReader FicheiroLer = new StreamReader(NomeFich);
                while (!FicheiroLer.EndOfStream)
                {
                    comboBoxRegioes.Items.Add(FicheiroLer.ReadLine());
                   

                }
                FicheiroLer.Close();
            }
            else
            {
                
                return;
            }
        }
        
        private void loadResultados()
        {
            string NomeFich = "Resultados.txt";
            if (File.Exists(NomeFich))
            {
                StreamReader FicheiroLer = new StreamReader(NomeFich);
                RegistoResultado resultado = new RegistoResultado();
                string linha;
                ListaResultados.Clear();
                while (!FicheiroLer.EndOfStream)
                {
                    linha = FicheiroLer.ReadLine();
                    
                    string[] campos = linha.Split(',');
                    resultado.Distrito = campos[0];
                    resultado.votacaoMRS = int.Parse(campos[1]);
                    resultado.votacaoSN = int.Parse(campos[2]);
                    resultado.votacaoMM = int.Parse(campos[3]);
                    resultado.votacaoVS = int.Parse(campos[4]);
                    resultado.votacaoMB = int.Parse(campos[5]);
                    resultado.votacaoPM = int.Parse(campos[6]);
                    resultado.votacaoES = int.Parse(campos[7]);
                    resultado.votacaoHN = int.Parse(campos[8]);
                    resultado.votacaoJS = int.Parse(campos[9]);
                    resultado.votacaoCF = int.Parse(campos[10]);
                    resultado.votacaoBranco = int.Parse(campos[11]);
                    resultado.votacaoNulos = int.Parse(campos[12]);
                    ListaResultados.Add(resultado);
                }
                FicheiroLer.Close();
            }
            else
            {
                MessageBox.Show("Resultados.txt nao existe", "Abrir Ficheiro", MessageBoxButtons.OK);
            }
        }

        private void comboBoxRegioes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRegiao = comboBoxRegioes.Text;
            foreach (var item in ListaResultados)
            {
                if (item.Distrito == selectedRegiao)
                {
                    textBox1.Text = item.votacaoMRS.ToString();
                    textBox2.Text = item.votacaoSN.ToString();
                    textBox3.Text = item.votacaoMM.ToString();
                    textBox4.Text = item.votacaoVS.ToString();
                    textBox5.Text = item.votacaoMB.ToString();
                    textBox6.Text = item.votacaoPM.ToString();
                    textBox7.Text = item.votacaoES.ToString();
                    textBox8.Text = item.votacaoHN.ToString();
                    textBox9.Text = item.votacaoJS.ToString();
                    textBox10.Text = item.votacaoCF.ToString();
                    textBox11.Text = item.votacaoBranco.ToString();
                    textBox12.Text = item.votacaoNulos.ToString();
                } else
                {
                    CamposValidos();
                }
            }
            
        }

        bool CamposValidos()
        {
            bool temErro = false;
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    if (((TextBox)x).Text == "")
                    {
                        temErro = true;
                        ((TextBox)x).BackColor = Color.IndianRed;
                        ((TextBox)x).ForeColor = Color.White;
                    }
                    else
                    {
                        ((TextBox)x).BackColor = Color.White;
                        ((TextBox)x).ForeColor = Color.Black;
                    }
                }
            }
            return temErro ? false : true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (CamposValidos())
            {
                var selectedRegiao = comboBoxRegioes.Text;
                int index = ListaResultados.FindIndex(result => result.Distrito == selectedRegiao);
                

                RegistoResultado resultToSave = new RegistoResultado();
                resultToSave.Distrito = selectedRegiao;
                resultToSave.votacaoMRS = int.Parse(textBox1.Text);
                resultToSave.votacaoSN = int.Parse(textBox2.Text);
                resultToSave.votacaoMM = int.Parse(textBox3.Text);
                resultToSave.votacaoVS = int.Parse(textBox4.Text);
                resultToSave.votacaoMB = int.Parse(textBox5.Text);
                resultToSave.votacaoPM = int.Parse(textBox6.Text);
                resultToSave.votacaoES = int.Parse(textBox7.Text);
                resultToSave.votacaoHN = int.Parse(textBox8.Text);
                resultToSave.votacaoJS = int.Parse(textBox9.Text);
                resultToSave.votacaoCF = int.Parse(textBox10.Text);
                resultToSave.votacaoBranco = int.Parse(textBox11.Text);
                resultToSave.votacaoNulos = int.Parse(textBox12.Text);

                if (index >= 0)
                {
                    ListaResultados[index] = resultToSave;
                }
                else
                {
                    ListaResultados.Add(resultToSave);
                }
               

            }
        }
                
       
        private void button2_Click_1(object sender, EventArgs e)
        {
            FormVisualiza novoForm = new FormVisualiza();
            novoForm.MdiParent = this.MdiParent;
            novoForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string NomeFich = "Resultados.txt";
            if (File.Exists(NomeFich))
            {
                StreamWriter writeFile = new StreamWriter(NomeFich);
                foreach (var resultado in ListaResultados)
                {
                    writeFile.WriteLine(
                        resultado.Distrito + "," +
                        resultado.votacaoMRS + "," +
                        resultado.votacaoSN + "," +
                        resultado.votacaoMM + "," +
                        resultado.votacaoVS + "," +
                        resultado.votacaoMB + "," +
                        resultado.votacaoPM + "," +
                        resultado.votacaoES + "," +
                        resultado.votacaoHN + "," +
                        resultado.votacaoJS + "," +
                        resultado.votacaoCF + "," +
                        resultado.votacaoBranco + "," +
                        resultado.votacaoNulos
                    );
                }

                writeFile.Close();
            }
            else
            {
                MessageBox.Show("Regioes.txt nao existe", "Abrir Ficheiro", MessageBoxButtons.OK);
            }

        }
        

    }
}
