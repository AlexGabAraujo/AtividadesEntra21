//----------Exercícios condição simples (if).-----------
//1. Escreva um programa que verifique se um número é positivo ou negativo e exiba uma mensagem correspondente.
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("\nEscreva um numego e direi se é positivo ou negativo:");
int numero = int.Parse(Console.ReadLine());
if (numero >= 0) Console.WriteLine("O número é positivo.");
else Console.WriteLine("O número é negativo");

//2. Crie um programa que determine se um usuário é maior de idade (idade igual ou acima de 18 anos) e exiba uma mensagem apropriada.
Console.WriteLine("\nDigite sua idade e direi se é maior de idade.");
int idade = int.Parse(Console.ReadLine());
if (idade >= 18) Console.WriteLine("Você é maior de idade.");
else Console.WriteLine("Você é menor de idade.");

//3. Desenvolva um programa que verifique se um número é par ou ímpar e exiba o resultado.
Console.WriteLine("\nEscreva um número e direi se é par ou ímpar:");
int numero_03 = int.Parse(Console.ReadLine());
if (numero_03 % 2 == 0) Console.WriteLine("O número é par.");
else Console.WriteLine("O número é ímpar");

//4. Faça um programa que determine se um aluno passou em um exame, considerando que a nota mínima para aprovação é 60.
Console.WriteLine("\nDigite sua nota para saber se passou no exame:");
int notaExame = int.Parse(Console.ReadLine());
if (notaExame >= 60) Console.WriteLine("Você passou.");
else Console.WriteLine("Você não passou.");

//5. Escreva um programa que verifique se um número digitado pelo usuário é múltiplo de 5.
Console.WriteLine("\nDigite um número para saber se é multiplo de 5:");
int numero_05 = int.Parse(Console.ReadLine());
if (numero_05 % 5 == 0) Console.WriteLine($"O número {numero_05} é multiplo de 5.");
else Console.WriteLine($"O número {numero_05} não é multiplo de 5");

//Exercícios condição composta (if-else).
//1. Crie um programa que, dado o peso e a altura de uma pessoa, determine se ela está abaixo do peso, com peso normal, com sobrepeso ou obesa, de acordo
//com o índice de massa corporal (IMC).
Console.WriteLine("\nDigite sua altura: ");
double altura = double.Parse(Console.ReadLine());
Console.WriteLine("Digite seu peso:");
double peso = double.Parse(Console.ReadLine());
double imc = peso / (altura * altura);

if (imc < 18.5)
    Console.WriteLine("IMC: Magreza");
else if (imc < 25)
    Console.WriteLine("IMC: Normal");
else if (imc < 30)
    Console.WriteLine("IMC: Sobrepeso");
else if (imc < 35)
    Console.WriteLine("IMC: Obesidade grau I");
else if (imc < 40)
    Console.WriteLine("IMC: Obesidade grau II");
else
    Console.WriteLine("IMC: Obesidade grau III");

//2. Desenvolva um programa que determine se um ano é bissexto ou não. Um ano é bissexto se for divisível por 4, mas não por 100, a menos que seja divisível por 400.
Console.WriteLine("\nDigite um ano para saber se é bissexto: ");
int ano = int.Parse(Console.ReadLine());
if (ano % 400 == 0)
{
    Console.WriteLine("O ano é bissexto");
}
else if (ano % 4 == 0 && ano % 100 != 0)
{
    Console.WriteLine("O ano é bissexto");
}
else
{
    Console.WriteLine("Não é ano bissexto");
}

//3. Faça um programa que determine o maior de três números digitados pelo usuário.
Console.WriteLine("\nDigite 3 números e direi qual é o maior entre eles: ");
int numero01 = int.Parse(Console.ReadLine());
int numero02 = int.Parse(Console.ReadLine());
int numero03 = int.Parse(Console.ReadLine());

if (numero01 > numero02 && numero01 > numero03 || numero01 == numero02)
    Console.WriteLine($"O maior número é o {numero01}");
