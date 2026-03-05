using c_.net.Common.Models;





































































































// List<string> listaString = new List<string>();

// listaString.Add("PE");
// listaString.Add("DF");
// listaString.Add("RJ");

// for (int contador = 0 ; contador < listaString.Count; contador++ )
// {
//     Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");

// }

// int contadorforeach =0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição N° {contadorforeach} - {item}");
//     contadorforeach++;
// }



// int [] arrayInteiros = new int[4];

// arrayInteiros[0] = 7;
// arrayInteiros[1] = 70;
// arrayInteiros[2] = 30;
// arrayInteiros[3] = 1;

// int[] arrayInteirosDobrado = new int [arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

//percorrendo com o for
// for (int contador =0; contador < arrayInteiros.Length; contador ++)
// {
//     Console.WriteLine($" Posição N° {contador} - {arrayInteiros[contador]}");
// }

// Console.WriteLine("percorrendo com foreach");

// int contadorforeach =0 ;

// foreach( int valor in arrayInteiros)
// {
//     Console.WriteLine($" Posição N° {contadorforeach} - (valor)");
//     contadorforeach++;
// }




// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;

// double altura = 1.0;

// decimal preco = 1.80M;

// bool condicao = true;


// Line("valor da variavel preco:" + preco);
// Console.WriteLine("valor da variavel condicao:" + condicao);Console.WriteLine(apresentacao);
// Console.WriteLine("valor da variavel quantidade:" + quantidade);
// Console.WriteLine("valor da variavel altura:" + altura);
// Console.WriteLine("Valor da variavel condicao" + condicao);

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Bruce";
//pessoa1.Idade = 2;
//pessoa1.Apresentar();

// int a =  10 ;
// int b = 20;
// int c = a + b;
// c = c +5; 
// c+= 5;
// c += 5;
// Console.WriteLine(c);


// int a = Convert.ToInt32("5");
// int a = int.Parse("5");
// Console.WriteLine(a);

// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);

// int a =5;
// double  b =a;
// Console.WriteLine(b);

// long a =long.MaxValue;
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b =a;

// double a = 4/2 +2;
// Console.WriteLine(a);

// string a = "15-";
// int b = Convert.ToInt32(a);
// int b =0;
// int.TryParse(a,out b);
// int.TryParse(a,out int  b);
// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso");

// int quantidadeEmEstoque = 10;
// int quantidadeCompra =4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade Compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a compra? {possivelVenda}");//retorna ou true ou false

// if (quantidadeCompra ==0)
// {
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe não temos a quantidade desejada em estoque.");
// }

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//             Console.WriteLine("Vogal");
//             break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;

// }


// bool ehMaiorIdade = true ;
// bool possueAutorizacoaResponsavel = false ;

// if (ehMaiorIdade || possueAutorizacoaResponsavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }

// bool possuePresencaMinima = true;
// double media = 7.5;

// if (possuePresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }

// bool choveu = true;
// bool estaTarde = true;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//  Console.WriteLine("Não Vou pedalar");
// }

// Calculadora calc = new Calculadora();

// calc.Somar(10,30);
// calc.Subtrair(50,45);
// calc.Multiplicar(3,8);
// calc.Dividir(50,5);
// calc.Potencia(3,3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.Raiz(36);

// int numero =10;

// Console.WriteLine(numero);
// Console.WriteLine("Incremetando o 10");
// //numro = numero + 1;
// numero++;
// Console.WriteLine(numero);

// int numeroDecremento = 20;
// Console.WriteLine("Decrementando o 20");
// //numro = numero - 1;
// numeroDecremento--;
// Console.WriteLine(numeroDecremento);

// int numero =5 ;

// Console.WriteLine($"{numero} x 1 = {numero * 1}");

// for ( int contador = 0; contador <=10; contador ++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// int numero = 5;
// int contador = 0;
// while (contador <= 10)
// {
// Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// contador++;
// }


// int numero = 5;
// int contador = 0;
// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }

// int soma =0 , numero = 0;

// do 
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero !=0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}" );

// string opcao;

// while(true)
// {
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente:");
//     Console.WriteLine("2 - Buscar cliente:");
//     Console.WriteLine("3 - Apagar cliente:");
//     Console.WriteLine("4 - Encerrar:");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);
//             break; 

//         default:
//             Console.WriteLine("Opção invalida");
//             break;   
//     }

// }

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente:");
//     Console.WriteLine("2 - Buscar cliente:");
//     Console.WriteLine("3 - Apagar cliente:");
//     Console.WriteLine("4 - Encerrar:");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             break; 

//         default:
//             Console.WriteLine("Opção invalida");
//             break;   
//     }

// }