using System.Drawing;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;

namespace Lista_07_Matriz
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
                    Console.WriteLine("Escolha uma questão que deseja executar(entre 1 a 10) ou então digite 0 para sair: ");
                    opcao = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (opcao)
                    {
                        case 1:
                            MatrizDeclaradaEx01();
                            break;
                        case 2:
                            SomaMatriz02();
                            break;
                        case 3:
                            MaiorMenorMatriz03();
                            break;
                        case 4:
                            DiagonalMatrizEx04();
                            break;
                        case 5:
                            TranspostaMatrizEx05();
                            break;
                        case 6:
                            MatrizIdentidadeEx06();
                            break;
                        case 7:
                            MultiplicaMatrizesEx07();
                            break;
                        case 8:
                            MediaMatrizEx08();
                            break;
                        case 9:
                            MatrizNulaEx09();
                            break;
                        case 10:
                            CriarMatriz();
                            break;
                        case 0:
                            Console.WriteLine("Finalizando...");
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
                Console.WriteLine("Um erro Foi Entrado: ");
                Console.WriteLine(ex.Message);
            }
        }

        // 1. Criando uma Matriz
        // Declare e inicialize uma matriz 3x3 com valores inteiros e imprima seus elementos.
        static void MatrizDeclaradaEx01()
        {
            try
            {
                int[,] matriz = {
                    {2, 3, 1},
                    {3, 5, 10},
                    {7, 6, 14}
                };
                Console.WriteLine("Impressão de matriz 3x3:\n");
                ImprimirMatriz(matriz);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Um erro Foi Entrado: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        // 2. Soma dos Elementos
        // Crie um programa que percorre uma matriz e calcula a soma de todos os seus elementos.
        static void SomaMatriz02()
        {
            try
            {
                int[,] matriz =
                    {
                        {2, 3, 1},
                        {3, 5, 10},
                        {7, 6, 14}
                };

                ImprimirMatriz(matriz);
                Console.WriteLine($"A soma da matriz é igual a: {SomarMatriz(matriz)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Um erro Foi Entrado: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static int SomarMatriz(int[,] matriz)
        {
            int soma = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                }
            }

            return soma;
        }

        // 3. Maior e Menor Valor
        // Desenvolva um algoritmo que encontre o maior e o menor valor dentro de uma matriz.
        static void MaiorMenorMatriz03()
        {
            try
            {
                int[,] matriz ={
                    {2, 3, 1},
                    {3, 5, 10},
                    {7, 6, 14}
                };

                ImprimirMatriz(matriz);
                Console.WriteLine($"\nO maior número da matriz é: {Maior(matriz)}");
                Console.WriteLine($"O menor número da matriz é: {Menor(matriz)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Um erro Foi Entrado: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }

        }

        static int Maior(int[,] matriz)
        {
            int maior = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    if (matriz[i, j] > maior)
                        maior = matriz[i, j];
            return maior;
        }
        static int Menor(int[,] matriz)
        {
            int menor = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    if (matriz[i, j] < menor || (i == 0 && j == 0))
                        menor = matriz[i, j];
            return menor;
        }

        // 4. Diagonal Principal
        // Escreva um programa que exiba apenas os elementos da diagonal principal de uma matriz quadrada.
        static void DiagonalMatrizEx04()
        {
            try
            {
                int[,] matriz ={
                    {2, 3, 1},
                    {3, 5, 10},
                    {7, 6, 14}
                };

                ImprimirMatriz(matriz);
                Console.WriteLine("\nDiagonal Principal: ");
                Diagonal(matriz);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Um erro Foi Entrado: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
            
        }

        static void Diagonal(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                    if (i == j)
                        Console.WriteLine(matriz[i, j]);
        }

        // 5. Transposta de uma Matriz
        // Implemente um programa que gere a transposta de uma matriz 3x3.
        static void TranspostaMatrizEx05()
        {
            try
            {
                int[,] matriz =
                {
                    {2, 3, 1},
                    {3, 5, 10},
                    {7, 6, 14}};

                int[,] matrizNova = new int[3, 3];
                matrizNova = MatrizTransposta(matriz);

                ImprimirMatriz(matriz);
                Console.WriteLine("\nMatriz Transposta: ");
                ImprimirMatriz(matrizNova);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Um erro Foi Entrado: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
            
        }

        static int[,] MatrizTransposta(int[,] matriz)
        {
            int[,] matrizNova = new int[3, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matrizNova[i, j] = matriz[j, i];
                }
            }

            return matrizNova;
        }

        // 6. Matriz Identidade
        // Construa um programa que verifica se uma matriz quadrada é uma matriz identidade.
        static void MatrizIdentidadeEx06()
        {
            try
            {
                int[,] matriz ={
                    {1, 0, 0},
                    {0, 1, 0},
                    {0, 0, 1}
                };

                int[,] matriz2 ={
                    {1, 1, 0},
                    {0, 1, 0},
                    {0, 0, 1}
                };

                ImprimirMatriz(matriz);
                Console.WriteLine($"\nÉ Matriz Identidade: {MatrizIdentidade(matriz)}");

                Console.WriteLine("\nMatriz 2:");
                ImprimirMatriz(matriz2);
                Console.WriteLine($"\nÉ Matriz Identidade: {MatrizIdentidade(matriz2)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Um erro Foi Entrado: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }

        }

        static bool MatrizIdentidade(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j && matriz[i, j] != 1)
                        return false;
                    if (i != j && matriz[i, j] != 0)
                        return false;
                }
            }
            return true;
        }

        // 7. Multiplicação de Matrizes
        // Escreva um código que multiplica duas matrizes 2x2 e exibe o resultado.
        static void MultiplicaMatrizesEx07()
        {
            try
            {
                double[,] matriz = {
                    {1, 2},
                    {3, 4}};

                double[,] matriz2 = {
                    {2, 5},
                    {6, 3}};

                double[,] matriz3 = new double[2, 2];

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        matriz3[i, j] = 0;
                        for (int k = 0; k < 2; k++)
                        {
                            matriz3[i, j] += matriz[i, k] * matriz2[k, j];
                        }
                    }
                }
                Console.WriteLine("Multiplicação entre duas matrizes:\n");
                Console.WriteLine("Matriz 1:");
                ImprimirMatrizDouble(matriz);
                Console.WriteLine("\nMatriz 2:");
                ImprimirMatrizDouble(matriz2);
                Console.WriteLine("\nMatriz Resultado: ");
                ImprimirMatrizDouble(matriz3);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Um erro Foi Entrado: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        // 8. Média dos Elementos
        // Calcule a média dos valores armazenados em uma matriz 4x4.
        static void MediaMatrizEx08()
        {
            try
            {
                int[,] matriz = {
                    {3, 5, 15, 26},
                    {2, 1, 64, 95},
                    {86, 43, 100, 43},
                    {76, 45, 12, 33}
                };

                ImprimirMatriz(matriz);
                Console.WriteLine($"\nMédia da Matriz: {MediaMatriz(matriz)}");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Um erro Foi Entrado: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static double MediaMatriz(int[,] matriz)
        {
            int i = 0, j = 0;
            double media = 0;

            for (i = 0; i < matriz.GetLength(0); i++)
                for (j = 0; j < matriz.GetLength(1); j++)
                    media += matriz[i, j];

            return media / (j * i);
        }

        // 9. Matriz Esparsa
        // Desenvolva um programa que verifica se uma matriz possui mais elementos nulos (0) do que não nulos.
        static void MatrizNulaEx09()
        {
            try
            {
                int[,] matriz = {
                    {9, 3, 1},
                    {0, 0, 0},
                    {6, 0, 7}
                };

                ImprimirMatriz(matriz);
                Console.WriteLine($"\nA matriz possui mais elementos nulos do que não nulos: {MatrizNula(matriz)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Um erro Foi Entrado: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static bool MatrizNula(int[,] matriz)
        {
            int nulo = 0, naoNulo = 0;
            bool MaisNulo;

            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == 0)
                        nulo++;
                    else
                        naoNulo++;
                }
            if (nulo > naoNulo)
                return MaisNulo = true;
            else
                return MaisNulo = false;
        }

        // 10. Matriz Dinâmica
        // Crie uma matriz de tamanho variável, solicite ao usuário os valores e exiba a matriz na tela.
        static void CriarMatriz()
        {
            try
            {
                Console.WriteLine("Digite o número de linhas da matriz: ");
                int linhas = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o número de colunas da matriz: ");
                int colunas = int.Parse(Console.ReadLine());
                int[,] matriz = new int[linhas, colunas];

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.WriteLine($"Digite o valor da posição [{i},{j}]: ");
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("\n------------------Matriz Criada------------------\n");
                ImprimirMatriz(matriz);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Um erro Foi Entrado: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tente Novamente.");
            }
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j == matriz.GetLength(1) - 1)
                        Console.Write($"{matriz[i, j]}");
                    else
                        Console.Write($"{matriz[i, j]}, ");
                }
                Console.WriteLine("");
            }
        }

        static void ImprimirMatrizDouble(double[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j == matriz.GetLength(1) - 1)
                        Console.Write($"{matriz[i, j]}");
                    else
                        Console.Write($"{matriz[i, j]}, ");
                }
                Console.WriteLine("");
            }
        }
    }
}