using System;
using Aposentadoria;

namespace Aposentadoria
{
    public static class Aposentadoria
    {
        public static void Iniciar()
        {
            Console.WriteLine("Bem-vindo ao nosso Sistema de Aposentadoria! Dupla Vinicios Ataide e Paulo Thiago");

            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("Para iniciar, escolha uma dessas opções:");
                Console.WriteLine("Para verificar se está qualificado para se aposentar, digite 1");
                Console.WriteLine("Ou então digite 0 para sair do programa");
                Console.Write("Opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        VerificarAposentadoria();
                        break;
                    case 0:
                        sair = true;
                        Console.WriteLine("Saindo do programa. Até logo!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }
            }
        }

        private static void VerificarAposentadoria()
        {
            Pessoa pessoa = new Pessoa();

            Console.Write("Ok, vamos lá! Informe sua idade por favor: ");
            pessoa.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Certo, agora me informe o número de anos de contribuição: ");
            pessoa.AnosContribuicao = Convert.ToInt32(Console.ReadLine());

            if (CalculadoraAposentadoria.QualificadoParaAposentadoria(pessoa))
            {
                Console.WriteLine("Parabéns! Você está qualificado para se aposentar. Te desejo uma ótima aposentadoria");
            }
            else
            {
                Console.WriteLine("Desculpe, você ainda não atende aos requisitos para aposentadoria. Porém, em breve você chega lá.");
            }
        }
    }
}
