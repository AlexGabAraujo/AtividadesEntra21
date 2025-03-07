using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;
using System;
using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace Lista_06_Vetor_Lista
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
                    Console.WriteLine("Escolha uma questão que deseja executar(entre 1 a 14) ou então digite 0 para sair: ");
                    opcao = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (opcao)
                    {
                        case 1:
                            SomaMediaEx01();
                            break;
                        case 2:
                            MaiorMenorVetorEx02();
                            break;
                        case 3:
                            ParImparVetorEx03();
                            break;
                        case 4:
                            BuscaValorEx04();
                            break;
                        case 5:
                            InverteVetorEx05();
                            break;
                        case 6:
                            ProcuraVetorEx06();
                            break;
                        case 7:
                            MesclaVetoresEx07();
                            break;
                        case 8:
                            ListaIntEx08();
                            break;
                        case 9:
                            SomaIntEx09();
                            break;
                        case 10:
                            ListaIntEx10();
                            break;
                        case 11:
                            ListaFrutaEx11();
                            break;
                        case 12:
                            MaiorQue50Ex12();
                            break;
                        case 13:
                            ListNomeEx13();
                            break;
                        case 14:
                            ListNumeroEx14();
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

        //Vetores
        //1. Soma e Média: Escreva um programa que lê um vetor de 5 números inteiros e calcula a soma e a média dos elementos.
        static void SomaMediaEx01()
        {
            try
            {
                int[] vetorInt = new int[5];
                int soma = 0;

                for (int i = 0; i < 5; i++)
                    vetorInt[i] = PedirInt($"Digite o {i + 1} número: ");

                foreach (int i in vetorInt)
                    soma += i;

                Console.WriteLine($"Soma total do vetor: {soma}\nMédia do vetor: {soma / vetorInt.Length}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        //2. Maior e Menor Valor: Crie um programa que encontra e exibe o maior e o menor valor em um vetor de números reais.
        static void MaiorMenorVetorEx02()
        {
            try
            {
                double[] vetorDouble = new double[5];
                double maior = 0, menor = 0;

                for (int i = 0; i < 5; i++)
                {
                    vetorDouble[i] = PedirDouble($"Digite o {i + 1} número: ");

                    if (i == 0 || vetorDouble[i] > maior)
                        maior = vetorDouble[i];
                    if (i == 0 || vetorDouble[i] < menor)
                        menor = vetorDouble[i];
                }

                Console.WriteLine($"Maior Número do Vetor: {maior}\nMenor Número do Vetor: {menor}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }
        //3. Pares e Ímpares: Implemente um programa que divide um vetor de inteiros em dois vetores: um contendo os números pares e outro os números ímpares.
        static void ParImparVetorEx03()
        {
            try
            {
                int[] vetorParImpar = new int[5];
                int[] vetorImpar = new int[5];
                int[] vetorPar = new int[5];
                int j = 0, k = 0;

                for (int i = 0; i < 5; i++)
                {
                    vetorParImpar[i] = PedirInt($"Digite o {i + 1} número: ");

                    if (vetorParImpar[i] % 2 == 0)
                        vetorPar[j++] = vetorParImpar[i];
                    else
                        vetorImpar[k++] = vetorParImpar[i];
                }

                PrintarVetor("Vetor Impar e Par: ", vetorParImpar);
                PrintarVetor("Vetor Impar: ", vetorImpar);
                PrintarVetor("Vetor Par: ", vetorPar);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static void PrintarVetor(string frase, int[] vetor)
        {
            Console.WriteLine(frase);

            foreach (int i in vetor)
                Console.WriteLine(i);
        }

        //4. Busca por Valor: Crie uma função que recebe um vetor e um valor para procurar. A função deve retornar verdadeiro se o valor estiver presente no vetor e falso caso contrário.
        static void BuscaValorEx04()
        {
            try
            {
                string[] vetorString = new string[5];

                for (int i = 0; i < 5; i++)
                    vetorString[i] = PedirString($"Digite a {i + 1}ª frase: ");

                string stringProcura = PedirString("\nDigite a frase que deseja verificar se esta presente no vetor: ");
                Console.WriteLine($"A string está presente no vetor: {VerificaValor(vetorString, stringProcura)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static bool VerificaValor(string[] vetor, string compara)
        {
            foreach (string i in vetor)
                if (compara.ToUpper() == i.ToUpper())
                    return true;

            return false;
        }

        //5. Inversão de Vetor: Escreva um programa que inverte a ordem dos elementos em um vetor (não utilizar função pronta).
        static void InverteVetorEx05()
        {
            try
            {
                Console.WriteLine("Digite uma frase para ser invertida:");
                string frase = Console.ReadLine();
                Console.WriteLine($"String Invertida: {InverteVetor(frase)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static string InverteVetor(string vetor)
        {
            string newVetor = "";

            for (int i = vetor.Length; i > 0; i--)
            {
                newVetor += vetor[i - 1];
            }
            return newVetor;
        }

        //6. Contagem de Elementos: Implemente uma função que conta quantas vezes um determinado valor aparece em um vetor.
        static void ProcuraVetorEx06()
        {
            try
            {
                string[] vetorString = new string[5];

                Console.WriteLine("Digite a lista de elementos do vetor:");
                for (int i = 0; i < 5; i++)
                    vetorString[i] = PedirString($"Digite a {i + 1}ª frase: ");

                Console.Write("\nDigite uma frase para ser procurada:");
                string frase = Console.ReadLine();
                Console.WriteLine($"A frase aparece no vetor {ProcuraVetor(vetorString, frase)} vezes.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static int ProcuraVetor(string[] vetor, string palavraProcurada)
        {
            int quant = 0;
            foreach (string i in vetor)
            {
                if (Equals(i.ToLower(), palavraProcurada.ToLower()))
                    quant++;
            }
            return quant;
        }

        //7. Mescla de Vetores: Desenvolva um programa que recebe dois vetores de inteiros ordenados e cria um terceiro vetor mesclando os elementos dos dois em ordem crescente.
        static void MesclaVetoresEx07()
        {
            try
            {
                int[] vetor1 = { 1, 3, 5, 7, 20 };
                int[] vetor2 = { 2, 4, 6, 8, 10 };
                int[] vetorMesclado = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    if (i < 5)
                        vetorMesclado[i] = vetor1[i];
                    else
                        vetorMesclado[i] = vetor2[i - 5];
                }

                Array.Sort(vetorMesclado);

                Console.WriteLine("Vetor Ordenado: ");
                foreach (int i in vetorMesclado)
                    Console.WriteLine(i);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }

        }

        //List
        //1. Crie uma List de inteiros e adicione os números de 1 a 5. Exiba os números no console.
        static void ListaIntEx08()
        {
            try
            {
                List<int> listaInt = new List<int>();

                Console.WriteLine("Lista de números do 1 ao 5");
                for (int i = 1; i <= 5; i++)
                    listaInt.Add(i);

                foreach (int i in listaInt)
                    Console.WriteLine(i);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        //2. Crie uma List de números inteiros. Solicite ao usuário para digitar 5 números e adicione-os à lista.Em seguida, calcule e exiba a soma de todos os números.
        static void SomaIntEx09()
        {
            try
            {
                List<int> listaInt = new List<int>();
                int soma = 0;

                Console.WriteLine("Digite 5 números e farei a soma:");
                for (int i = 1; i <= 5; i++)
                    listaInt.Add(int.Parse(Console.ReadLine()));

                foreach (int i in listaInt)
                    soma += i;
                Console.WriteLine($"Soma dos Números da Lista: {soma}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        //3. Crie uma List de inteiros com 6 valores pré-definidos.Percorra a lista e encontre o maior número. Exiba o maior valor no console.
        static void ListaIntEx10()
        {
            try
            {
                int menor = 0, maior = 0;

                List<int> listaInt = new List<int> { 10, 23, 1, 53, 4, 5 };

                for (int i = 0; i < listaInt.Count; i++)
                {
                    if (listaInt[i] > maior)
                        maior = listaInt[i];
                    if (i == 0 || listaInt[i] < menor)
                        menor = listaInt[i];
                }
                Console.WriteLine($"O menor número é o {menor}.");
                Console.WriteLine($"O menor número é o {maior}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }


        //4. Crie uma List de strings com nomes de frutas ("banana", "maçã", "uva", "laranja"). Solicite ao usuário uma fruta para remover e remova-a da lista.Exiba a lista atualizada.
        static void ListaFrutaEx11()
        {
            try
            {
                List<string> listaFruta = new List<string> { "banana", "maçã", "uva", "laranja" };
                Console.WriteLine("""
                ------------Frutas Disponíveis------------
                - Banana
                - Maçã
                - Uva
                - Laranja

                Digite o nome da fruta que deseja remover:
                """);
                string nomeFruta = Console.ReadLine();

                if (listaFruta.Contains(nomeFruta.ToLower()))
                {
                    listaFruta.Remove(nomeFruta.ToLower());

                    Console.WriteLine("\n-----------Lista Atualizada-----------\n");
                    Console.WriteLine(string.Join(", ", listaFruta));
                }
                else
                {
                    Console.WriteLine("Fruta Não Existente.");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }

        }

        //5. Crie uma List de números inteiros. Adicione 10 números quaisquer à lista e conte quantos números são maiores que 50. Exiba o resultado.
        static void MaiorQue50Ex12()
        {
            try
            {
                List<int> listaInt = new List<int>();
                int quant = 0;

                Console.WriteLine("Digite 10 números e direi quantos deles são maior que 50.");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Digite o {i + 1}º Número: ");
                    listaInt.Add(int.Parse(Console.ReadLine()));

                    if (listaInt[i] > 50)
                        quant++;
                }

                Console.WriteLine($"{quant} Números são maiores do que 50 na lista acima.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        //6. Crie uma List de nomes ("Ana", "Bruno", "Carlos", "Diana", "Eduardo"). Pergunte ao usuário por um nome e informe se ele está presente na lista.
        static void ListNomeEx13()
        {
            try
            {
                List<string> NomeList = new List<string> { "Ana", "Bruno", "Carlos", "Diana", "Eduardo" };
                Console.WriteLine("Digite um nome para saber se está na lista: ");
                string nome = Console.ReadLine();

                if (NomeList.Contains(nome, StringComparer.OrdinalIgnoreCase))
                    Console.WriteLine("O nome está na lista.");
                else
                    Console.WriteLine("O nome não está na lista.");
                
                Console.WriteLine("\nLista:\n");
                foreach (string i in NomeList)
                    Console.WriteLine(i);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }
        //7. Crie uma List de números inteiros contendo pelo menos 5 elementos.Remova o primeiro e o último elemento da lista e exiba os valores restantes.
        static void ListNumeroEx14()
        {
            try
            {
                List<int> listaInt = new List<int> {1, 2, 3, 4, 5};
                listaInt.RemoveAt(0);
                listaInt.RemoveAt(listaInt.Count - 1);
                Console.WriteLine("Lista Atualizada: ");
                foreach (int i in listaInt)
                    Console.WriteLine(i);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }


        static int PedirInt(string pergunta)
        {
            Console.Write(pergunta);
            return int.Parse(Console.ReadLine());
        }

        static double PedirDouble(string pergunta)
        {
            Console.Write(pergunta);
            return double.Parse(Console.ReadLine());
        }

        static string PedirString(string pergunta)
        {
            Console.Write(pergunta);
            return Console.ReadLine();
        }
    }
}