else if (numero02 > numero01 && numero02 > numero03 || numero02 == numero03)
    Console.WriteLine($"O maior número é o {numero02}");
else if (numero03 > numero02 && numero03 > numero01 || numero03 == numero01)
    Console.WriteLine($"O maior número é o {numero03}");
else Console.WriteLine("Os números são iguais");

//4. Escreva um programa que calcule o preço de um produto com desconto de 10% se o valor total da compra for maior ou igual a R$100.
Console.WriteLine("\nDigite o valor da compra: ");
double valorProduto = double.Parse(Console.ReadLine());
if (valorProduto > 100.00)
    Console.WriteLine($"O valor final ficou: R$ {valorProduto - (valorProduto * 0.10)}");
else Console.WriteLine($"O valor final ficou: R$ {valorProduto}");

//5. Crie um programa que solicite o nome e a idade de um usuário e, com base na idade, apresente mensagens de boas-vindas apropriadas: "Bem-vindo, [Nome]!"
//para idades até 12 anos, "Olá, [Nome]!" para idades entre 13 e 19 anos, e "Olá, Sr./Sra. [Nome]!" para idades acima de 19 anos.
Console.WriteLine("\nDigite seu nome: ");
String nome = Console.ReadLine();
Console.WriteLine("Digite sua idade: ");
int idade_05 = int.Parse(Console.ReadLine());
if(idade_05 <= 12)
{
    Console.WriteLine($"Bem-vindo, {nome}!");
}else if(idade_05 <= 19)
{
    Console.WriteLine($"Olá, {nome}!");
}
else
{
    Console.WriteLine($"Olá, Sr./Sra. {nome}!");
}

//Exercícios operadores lógicos
//1. Crie um programa que verifique se um número digitado pelo usuário é positivo, negativo ou zero. Imprima a mensagem correspondente.
Console.WriteLine("\nDigite um número e direi se é positivo,negativo ou zero: ");
int numero_01 = int.Parse(Console.ReadLine());
if(numero_01 > 0)
{
    Console.WriteLine("O número é positivo");
}else if(numero_01 == 0)
{
    Console.WriteLine("O número é igual a 0");
}
else
{
    Console.WriteLine("O número é negativo");
}

//2. Desenvolva um programa que pergunte ao usuário se deseja um café. Se o usuário digitar "sim", pergunte se ele quer açúcar. Com base nas respostas,
//exiba uma mensagem adequada, como "Aqui está o seu café preto." ou "Aqui está o seu café com açúcar."
Console.WriteLine("\nVocê deseja tomar um café(sim ou nao): ");
String resposta = Console.ReadLine();
if(resposta == "sim")
{
    Console.WriteLine("Quer açucar: ");
    resposta = Console.ReadLine();

    if(resposta == "sim")
        Console.WriteLine("Aqui está o seu café com açúcar.");
    else 
        Console.WriteLine("Aqui está o seu café preto.");
}
else
{
    Console.WriteLine("Encerrando venda de café...");
}

//3. Crie um programa que peça ao usuário para digitar três números inteiros. Verifique se pelo menos dois dos números são iguais entre si. Se sim, imprima
//"Pelo menos dois números são iguais", caso contrário, imprima "Nenhum dos números é igual aos outros."
Console.WriteLine("\nDigite 3 números e direi se pelo menos dois são iguais");
int numero01_03 = int.Parse(Console.ReadLine());
int numero02_03 = int.Parse(Console.ReadLine());
int numero03_03 = int.Parse(Console.ReadLine());

if( numero01_03 == numero02_03 || numero01_03 == numero03_03 || numero03_03 == numero02_03)
    Console.WriteLine("Pelo menos dois números são iguais.");
else
    Console.WriteLine("Nenhum dos números é igual aos outros.");

//4. Escreva um programa que simule um caixa eletrônico. Peça ao usuário para digitar o saldo da conta e o valor que deseja sacar. Verifique se há saldo suficiente
//na conta. Se houver, imprima "Saque autorizado." Se não houver saldo suficiente, imprima "Saldo insuficiente."
Console.WriteLine("\nDigite o valor do saldo da conta: ");
double saldo = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor que deseja sacar: ");
double saque = double.Parse(Console.ReadLine());

