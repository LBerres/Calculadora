using System;
using System.ComponentModel.Design;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // V9 - Histórico de Operações da Calculadora

            // Vetores
            string[] históricoOperações = new string[100];
            int contadorHistórico = 0;

            // Loop de Execução - Estrutura de Repetição
            while (true)
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

                if (opcao == "S")
                    break;
                else if (opcao == "s")
                    break;

                else if (opcao == "5")
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
                    continue;
                }

                else if (opcao == "6")
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
                    continue;
                }

                Console.Write("Digite o Primeiro Número: ");
                string strprimeiroNumero = Console.ReadLine();

                decimal primeiroNumero = Convert.ToDecimal(strprimeiroNumero);

                Console.Write("Digite o Segundo Número: ");
                string strsegundoNumero = Console.ReadLine();

                decimal segundoNumero = Convert.ToDecimal(strsegundoNumero);

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

                else
                    continue;

                contadorHistórico++;

                Console.WriteLine("                                                     Resultado: " + resultado.ToString("F2")); // Floating Points 2
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("                                             !Pressione Enter Para Continuar!");

                Console.ReadLine();
            }

            
        }
    }
}
