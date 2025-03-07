//Exercício 01
//Declare uma variável do tipo int, atribua um valor e imprima na tela.
Console.WriteLine("---------QUESTÃO 01---------");
int exercicio01 = 123;
Console.WriteLine($"Valor exercicio 1={exercicio01}\n");

//Exercício 02
//Crie uma variável string com o nome do seu curso e exiba a mensagem: "Bem-vindo ao curso [nome]".
Console.WriteLine("---------QUESTÃO 02---------");
String nomeCurso = "C#";
Console.WriteLine($"Bem-vindo ao curso {nomeCurso}\n");

//Exercício 03
//Declare duas variáveis do tipo double, atribua e exiba a soma.
Console.WriteLine("---------QUESTÃO 03---------");
Double var1 = 5;
Double var2 = 3;
Console.WriteLine($"Soma dos dois Valores: {var1+var2}\n");

//Exercício 04
//Leia um número inteiro lido do teclado e exiba o quadrado desse número.
Console.WriteLine("---------QUESTÃO 04---------");
Console.WriteLine("Digite um número que informarei o mesmo ao quadrado: ");
int valorExercicio04 = int.Parse(Console.ReadLine());
Console.WriteLine($"Numero digitado ao quadrado: {valorExercicio04 * valorExercicio04}\n");

//Exercício 05
//Verifique se um número inteiro lido do teclado é par ou ímpar.
Console.WriteLine("---------QUESTÃO 05---------");
Console.WriteLine("Digite um número que falarei se é impar ou par: ");
int valorExercicio05 = int.Parse(Console.ReadLine());

if (valorExercicio05 % 2 == 0) Console.WriteLine("O número digitado é par\n");
else Console.WriteLine("O número digitado é ímpar\n");

//Exercício 06
//Leia dois números inteiros e exiba o maior deles.
Console.WriteLine("---------QUESTÃO 06---------");
Console.WriteLine("Digite dois números que direi qual é o maior: ");
int var1_6 = int.Parse(Console.ReadLine());
int var2_6 = int.Parse(Console.ReadLine());

if (var1_6 > var2_6) Console.WriteLine("O primeiro número é maior que o segundo\n");
else if (var2_6 > var1_6) Console.WriteLine("O segundo número é maior que o primeiro\n");
else Console.WriteLine("Os números são iguais\n");

//Exercício 07
//Crie uma variável booleana que indica se a soma de dois núemros é maior que 100.
Console.WriteLine("---------QUESTÃO 07---------");
Console.WriteLine("Digite dois números que mostrarei se a soma é maior que 100: ");
int var1_7 = int.Parse(Console.ReadLine());
int var2_7 = int.Parse(Console.ReadLine());
Boolean ehMaior = var1_7 + var2_7 > 100;
Console.WriteLine($"A soma é maior que 100: {ehMaior}\n");

//Exercício 08
//Crie uma variável double para int e exiba o valor antes e depois da conversão.
Console.WriteLine("---------QUESTÃO 08---------");
Double var1_8 = 1.24;
int var2_8 = (int)var1_8;
Console.WriteLine($"Variável antes da conversão: {var1_8}");
Console.WriteLine($"Variável depois da conversão: {var2_8}\n");

//Exercício 09
//Declare uma variável e calcule a variável ao cubo.
Console.WriteLine("---------QUESTÃO 09---------");
int var_9 = 3;
Console.WriteLine($"Variável ao Cubo: {var_9 * var_9 * var_9}\n");

//Exercício 10
//Crie uma expressão que verifica se um número é múltiplo de 5 e 3 ao mesmo tempo.
Console.WriteLine("---------QUESTÃO 10---------");
Console.WriteLine("Digite um número que direi se é múltiplo de 3 e 5 ao mesmo tempo: ");
int var_10 = int.Parse(Console.ReadLine());

if (var_10 % 3 == 0 && var_10 % 5 == 0) Console.WriteLine($"O numero {var_10} é múltiplo de 5 e de 3 ao mesmo tempo.\n");
else Console.WriteLine($"O número {var_10} não é múltiplo de 5 e 3 ao mesmo tempo.\n");

