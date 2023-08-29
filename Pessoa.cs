using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aposentadoria
{

    public class Pessoa
    {
        public int Idade { get; set; }
        public int AnosContribuicao { get; set; }
    }


   
        public static class CalculadoraAposentadoria
        {
            public static bool QualificadoParaAposentadoria(Pessoa pessoa)
            {
                if (pessoa.Idade >= 60 && pessoa.AnosContribuicao >= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