if (saldo > saque)
    Console.WriteLine("Saque autorizado.");
else
    Console.WriteLine("Saldo insuficiente.");

//5. Crie um programa que simule um sistema de controle de acesso a um edifício. Peça ao usuário para digitar sua identificação e a hora de entrada. O acesso
//é permitido apenas se a identificação for válida (por exemplo, "12345") e se a hora de entrada estiver entre 9h e 18h. Imprima uma mensagem informando se o acesso foi autorizado ou negado.
Console.WriteLine("\nDigite a sua senha para entrar no edifício: ");
int senha = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a sua hora de entrada: ");
int hora = int.Parse(Console.ReadLine());

if (senha == 12345 && hora >= 9 && hora<=18)
    Console.WriteLine("Acesso Liberado.");
else
    Console.WriteLine("Acesso Negado.");

//Exercícios Switch Case
//1. Calculadora Simples: Crie uma calculadora simples que solicite ao usuário dois números e um operador (+, -, *, /). Use switch case para realizar a operação
//escolhida e mostrar o resultado.
Console.WriteLine("\nDigite dois números para realizar uma operação: ");
int numero01_01 = int.Parse(Console.ReadLine());
int numero02_01 = int.Parse(Console.ReadLine());

Console.WriteLine("""
    ----CALCULADORA----
    Digite qual operação você deseja realizar:
    1- + (Soma)
    2- - (Subtração)
    3- * (Multiplicação)
    4- / (Divisão)
    """);
int opcao = int.Parse(Console.ReadLine());
Console.WriteLine();

switch (opcao)
{
    case 1:
        Console.WriteLine($"Soma: {numero01_01 + numero02_01}");
        break;
    case 2:
        Console.WriteLine($"Subtração: {numero01_01 - numero02_01}");
        break;
    case 3:
        Console.WriteLine($"Multiplicação: {numero01_01 * numero02_01}");
        break;
    case 4:
        Console.WriteLine($"Divisão: {numero01_01 / numero02_01}");
        break;
    default:
        Console.WriteLine("Opção Inválida");
        break;
}

//2. Conversão de Unidades: Crie um conversor de unidades que permita ao usuário escolher entre converter uma quantidade em metros para centímetros ou
//centímetros para metros usando switch case.
Console.WriteLine();
Console.WriteLine("""
    ----Conversora de Medidas----
    Digite qual conversão você deseja realizar:
    1- Metro para centímetro.
    2- Centímetro para metro.
    """);
int opcao_02 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor que deseja converter: ");
double medida = double.Parse(Console.ReadLine());

Console.WriteLine();

switch (opcao_02)
{
    case 1:
        Console.WriteLine($"Conversão para centímetros: {medida * 100}cm");
        break;
    case 2:
        Console.WriteLine($"Conversão para metros: {medida / 100}m");
        break;
    default:
        Console.WriteLine("Opção Inválida");
        break;
}


//3. Seleção de Língua: Desenvolva um programa multilíngue que solicite ao usuário que escolha um idioma (1 para inglês, 2 para espanhol, 3 para francês)
//e exiba uma saudação de boas-vindas nesse idioma usando switch case. Se o idioma escolhido não estiver disponível, exiba uma mensagem informando que o idioma é inválido.
Console.WriteLine();
Console.WriteLine("""
    ----Saudações em Diferentes Línguas----
    Digite a língua que deseja:
    1- Inglês.
    2- Espanhol.
    3- Francês.
    """);
int opcao_03 = int.Parse(Console.ReadLine());
Console.WriteLine();

switch (opcao_03)
{
    case 1:
        Console.WriteLine("Bem vindo em Inglês: Welcome");
        break;
    case 2:
        Console.WriteLine("Bem vindo em Espanhol: Bienvenido");
        break;
    case 3:
        Console.WriteLine("Bem vindo em Francês: Bienvenue");
        break;
    default:
        Console.WriteLine("Opção Inválida");
        break;
}

