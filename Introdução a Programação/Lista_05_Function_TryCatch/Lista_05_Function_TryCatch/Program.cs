using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Lista_05_Function_TryCatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            try
            {
                do
                {
                    Console.WriteLine("Escolha uma questão que deseja executar(entre 1 a 20) ou então digite 0 para sair: ");
                    opcao = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (opcao)
                    {
                        case 1:
                            SomaEx1();
                            break;
                        case 2:
                            FatorialEx2();
                            break;
                        case 3:
                            PrimoEx3();
                            break;
                        case 4:
                            MaiorEx4();
                            break;
                        case 5:
                            invertString();
                            break;
                        case 6:
                            MediaEx6();
                            break;
                        case 7:
                            PalindromoEx07();
                            break;
                        case 8:
                            ConverteTempEx6();
                            break;
                        case 9:
                            QuantidadeCaracterEx09();
                            break;
                        case 10:
                            MDCEx10();
                            break;
                        case 11:
                            ListaParEx11();
                            break;
                        case 12:
                            ElementoRepetidoEx12();
                            break;
                        case 13:
                            ConverterCammelEx13();
                            break;
                        case 14:
                            FibonacciEx14();
                            break;
                        case 15:
                            PositivoEx15();
                            break;
                        case 16:
                            CalculadoraEx16();
                            break;
                        case 17:
                            PrimoEx17();
                            break;
                        case 18:
                            FibonacciEx18();
                            break;
                        case 19:
                            ContarDigitoEx19();
                            break;
                        case 20:
                            MediaEx20();
                            break;
                        case 0:
                            Console.WriteLine("Finalizando...");
                            break;
                        default:
                            throw new Exception("Opção Inválida.");
                            break;
                    }
                    Console.WriteLine("\n---Aperte 'Enter' para continuar---");
                    Console.ReadLine();
                    Console.Clear();
                } while (opcao != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Um erro Foi Entrado: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }


        //Começar a utilizar try - catch para garantir o tratamento de exceções

        //1. Crie uma função que recebe dois números inteiros como parâmetros e retorna a sua soma.
        static void SomaEx1()
        {
            try
            {
                int n1 = AskNumber("Digite o Primeiro número: ");
                int n2 = AskNumber("Digite o Primeiro número: ");
                Console.WriteLine($"Soma dos números: {Soma(n1, n2)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }

        //2. Escreva uma função que calcule o fatorial de um número inteiro passado como argumento.
        static void FatorialEx2()
        {
            try
            {
                int n1 = AskNumber("Digite um número e farei seu fatorial: ");
                Console.WriteLine($"Fatorial: {Fatorial(n1)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static int Fatorial(int n)
        {
            int fatorial = 1;
            for (int i = 1; i <= n; i++)
            {
                fatorial *= i;
            }
            return fatorial;
        }

        //3. Desenvolva uma função que verifique se um número é primo ou não.
        static void PrimoEx3()
        {
            try
            {
                int n1 = AskNumber("Digite um número e direi se é primo: ");
                Console.WriteLine($"Primo: {Primo(n1)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static bool Primo(int n)
        {
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                if (n % i == 0)
                    total++;
            }

            if (total > 2)
                return false;
            else
                return true;
        }

        //4. Implemente uma função que receba uma lista de inteiros e retorne o maior valor presente na lista.
        static void MaiorEx4()
        {
            try
            {
                Console.WriteLine("Digite 3 números e direi qual é o maior: ");
                int n1 = AskNumber("Digite o primeiro número: ");
                int n2 = AskNumber("Digite o segundo número: ");
                int n3 = AskNumber("Digite o terceiro número: ");
                Console.WriteLine($"Maior número: {Maior(n1, n2, n3)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static int Maior(int n1, int n2, int n3)
        {
            int maior = n1;
            if (n2 > maior)
                maior = n2;
            if (n3 > maior)
                maior = n3;
            return maior;
        }

        //5. Crie uma função que inverta uma string passada como parâmetro (sem usar funções de inversão embutidas).
        static void invertString()
        {
            try
            {
                Console.WriteLine("Digite uma palavra: ");
                string palavra = Console.ReadLine();
                Console.WriteLine($"Frase Invertida: {InverteString(palavra)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static string InverteString(string palavra)
        {
            string newString = "";
            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                newString += palavra[i];
            }
            return newString;
        }

        //6. Escreva uma função que calcule a média de uma lista de números reais.
        static void MediaEx6()
        {
            try
            {
                Console.WriteLine("Digite 3 números e farei a média deles: ");
                int n1 = AskNumber("Digite o primeiro número: ");
                int n2 = AskNumber("Digite o segundo número: ");
                int n3 = AskNumber("Digite o terceiro número: ");
                Console.WriteLine($"Média: {Media(n1, n2, n3)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static double Media(int n1, int n2, int n3)
        {
            int media;
            return media = (n1 + n2 + n3) / 3;
        }

        //7. Desenvolva uma função que verifique se uma string é um palíndromo(ela lê o mesmo de trás para frente) ou não.
        static void PalindromoEx07()
        {
            try
            {
                Console.WriteLine("Digite uma palava para saber se é palíndroma: ");
                string palavra = Console.ReadLine();

                Console.WriteLine($"A palavra {palavra} é palindromo: {Palindromo(palavra)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static bool Palindromo(string palavra)
        {
            if (String.Equals(palavra.ToUpper(), InverteString(palavra).ToUpper()))
                return true;
            else
                return false;
        }
        //8. Implemente uma função que receba um valor em graus Celsius e retorne o equivalente em Fahrenheit.
        static void ConverteTempEx6()
        {
            try
            {
                Console.WriteLine("Digite uma temperatura em Graus Celcius: ");
                double temperatura = AskNumberDouble("Digite a temperatura: ");
                Console.WriteLine($"Temperatura Convertida: {ConverteTemp(temperatura)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static double ConverteTemp(double temperatura)
        {
            return temperatura * 1.8 + 32;
        }
        //9. Crie uma função que receba um array de strings e retorne a quantidade de strings que possuem mais de 5 caracteres.
        static void QuantidadeCaracterEx09()
        {
            try
            {
                int opcao;
                List<string> strings = new List<string>();
                do
                {
                    Console.WriteLine("Digite 1 para adicionar uma Nova String ou 0 para sair: ");
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao != 0)
                    {
                        Console.Write("Escreva sua frase: ");
                        strings.Add(Console.ReadLine());
                    }
                } while (opcao != 0);

                Console.WriteLine($"Quantidade de Strings com mais de 5 Dígitos: {QuantidadeCaracter(strings)}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static int QuantidadeCaracter(List<string> strings)
        {
            int quantidade = 0;

            for (int i = 0; i < strings.Count; i++)
            {
                if (strings[i].Length > 5)
                {
                    quantidade++;
                }
            }

            return quantidade;
        }

        //10. Escreva uma função que calcule o máximo divisor comum (MDC) entre dois números inteiros.
        static void MDCEx10()
        {
            try
            {
                Console.WriteLine("Digite dois números e direi o máximo divisor comum entre os dois:");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"O maior divisor comum é o número {MDC(num1, num2)}");
                MDC(num1, num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static int MDC(int num1, int num2)
        {
            int maior = 0;
            for (int i = 1; i <= num2; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    maior = i;
                }
            }
            return maior;
        }

        //11. Desenvolva uma função que receba uma lista de inteiros e retorne uma nova lista com os números pares.
        //static void ParList()
        static void ListaParEx11()
        {

            try
            {
                int num;
                List<int> numInt = new List<int>();

                Console.WriteLine("Digite os números que deseja adicionar (Para parar digite um número negativo): ");
                do
                {
                    num = int.Parse(Console.ReadLine());
                    if (num > 0)
                    {
                        numInt.Add(num);
                    }
                } while (num > 0);

                List<int> newList = ListaPar(numInt);
                Console.WriteLine("\nLista de Números Pares:\n");
                foreach (int n in newList)
                {
                    Console.WriteLine(n);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static List<int> ListaPar(List<int> listNum)
        {
            List<int> list = new List<int>();
            foreach (int num in listNum)
            {
                if (num % 2 == 0 && num >= 0)
                {
                    list.Add(num);
                }
            }
            return list;
        }

        //12. Implemente uma função que conte quantas vezes um determinado elemento aparece em uma lista.
        static void ElementoRepetidoEx12()
        {
            try
            {
                int opcao;
                List<string> elementoRepetido = new List<string>();
                do
                {
                    Console.WriteLine("Digite 1 para adicionar uma Nova String ou 0 para sair: ");
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao != 0)
                    {
                        Console.Write("Escreva sua frase: ");
                        elementoRepetido.Add(Console.ReadLine());
                    }
                } while (opcao != 0);

                Console.WriteLine($"\nDigite o elemento que desejas saber quantas vezes foi repetido na lista:");
                string elemento = Console.ReadLine();
                Console.WriteLine($"Quantidade de vezes que o elemento {elemento} foi repetido na lista: {ElementoRepetido(elementoRepetido, elemento)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static int ElementoRepetido(List<string> elementosRepetidos, string elemento)
        {
            int quantidade = 0;
            string elementoLower = elemento.ToLower();

            for (int i = 0; i < elementosRepetidos.Count; i++)
            {
                if (elementosRepetidos[i].ToLower() == elementoLower)
                {
                    quantidade++;
                }
            }

            return quantidade;
        }


        //13. Crie uma função que receba uma string e retorne outra string com todas as letras maiúsculas convertidas para minúsculas e vice-versa.
        static void ConverterCammelEx13()
        {
            try
            {
                Console.Write("Digite uma frase para inversão de Cammel: ");
                string frase = Console.ReadLine();
                Console.WriteLine($"Frase invertida: {ConverterCammel(frase)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static string ConverterCammel(string frase)
        {
            string novaFrase = "";

            foreach (char c in frase)
            {
                if (char.IsUpper(c))
                    novaFrase += char.ToLower(c);

                else
                    novaFrase += char.ToUpper(c);
            }

            return novaFrase;
        }


        //14. Escreva uma função que calcule o valor da série de Fibonacci para um dado número de termos.
        static void FibonacciEx14()
        {
            try
            {
                Console.WriteLine("Escreva quantos números da sequência de Fibonacci você deseja somar:");
                Console.WriteLine("Sequência:");
                int quantidade = int.Parse(Console.ReadLine());
                SomaFibonacci(quantidade);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static void SomaFibonacci(int quantidade)
        {
            int j = 0;
            int total = 0;
            for (int i = 1; i < quantidade; i++)
            {
                total += i + j;
                Console.WriteLine(j);
                Console.WriteLine(i);
                j = i + j;
                i = j + i;
            }
            Console.WriteLine($"Soma total de todos os números da sequência acima: {total}.");
        }

        //15. Desenvolva uma função que determine se um número é positivo, negativo ou zero.
        static void PositivoEx15()
        {
            try
            {
                Console.WriteLine("Digite um número e direi se é positivo, negativo ou igual a 0:");
                int num = int.Parse(Console.ReadLine());

                EhPositivo(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static string EhPositivo(int num)
        {
            if (num > 0)
                return $"O número {num} é Positivo.";
            else if (num < 0)
                return $"O número {num} é Negativo.";
            else
                return $"O número {num} é igual a 0.";
        }

        //16: Calculadora Simples - Crie uma função chamada Calculadora que recebe dois números e um operador (+, -, *, /) como parâmetros e retorna o resultado da operação.
        static void CalculadoraEx16()
        {
            try
            {
                Console.WriteLine("Digite dois números:");
                int num01 = int.Parse(Console.ReadLine());
                int num02 = int.Parse(Console.ReadLine());
                Console.WriteLine("""
                Agora Escolha uma opção de cálculo:
                1- + (Adição)
                2- - (Subtração)
                3- * (Multiplicação)
                4- / (Divisão)
                """);
                String operador = Console.ReadLine();
                Calculadora(num01, num02, operador);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static string Calculadora(int num1, int num2, string operacao)
        {
            switch (operacao)
            {
                case "+":
                    return $"{num1} + {num2} = {num1 + num2}";
                    break;
                case "-":
                    return $"{num1} - {num2} = {num1 + num2}";
                    break;
                case "*":
                    return $"{num1} * {num2} = {num1 + num2}";
                    break;
                case "/":
                    return $"{num1} / {num2} = {num1 + num2}";
                    break;
                default:
                    throw new Exception("Valor Inválido.");
            }
        }

        //17: Verificação de Número Primo - Escreva uma função chamada Primo que recebe um número inteiro como parâmetro e retorna true se o número for primo e false caso contrário.
        static void PrimoEx17()
        {
            try
            {
                int n1 = AskNumber("Digite um número e direi se é primo: ");
                Console.WriteLine($"Primo: {Primo(n1)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        //18: Sequência de Fibonacci - Implemente uma função chamada Fibonacci que recebe um número inteiro n como parâmetro e retorna uma lista contendo os primeiros n números da sequência de Fibonacci.
        static void FibonacciEx18()
        {
            try
            {
                Console.WriteLine("Escreva quantos números da sequência de Fibonacci você deseja analisar:");
                Console.WriteLine("Sequência:");
                int quantidade = int.Parse(Console.ReadLine());
                SequenciaFibonacci(quantidade);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static void SequenciaFibonacci(int quantidade)
        {
            int j = 0;
            int total = 0;
            for (int i = 1; i < quantidade; i++)
            {
                total += i + j;
                Console.WriteLine(j);
                Console.WriteLine(i);
                j = i + j;
                i = j + i;
            }
        }

        //19: Contagem de Dígitos - Crie uma função chamada ContarDigitos que recebe um número inteiro como parâmetro e retorna o número de dígitos no número.
        static void ContarDigitoEx19()
        {
            try
            {
                Console.WriteLine("Digite um número e direi quantos digitos ele tem: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"O número {num} possui {NumeroDigitos(num)} dígitos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static int NumeroDigitos(int num)
        {
            int i = 0;
            while (num > 0)
            {
                num /= 10;
                i++;
            }
            return i;
        }

        //20: Média de Números - Desenvolva uma função chamada CalcularMedia que recebe 3 números e retorna a média dos itens.
        static void MediaEx20()
        {
            try
            {
                Console.WriteLine("Digite 3 números e farei a média deles: ");
                int n1 = AskNumber("Digite o primeiro número: ");
                int n2 = AskNumber("Digite o segundo número: ");
                int n3 = AskNumber("Digite o terceiro número: ");
                Console.WriteLine($"Média: {Media(n1, n2, n3)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFoi encontrado um erro.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static int AskNumber(string pergunta)
        {
            Console.WriteLine(pergunta);
            return int.Parse(Console.ReadLine());
        }

        static double AskNumberDouble(string pergunta)
        {
            Console.WriteLine(pergunta);
            return double.Parse(Console.ReadLine());
        }
    }
}