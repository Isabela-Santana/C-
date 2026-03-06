using ExemploFundamentos.Models;
using System.Globalization;


// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("PE", "Pernambuco");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas gerais");

// Console.WriteLine(estado["MG"]);

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave : {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("------------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - Valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave : {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Não existe. È seguro adicionar a chave {chave}");
// }
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(2);

// foreach( int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removento o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach( int item in pilha)
// {
//     Console.WriteLine(item);
// }



// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(7);
// fila.Enqueue(8);
// fila.Enqueue(1);
// fila.Enqueue(4);

// foreach( int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($" Removendo o elemento : {fila.Dequeue()}");

// foreach( int item in fila)
// {
//     Console.WriteLine(item);
// }



// new ExemploExcecao().Metodo1();


// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoleitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// } catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro de leitura de arquivo. Arquivo não encontrado. {ex.Massage}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro de leitura de arquivo. Diretório não encontrado. {ex.Massage}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Massage}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }



// string dataString = "2026-03-04 22:30";
// bool sucesso = DateTime.TryParseExact(dataString, 
//                         "yyyy-MM-dd HH:mm",
//                         CultureInfo.InvariantCulture, 
//                         DateTimeStyles.None, 
//                         out DateTime data);
// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso Data: {data}");
// } 
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }
// Console.WriteLine(data);
// DateTime date = DateTime.Now;


// DateTime date = DateTime.Parse("40/03/2026 22:30");
// Console.WriteLine(date.ToShortTimeString());
// Console.WriteLine(date.ToShortDateString());
// Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(date);




// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 82.40M;
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine($"{valorMonetario:C}");

// double porcentagem = .3356;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

// int numero1 = 10;
// int numero2 = 20;
// string resultado =  numero1 + numero2;

// Console.WriteLine(resultado);



// Pessoa p1 = new Pessoa(nome: "Isabela", sobrenome: "Santana");
// Pessoa p2 = new Pessoa(nome: "Ingrid", sobrenome:"Dias");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();


// Pessoa p1 = new Pessoa();
// p1.Nome = "Isabela";
// p1.Sobrenome = "Santana";
// p1.Idade = 20;
// p1.Apresentar();