//4. Conversão de Meses: Desenvolva um conversor de meses que solicite ao usuário um número de 1 a 12, representando um mês do ano.
//Use switch case para exibir o nome do mês correspondente. Se o número estiver fora do intervalo, mostre uma mensagem de erro.
Console.WriteLine("\nDigite um número de 1-12 e direi qual mês ele representa: ");
int numero_04 = int.Parse(Console.ReadLine());
Console.WriteLine();

switch (numero_04)
{
    case 1:
        Console.WriteLine("Mês: Janeiro");
        break;
    case 2:
        Console.WriteLine("Mês: Fevereiro");
        break;
    case 3:
        Console.WriteLine("Mês: Março");
        break;
    case 4:
        Console.WriteLine("Mês: Abril");
        break;
    case 5:
        Console.WriteLine("Mês: Maio");
        break;
    case 6:
        Console.WriteLine("Mês: Junho");
        break;
    case 7:
        Console.WriteLine("Mês: Julho");
        break;
    case 8:
        Console.WriteLine("Mês: Agosto");
        break;
    case 9:
        Console.WriteLine("Mês: Setembro");
        break;
    case 10:
        Console.WriteLine("Mês: Outubro");
        break;
    case 11:
        Console.WriteLine("Mês: Novembro");
        break;
    case 12:
        Console.WriteLine("Mês: Dezembro");
        break;
    default:
        Console.WriteLine("Número Inválido.");
        break;
}

//Exercícios Operador Ternário
//1. Verificação de Paridade: Escreva uma função chamada VerificarParidade que recebe um número inteiro como argumento e retorna uma string "Par" se o número
//for par e "Ímpar" se for ímpar.
Console.WriteLine("\nDigite um número inteiro e direi se é par ou ímpar: ");
int VerificarParidade = int.Parse(Console.ReadLine());
String mensagem = VerificarParidade % 2 == 0 ? "O número é par." : "O número é ímpar";
Console.WriteLine(mensagem);

//2. Calculadora de Desconto: Crie uma função chamada CalcularDesconto que recebe o preço de um produto e um booleano indicando se o cliente é um membro VIP.
//Se o cliente for VIP, o desconto é de 20%; caso contrário, o desconto é de 10%. A função deve retornar o preço com o desconto aplicado.
Console.WriteLine("\nDigite o valor do produto: ");
double CalcularDesconto = double.Parse(Console.ReadLine());
Console.WriteLine("O cliente é VIP(s para sim, n para não): ");
String resposta_02 = Console.ReadLine();
bool vip = resposta_02 == "s";
String mensagem_02 = vip == true ? $"Valor Final: R$ {CalcularDesconto - CalcularDesconto * 0.20}." : $"Valor Final: R$ {CalcularDesconto - CalcularDesconto * 0.10}.";
Console.WriteLine(mensagem_02);

//3. Classificação de Aluno: Crie um programa que solicita ao usuário a nota de um aluno e determine se ele foi aprovado ou reprovado. Use o operador ternário
//para definir a aprovação com base na nota (por exemplo, notas maiores ou iguais a 6 são aprovadas).
Console.WriteLine("\nDigite usa nota para saber se passou: ");
int nota_03 = int.Parse(Console.ReadLine());
String mensagem_03 = nota_03 >= 6 ? "Aprovado." : "Reprovado.";
Console.WriteLine(mensagem_03);

//4. Avaliação de Idade: Crie uma função chamada ClassificarIdade que recebe a idade de uma pessoa como argumento e retorna uma string indicando se a pessoa é
//uma "Criança" (até 12 anos), "Adolescente" (de 13 a 19 anos) ou "Adulto" (20 anos ou mais).
Console.WriteLine("\nDigite sua idade para saber se você é criança, adolescente ou adulto: ");
int ClassificarIdade = int.Parse(Console.ReadLine());
String mensagem_04 = ClassificarIdade <= 12 ? "Criança." : ClassificarIdade <= 19 ? "Adolescente." : "Adulto."; ;
Console.WriteLine(mensagem_04);