using System.Diagnostics.Metrics;
using System;

//Exercício 1: Imprimir números de 1 a 10:
//Escreva um programa em C# que utilize um loop for para imprimir os números de 1 a 10;
Console.WriteLine("Print dos números de 1 a 10:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

//Exercício 2: Calcular a soma dos primeiros 100 números inteiros:
//Desenvolva um programa em C# que calcule e exiba a soma dos primeiros 100 números inteiros usando um loop for.
Console.WriteLine("\nSoma dos primeiros 100 números: ");
int total = 0;
for (int i = 1; i <= 100; i++)
{
    total += i;
}
Console.WriteLine(total);

//Exercício 3: Imprimir os números pares de 1 a 20:
//Crie um programa em C# que utilize um loop for para imprimir os números pares no intervalo de 1 a 20.
Console.WriteLine("\nNúmeros pares entre 1 a 20");
for (int i = 1; i <= 20; i+=2)
{
    if (i == 1)
        i++;
    Console.WriteLine(i);
}

//Exercício 4: Calcular o fatorial de um número dado:
//Elabore um programa em C# que calcule e apresente o fatorial de um número inteiro fornecido pelo usuário usando um loop for.
Console.WriteLine("\nDigite um número e darei seu fatorial: ");
int numero_04 = int.Parse(Console.ReadLine());
int fatorial = 1;

for(int i = 1;i <= numero_04; i++)
    fatorial *= i;

Console.WriteLine($"Fatorial: {fatorial}");

//Exercício 5: Imprimir a tabuada de multiplicação de um número dado:
//Descreva um programa em C# que exiba a tabuada de multiplicação de um número inteiro fornecido pelo usuário, usando um loop for para calcular os resultados.
Console.WriteLine("\nDigite até quanto deseja fazer sua tabuada: ");
int quantTabuada = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um número: ");
int tabuada = int.Parse(Console.ReadLine());

for(int i = 0; i <= quantTabuada; i++)
    Console.WriteLine($"{i} x {tabuada} = {i * tabuada}");

//Exercício 6: Contar a quantidade de números pares e ímpares em um intervalo:
//Crie um programa em C# que conte e mostre a quantidade de números pares e ímpares no intervalo de 1 a 100, usando um loop for.
Console.WriteLine("\nQuantidade de números ímpares e pares até o 100: ");
int par = 0, impar = 0;

for(int i = 1;i <= 100; i++)
{
    if (i % 2 == 0)
        par++;
    else 
        impar++;
}
Console.WriteLine($"Ímpares: {impar}\nPares: {par}");

//Exercício 7: Calcular a média de um conjunto de notas:
//Desenvolva um programa em C# que calcule a média de um conjunto de notas e exiba o resultado.
Console.WriteLine("\nQuantas notas deseja registrar para calcular a média: ");
int quantNotas = int.Parse(Console.ReadLine());
double media = 0;
double nota = 0.0;
for(int i = 1;i <= quantNotas; i++)
{
    Console.WriteLine($"Digite a {i}ª nota: ");
    nota = double.Parse(Console.ReadLine());
    media += nota;
}
Console.WriteLine($"Média das Notas: {media / quantNotas}");

//Exercício 8: Imprimir os primeiros 20 termos da sequência de Fibonacci:
//Escreva um programa em C# que utilize um loop for para calcular e imprimir os primeiros 20 termos da sequência de Fibonacci.
int j = 0;
int k = 1;
Console.WriteLine("\nOs primeiros 20 números de Fibonacci: ");
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(j);
    Console.WriteLine(k);
    j = j + k;
    k = j + k;
}

//Exercício 9: Verificar se um número é primo:
//Crie um programa em C# que verifique se um número inteiro fornecido pelo usuário é primo ou não, utilizando um loop for para realizar a verificação.
Console.WriteLine("\nDigite um número e direi se é primo: ");
int numero_09 = int.Parse(Console.ReadLine());
int quantDivisao = 0;
for(int i = 1;i <= numero_09; i++)
{
    if(numero_09 % i == 0)
        quantDivisao++;
}
if (quantDivisao == 2 && numero_09 > 1)
    Console.WriteLine("É primo.");
else 
    Console.WriteLine("Não é primo.");

//Exercício 10: Criar um padrão de triângulo utilizando asteriscos:
//Elabore um programa em C# que utilize loops for aninhados para criar e exibir um padrão de triângulo formado por asteriscos.

Console.WriteLine("\nTriângulo utilizando loop's FOR:\n");
for (int i = 0; i <= 10; i++) {
    for (int m = 0; m <= i; m++)
        Console.Write("* ");
        Console.WriteLine();
}

//Exercício 11: Soma de Números Pares
//Escreva um programa que calcule e exiba a soma dos números pares de 1 a 100 utilizando um loop for.
int somaPar = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
        somaPar += i;
}
Console.WriteLine($"\nSoma dos Pares de 1 a 100: {somaPar}");

//Exercício 12: Sequência de Potências
//Crie um programa que peça ao usuário para inserir um número inteiro e, em seguida, exiba a sequência de potências de 2 até a potência correspondente ao número inserido.
Console.WriteLine("\nDigite um número e retornarei uma sequencia de potências até a correspondente ao seu número: ");
int num_12 = int.Parse(Console.ReadLine());
long potencia = num_12;

for(int i = 2; i <= num_12; i++)
{
    potencia = potencia * num_12;
    Console.WriteLine($"Potência de {num_12}^{i}: {potencia}");
}

//Exercício 13: Contagem Regressiva
//Peça ao usuário para inserir um número inteiro positivo e utilize um loop for para fazer uma contagem regressiva a partir desse número até 1, exibindo cada valor.
Console.WriteLine("\nDigite um número e farei a contagem regressiva dele: ");
int num_13 = int.Parse(Console.ReadLine());

for (int i = num_13; i >= 1; i--)
    Console.WriteLine($"Contagem Regressiva: {i}");
