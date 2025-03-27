using System;
using System.ComponentModel.Design;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Refatoração - Melhorar o Código

            // Vetores
            string[] históricoOperações = new string[100];
            int contadorHistórico = 0;

            // Loop de Execução - Estrutura de Repetição
            while (true)
            {
                ExibirMenu();

                string opcao = ExibirMenu();

                if (OpcaoSairFoiEscolhida(opcao))
                    break;

                else if (OpcaoTabuadaFoiEscolhida(opcao))

                    ExibirTabuada();

                else if (OpcaoHistoricoFoiEscolhida(opcao))
                    ExibirHistoricoDeOperacoes (contadorHistórico, históricoOperações);
                
                else
                {
                    Decimal Resultado = RealizarCalculo(opcao, contadorHistórico, históricoOperações);
                    ExibirResultado(Resultado);
                }
            }
        }

        static string ExibirMenu() // Métodos / Funções
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("                                                Calculadora Tabajara 2025                                               ");
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");


            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Tabuada");
            Console.WriteLine("6 - Histórico de Operações");
            Console.WriteLine("S - Sair");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");


            Console.WriteLine("                                                    Escolha Uma Opção                                                   ");
            string opcao = Console.ReadLine();

            return opcao;
        }
        static bool OpcaoSairFoiEscolhida(string opcao)
        {
            bool opcaoSairFoiEscolhida = opcao == "S";

            return opcaoSairFoiEscolhida;
        }

        static bool OpcaoTabuadaFoiEscolhida(string opcao)
        {
            bool opcaoTabuadaFoiEscolhida = opcao == "5";
            return opcaoTabuadaFoiEscolhida;
        }
        static void ExibirTabuada()
        {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("                                                         Tabuada                                                        ");
                Console.WriteLine(" ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                Console.Write("Digite o Número Desejado: ");

                int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                // 1 - Variável de Controle
                // 2 - Condição
                // 3 - Mecânismo de Incrementação
                // 4 - $ = Interpolação de Variáveis na String
                for (int contador = 1; contador <= 10; contador++)
                {
                    int resultadoMultiplicação = numeroTabuada * contador;

                    string linhaDaTabuada = $"{numeroTabuada} x {contador} = {resultadoMultiplicação}";

                    Console.WriteLine("                                                        " + linhaDaTabuada);
                }
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("                                             !Pressione Enter Para Continuar!");

                Console.ReadLine();
               
            }

        static bool OpcaoHistoricoFoiEscolhida(string opcao)
        {

            return opcao == "6";

        }
        static void ExibirHistoricoDeOperacoes(int contadorHistórico, string[] históricoOperações)
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("                                                  Histórico de Operações                                                ");
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            for (int contador = 0; contador < contadorHistórico; contador++)
            {
                Console.WriteLine("                                                        " + históricoOperações[contador]);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("                                             !Pressione Enter Para Continuar!");
            Console.ReadLine();
        }

        static decimal RealizarCalculo(string opcao, int contadorHistórico, string[] históricoOperações)
        {
            Console.Write("Digite o Primeiro Número: ");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o Segundo Número: ");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            // Números Decimais (com Casa)
            // Float - float resultadoFloat = 0.0f; - 8 Casas
            // Double - double resultadoDouble = 0.0; - 16 Casas
            // Decimal - decimal resultadoDecimal = 0.0m; - 32 Casas
            decimal resultado = 0.0m;

            // Estrutura de Descição - SE
            if (opcao == "1")
            // Soma
            {
                resultado = primeiroNumero + segundoNumero;
                históricoOperações[contadorHistórico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
            }
            else if (opcao == "2")
            // Subtração
            {
                resultado = primeiroNumero - segundoNumero;
                históricoOperações[contadorHistórico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";

            }
            else if (opcao == "3")
            // Multiplicação
            {
                resultado = primeiroNumero * segundoNumero;
                históricoOperações[contadorHistórico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";

            }
            else if (opcao == "4")
            // Divisão
            {

                while (primeiroNumero == 0)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("                                            !Não é Possível Dividir Por Zero!                                           ");
                    Console.WriteLine(" ");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine(" > Por Favor Digite o Primeiro Número Novamente: ");

                    primeiroNumero = Convert.ToDecimal(Console.ReadLine());
                }

                while (segundoNumero == 0)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("                                            !Não é Possível Dividir Por Zero!                                           ");
                    Console.WriteLine(" ");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine(" > Por Favor Digite o Segundo Número Novamente: ");

                    segundoNumero = Convert.ToDecimal(Console.ReadLine());
                }

                resultado = primeiroNumero / segundoNumero;
                históricoOperações[contadorHistórico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
            }

            contadorHistórico++;

            return resultado;

        }
        static void ExibirResultado(decimal resultado)
        {
            Console.WriteLine("                                                     Resultado: " + resultado.ToString("F2")); // Floating Points 2
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("                                             !Pressione Enter Para Continuar!");

            Console.ReadLine();
        }
    }
}
