//Exercícios While
//Exercício 1: Contagem Crescente
//Escreva um programa que utilize um loop while para exibir os números de 1 a 10 em ordem crescente.
using System.Xml.Schema;

Console.WriteLine("-------Contagem Crescente do 1 ao 10-------");
int contador = 1;
while (contador <= 10)
{
    Console.WriteLine(contador);
    contador++;
}

//Exercício 2: Adivinhe o Número
//Crie um jogo em que o computador gera um número aleatório entre 1 e 100, e o jogador deve adivinhar qual é esse número. Use um loop while para permitir que o jogador faça múltiplas tentativas até acertar. Caso ele digite zero o jogo deve se encerrar.
Console.WriteLine("\n-------Adivinhe o Número entre 1 e 100-------");

Random rand = new Random();
int numeroAleatorio = rand.Next(1, 101);
int chute = 0;
while (chute != numeroAleatorio && chute != 0)
{
    Console.WriteLine("Chute um número: ");
    chute = int.Parse(Console.ReadLine());

    if (chute != numeroAleatorio && chute > 0)
        Console.WriteLine("Chute errado.");
    else if (chute == numeroAleatorio)
        Console.WriteLine("Você acertou, parabéns!!!");
    else
        Console.WriteLine("Finalizando...");
}

//Exercício 3: Calculadora Simples
//Implemente uma calculadora simples que pede ao usuário para inserir dois números e uma operação (+, -, *, /). Use um loop while para permitir que o usuário realize cálculos repetidamente até optar por sair digitando q na operação desejada.
int opcao = 4;
int n1_3 = 0;
int n2_3 = 0;
while (opcao != 0)
{
    Console.WriteLine("\nDigite dois números para realizar um cálculo: ");
    n1_3 = int.Parse(Console.ReadLine());
    n2_3 = int.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("""
        Escolha uma opção de cálculo para realizar:
        1- + (Adição)
        2- - (Subtração)
        3- * (Multiplicação)
        4- / (Divisão)
        0- Sair
        """);
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"{n1_3} + {n2_3} = {n1_3 + n2_3}");
            break;
        case 2:
            Console.WriteLine($"{n1_3} - {n2_3} = {n1_3 - n2_3}");
            break;
        case 3:
            Console.WriteLine($"{n1_3} * {n2_3} = {n1_3 * n2_3}");
            break;
        case 4:
            Console.WriteLine($"{n1_3} / {n2_3} = {n1_3 / n2_3}");
            break;
        case 0:
            Console.WriteLine("Finalizando...");
            break;
        default:
            Console.WriteLine("Valor Inválido");
            break;
    }
}

//Exercício 4: Soma de Números
//Peça ao usuário para inserir uma série de números positivos. Use um loop while para continuar lendo números até que o usuário insira um número negativo. Em seguida, exiba a soma dos números positivos inseridos.
int n_4 = 10;
int total = 0;
Console.WriteLine("\nInsira um número positivo para adicionar ao total ou um número baixo de 0 para encerrar.");

while (n_4 > 0)
{
    n_4 = int.Parse(Console.ReadLine());
    if (n_4 > 0)
        total += n_4;
}
Console.WriteLine($"Soma total de todos os números positivos: {total}");

//Exercício 5: Fatorial
//Solicite um número inteiro positivo do usuário e calcule o fatorial desse número usando um loop while. Exiba o resultado no final.
Console.WriteLine("\nDigite um número e direi seu fatorial:");
int n_5 = int.Parse(Console.ReadLine());
long fatorial = n_5;
int i = 1;

while (i < n_5)
{
    fatorial *= i;
    i++;
}

Console.WriteLine($"Fatorial de {n_5} = {fatorial}");

//Exercícios Do While
//Exercício 1: Tabela de Multiplicação
//Escreva um programa que solicite ao usuário um número inteiro. O programa deve então imprimir a tabela de multiplicação desse número, exibindo os produtos do número pelo contador de 1 a 10.
Console.WriteLine("\nDigite um número e farei sua tabuada até o 10");
int num_1 = int.Parse(Console.ReadLine());
i = 1;
do
{
    Console.WriteLine($"{num_1} x {i} = {num_1 * i}");
    i++;
} while (i <= 10);

//Exercício 2: Média de Notas
//Desenvolva um programa que permita ao usuário inserir uma série de notas. O programa deve calcular e exibir a média das notas inseridas, desconsiderando notas negativas. A entrada de notas deve continuar até que o usuário insira o valor -1, indicando o final da entrada.
double nota = 0, media = 0;
i = 0;

do
{
    Console.WriteLine("\nDigite uma nota para inserir à média(ou -1 para sair): ");
    nota = int.Parse(Console.ReadLine());

    if (nota >= 0)
    {
        media += nota;
        i++;
    }
} while (nota != -1);

Console.WriteLine($"\nMédia das {i} notas = {media / i}");

//Exercício 3: Contagem Regressiva
//Escreva um programa que solicite ao usuário um número inteiro positivo e, em seguida, realize uma contagem regressiva a partir desse número até zero.
Console.WriteLine("\nDigite um número e farei sua contagem regressiva até o 0: ");
int num_03 = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine($"Contagem Regressiva: {num_03}");
    num_03--;
} while (num_03 >= 0);

//Exercício 4: Soma dos Dígitos
//Escreva um programa que solicite ao usuário um número inteiro e calcule a soma de seus dígitos. Por exemplo, se o usuário inserir 123, o programa deve calcular e exibir 1 + 2 + 3 = 6.
Console.WriteLine("\nDigite um número inteiro e farei a soma de seus dígitos: ");
int numero = int.Parse(Console.ReadLine());
int soma = 0;

while (numero > 0)
{
    soma += numero % 10;
    numero /= 10;
}

Console.WriteLine("A soma dos dígitos é " + soma);

//Exercício 5: Adivinhe o Número
//Crie um programa que gere um número aleatório entre 1 e 100. O programa deve pedir ao usuário para adivinhar o número gerado. O usuário deve inserir sua suposição, e o programa deve informar se o palpite está muito alto, muito baixo ou correto. O programa deve continuar solicitando palpites até que o usuário adivinhe o número correto.
Console.WriteLine("\n-------Adivinhe o Número entre 1 e 100-------");
numeroAleatorio = rand.Next(1, 101);
do
{
    Console.WriteLine("\nChute um número: ");
    chute = int.Parse(Console.ReadLine());

    if (chute > numeroAleatorio)
        Console.WriteLine("Chute Alto.");
    else if (chute == numeroAleatorio)
        Console.WriteLine("Você acertou, parabéns!!!");
    else
        Console.WriteLine("Chute Baixo.");
} while (chute != numeroAleatorio);