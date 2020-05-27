using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presidenciais
{
    public class registo
    {
        public struct RegistoResultado
        {
            public string Distrito;
            public int votacaoMRS; // Marcelo Rebelo Sousa
            public int votacaoSN; // Sampaio Nova
            public int votacaoMM; // Marisa Matias
            public int votacaoVS; // Vitorio Silva
            public int votacaoMB; // Maria Belem
            public int votacaoPM; // Paulo Morais
            public int votacaoES; // Edgar Silva
            public int votacaoHN; // Henrique Neto
            public int votacaoJS; // Jorge Sequeira
            public int votacaoCF; // Candido Ferreira
            public int votacaoBranco; // Brancos
            public int votacaoNulos; // Nulos
        }

        public static List<RegistoResultado> ListaResultados = new List<RegistoResultado>();
        public static List<String> ListaRegioes = new List<String>();
    }

}