//Exercício 11
//Leia uma idade e exiba uma mensagem informando se é maior de idade.
Console.WriteLine("---------QUESTÃO 11---------");
Console.WriteLine("Digite sua idade para saber se você é maior de idade ou não: ");
int idade = int.Parse(Console.ReadLine());

if (idade > 18) Console.WriteLine("É maior de idade\n");
else Console.WriteLine("É menor de idade\n");

//Exercício 12
//Leia um valor em graus Celcius e converta para Fahrenheit.
Console.WriteLine("---------QUESTÃO 12---------");
Console.WriteLine("Digite uma temperatura em Celcius: ");
double temperatudaCelcius = double.Parse(Console.ReadLine());
double temperaturaFahrenheit = (temperatudaCelcius * 1.8) + 32;
Console.WriteLine($"Temperatura em Fahrenheit: {temperaturaFahrenheit}º\n");

//Exercício 13
//Crie um programa que recebe três números e exibe a média aritmética.
Console.WriteLine("---------QUESTÃO 13---------");
Console.WriteLine("Digite três números para realizar a média aritmética: ");
double var1_13 = double.Parse(Console.ReadLine());
double var2_13 = double.Parse(Console.ReadLine());
double var3_13 = double.Parse(Console.ReadLine());
Console.WriteLine($"Média Aritmética dos 3 números: {(var1_13 + var2_13 + var3_13) / 3}\n");

//Exercício 14
//Declare uma variável que representa um salário e calcule um aumento de 10%.
Console.WriteLine("---------QUESTÃO 14---------");
Console.WriteLine("Digite o valor do seu salário: ");
double valorSalario = double.Parse(Console.ReadLine());
Console.WriteLine($"Valor do salário com aumento de 10%: {valorSalario += valorSalario * 0.10}\n");

//Exercício 15
//Crie uma variável do tipo string e concatene com outra variável para formar uma frase.
Console.WriteLine("---------QUESTÃO 15---------");
String texto01 = "Meu nome é ";
String texto02 = "Alex Araujo";
Console.WriteLine($"{texto01+texto02}\n");

//Exercício 16
//Crie um programa que leia um número decimal e converta para inteiro.
Console.WriteLine("---------QUESTÃO 16---------");
Console.WriteLine("Digite um número decimal que irei converte-lo para inteiro: ");
Decimal var01_16 = Decimal.Parse(Console.ReadLine());
int var02_16 = (int)var01_16;
Console.WriteLine($"Número convertido: {var02_16}\n");

//Exercício 17
//Verifique se um número fornecido pelo usuário está entre 1 e 100.
Console.WriteLine("---------QUESTÃO 17---------");
Console.WriteLine("Digite um número que direi se está entre 1 e 100");
int numeroMaiorEMenor = int.Parse(Console.ReadLine());

if (numeroMaiorEMenor > 1 && numeroMaiorEMenor < 100) Console.WriteLine($"O número {numeroMaiorEMenor} está entre 1 e 100\n");
else Console.WriteLine($"O numero {numeroMaiorEMenor} não está entre 1 e 100\n");

//Exercício 18
//Leia um texto e exiba o número de caracteres usando Length.
Console.WriteLine("---------QUESTÃO 18---------");
Console.WriteLine("Digite um texto que direi quantos caracteres ele possui:");
String texto_18 = Console.ReadLine();
Console.WriteLine($"Número de caracteres: {texto_18.Replace(" ","").Length}\n");

//Exercício 19
//Receba duas strings e compare se elas são iguais, ignorando maiúsculas e minúsculas.
Console.WriteLine("---------QUESTÃO 19---------");
Console.WriteLine("Digite dois textos que direi se eles são iguais:");
String texto01_19 = Console.ReadLine();
String texto02_19 = Console.ReadLine();

if (texto01_19.Equals(texto02_19, StringComparison.OrdinalIgnoreCase) == true) Console.WriteLine("Os textos são iguais");
else Console.WriteLine("Os textos são diferentes");

