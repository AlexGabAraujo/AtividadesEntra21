using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Lista_08_Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            try
            {
                do
                {
                    Console.WriteLine("Digite o número da questão que deseja rodar(1-5, 0 - Sair):");
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            PotenciaEx1();
                            break;
                        case 2:
                            SomaEx2();
                            break;
                        case 3:
                            FibonacciEx3();
                            break;
                        case 4:
                            ContagemRegrassivaEx04();
                            break;
                        case 5:
                            MDCEx05();
                            break;
                        case 0:
                            Console.WriteLine("Encerrando...");
                            break;
                        default:
                            throw new Exception("Opção Inválida.");
                    }

                    Console.WriteLine("\n---Aperte 'Enter' para continuar---");
                    Console.ReadLine();
                    Console.Clear();
                } while (opcao != 0);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nOcorreu um erro:\n{ex}");
            }
        }

        //Exercício 1: Potência
        //Implemente uma função recursiva chamada Potencia que recebe dois parâmetros base e expoente e calcula a potência de base elevado a expoente.
        static void PotenciaEx1()
        {
            Console.WriteLine("\nDigite uma base e um expoente:");
            int baseC = int.Parse(Console.ReadLine());
            int expoente = int.Parse(Console.ReadLine());
            Console.WriteLine($"Potencia: {Potencia(baseC, expoente)}");
        }

        static int Potencia(int baseC, int expoente)
        {
            if (expoente == 1)
                return baseC * 1;
            return baseC * Potencia(baseC, expoente - 1);
        }

        //Exercício 2: Soma de Números Inteiros
        //Crie uma função recursiva chamada Soma que recebe um número inteiro positivo n como parâmetro e retorna a soma de todos os números inteiros de 1 até n.
        static void SomaEx2()
        {
            Console.WriteLine("\nDigite um número positivo e retornarei a soma de todos os numeros de 1 até o número digitado:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Soma de 1 até {numero}: {Soma(numero)}");
        }

        static int Soma(int numero)
        {
            if (numero == 1)
                return 1;
            return numero + Soma(numero - 1);
        }

        //Exercício 3: Fibonacci
        //Desenvolva uma função recursiva chamada Fibonacci que recebe um número inteiro n como parâmetro e retorna o n-ésimo termo da sequência de Fibonacci.
        static void FibonacciEx3()
        {
            Console.WriteLine("\nDigite qual número da sequência de Fibonacci você deseja saber: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Número {numero} da sequência de Fibonacci: {Fibonacci(numero - 1)}");
        }

        static int Fibonacci(int numero)
        {
            if (numero == 0 || numero == 1)
                return numero;

            return Fibonacci(numero - 1) + Fibonacci(numero - 2);
        }

        //Exercício 4: Contagem Regressiva
        //Escreva uma função recursiva chamada ContagemRegressiva que recebe um número inteiro positivo n como parâmetro e exibe uma contagem regressiva de n até 1.
        static void ContagemRegrassivaEx04()
        {
            Console.WriteLine("\nDigite um número e farei a contagem regressiva até o 1: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero < 1)
            {
                throw new Exception("O numero tem que ser maior que 0;");
            }
            else
            {
                Console.WriteLine("\nContagem Regressiva:");
                Console.WriteLine(ContagemRegrassiva(numero));
            }
        }

        static string ContagemRegrassiva(int numero)
        {
            if (numero == 1)
                return "1";

            Console.WriteLine(numero);
            return ContagemRegrassiva(numero - 1);
        }

        //Exercício 5: Máximo Divisor Comum (MDC)
        //Crie uma função recursiva chamada MDC que recebe dois números inteiros positivos a e b como parâmetros e retorna o máximo divisor comum entre eles.
        static void MDCEx05()
        {
            Console.WriteLine("\nDigite dois números e direi o maior divisor comum entre eles: ");
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nMaior divisor comum entre os números {numero1} e {numero2}: {MDC(numero1, numero2, numero1)}");
        }

        static int MDC(int numero1, int numero2, int i)
        {
            if (numero1 % i == 0 && numero2 % i == 0)
                return i;

            return MDC(numero1, numero2, i - 1);
        }

    }
}