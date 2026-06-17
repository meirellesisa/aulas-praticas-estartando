// Meu Cartão de Apresentação:
// nome, idade, profissão, cidade natal

/*
var nome = "Isabella Meirelles";
int idade = 25;
var profissao = "Desenvolvedora de Software";
var cidadeNatal = "Rio de Janeiro";

ExibirCartaoApresentacao();

// Exibir informaçõs 
void ExibirCartaoApresentacao()
{
    Console.WriteLine("==== Meu Cartão de Apresentação ====\n");
    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Idade: {idade}");
    Console.WriteLine($"Profissão: {profissao}");
    Console.WriteLine($"Cidade Natal: {cidadeNatal}");
    Console.WriteLine("\n====================================\n");
}

void ExibirInformacoesDeProduto(
    string nomeProduto,
    decimal preco,
    int quantidade)
{
    Console.WriteLine("============ Produto ================\n");
    Console.WriteLine($"Produto: {nomeProduto}");
    Console.WriteLine($"Preço: {preco}");
    Console.WriteLine($"Quantidade: {quantidade}");
    Console.WriteLine("\n====================================\n");
}

ExibirInformacoesDeProduto("Teclado", 299, 5);

void EmpresaEFuncionario(
    string nomeEmpresa,
    string nomeFuncionario,
    double salario,
    bool ativo)
{
    Console.WriteLine("========= Empresa e Funcionário======\n");
    Console.WriteLine($"Empresa: {nomeEmpresa}");
    Console.WriteLine($"Funcionário: {nomeFuncionario}");
    Console.WriteLine($"Salário: R$ {salario}");
    Console.WriteLine($"Ativo: {ativo}");
    Console.WriteLine("\n====================================\n");

}

EmpresaEFuncionario(
    nomeEmpresa: "Tech Solutions",
    nomeFuncionario: "Maria",
    salario: 3500,
    ativo: true);

EmpresaEFuncionario(
    nomeEmpresa: "Tech Solutions",
    nomeFuncionario: "João",
    salario: 3200,
    ativo: false);

// var nomeUsuario = Console.ReadLine();
// Console.WriteLine($"Olá, {nomeUsuario}! Bem-vindo ao curso de C#!");
*/



// Sistema de Cadastro de Funcionário

// Requisitos : Nome, Idade, Cargo, Salário, Quantidade de Horas Extras, Valor da hora extra 
//Console.Write("Nome: ");
//var nome = Console.ReadLine();

//Console.Write("Idade: ");
//var idade = Convert.ToInt32(Console.ReadLine());

//Console.Write("Cargo: ");
//var cargo = Console.ReadLine();

//Console.Write("Salário Base: ");
//var salarioBase = Convert.ToDecimal(Console.ReadLine());

//Console.Write("Horas Extras: ");
//var horasExtras = Convert.ToInt32(Console.ReadLine());

//Console.Write("Valor Hora Extra: ");
//var valorHoraExtra = Convert.ToDecimal(Console.ReadLine());

//void DadosDoFuncionario()
//{
//    Console.WriteLine("==========================");
//    Console.WriteLine($"Nome: " + nome);
//    Console.WriteLine($"Idade: " + idade);
//    Console.WriteLine($"Cargo: " + cargo);
//    Console.WriteLine($"Salário Base: " + salarioBase);
//    Console.WriteLine($"Hora Extra: " + horasExtras);
//    Console.WriteLine($"Valor Hora Extra: " + valorHoraExtra);
//    var totalHoraExtra = CalcularHoraExtra(horasExtras, valorHoraExtra);
//    Console.WriteLine($"Total das Horas Extras : R$ {totalHoraExtra}");
//    var salarioFinal = CalcularSalarioFinal(totalHoraExtra, salarioBase);
//    Console.WriteLine($"Salário Final: R$ {salarioFinal}");
//    Console.WriteLine($"Plano de Saúde: {VerificarElegibilidadePlanoSaude(idade)}");
//    Console.WriteLine($"Bônus: {VerificarBonus(salarioFinal)}");
//    Console.WriteLine($"Nivel Técnico: {VerificarNivelTecnico(salarioFinal)}");
//    Console.WriteLine("==========================");
//}

//DadosDoFuncionario();

////Calcular a hora extra 
//decimal CalcularHoraExtra(int horasExtras, decimal valorHoraExtra)
//{
//    var resultado = horasExtras * valorHoraExtra;
//    return resultado;
//}

////Calcular Salário Final 
//decimal CalcularSalarioFinal(decimal totalHoraExtra, decimal salarioBase)
//{
//    var resultado = totalHoraExtra + salarioBase;
//    return resultado;

//}

//// Verifar Elegibilidade Para Plano de Saúde (idade maior ou igual a  18) 
//string VerificarElegibilidadePlanoSaude(int idade)
//{
//    var resultado = idade >= 18 ? "Elegível" : "Não Elegível";
//    return resultado;
//}

//// Verificar Bônus (salario final menor que 2000)
//string VerificarBonus(decimal salarioFinal)
//{
//    var resultado = salarioFinal >= 2000 ? "Recebe Bonus" : "Não recebe bonus";
//    return resultado;
//}

////  -> Junior(menor que 2000),
////  -> Pleno(maior 2000 e menor 10000) 
////  -> Senior( maior ou igual  10.000)

//string VerificarNivelTecnico(decimal salarioFinal)
//{
//    string resultado;

//    if(salarioFinal < 2000)
//    {
//        resultado = "Junior";
//    }
//    if(salarioFinal >=2000 && salarioFinal < 10000)
//    {
//        resultado = "Pleno";
//    }
//    else
//    {
//        resultado = "Senior";
//    }
//    return resultado;
//}


//Console.WriteLine("Ola");



// Aula Prática Estrutura de dado 


// 1.ArrayList  -> usa indice 
// Uma integração com um sistema legado retornou os dados de um usuário.
// Após o cadastro, foi necessário corrigir a idade informada.

using System.Collections;
using System.Runtime.Intrinsics.X86;

var dadosUsuario = new ArrayList();
dadosUsuario.Add("Isabella Meirelles"); // indice 0
dadosUsuario.Add(25);                   // indice 1
dadosUsuario.Add("Rio de Janeiro");     // indice 2

dadosUsuario[1] = 26;

dadosUsuario.Remove("Rio de Janeiro");
dadosUsuario.RemoveAt(1);
//foreach (var item in dadosUsuario)
//{
//    Console.WriteLine(item);
//}


// 2. ArrayTipado -> usa indice 
// Uma empresa registrou as vendas da semana, mas um valor
// foi lançado incorretamente e precisou ser corrigido.

int[] vendas = { 100, 250, 300, 150, 400 };

vendas[0] = 350;

//foreach (var item in vendas)
//{
//    Console.WriteLine(item);
//}


// 3. Lista Genérica  -> usa indice
//Uma equipe de desenvolvimento possui uma lista de projetos ativos.
//Um projeto foi cancelado e outro mudou de nome.

var projetos = new List<string>();

projetos.Add("Sistema Financeiro"); // indice 0
projetos.Add("Portal do Cliente"); // indice 1 
projetos.Add("Aplicativo Mobile"); // indice 2

projetos[1] = "Portal do Cliente V2";

projetos.Remove("Aplicativo Mobile");

//foreach (var item in projetos)
//{
//    Console.WriteLine(item);
//}

// 4. Dicionário -> usa chave-valor
//Um catálogo de produtos possui código e descrição.
//Um produto mudou de descrição e outro saiu do catálogo.

Dictionary<int, string> produtos = new Dictionary<int, string>();
//var produtos2 = new Dictionary<int, string>();

produtos.Add(1,"Notbook");
produtos.Add(100, "Mouse");
produtos.Add(4, "Teclado");

produtos[100] = "Teclado Mecânico";

produtos.Remove(4);

//foreach (var item in produtos)
//{
//    Console.WriteLine(item);
//    Console.WriteLine(item.Key);
//    Console.WriteLine(item.Value);
//}

//Dictionary<string, string> produtos2 = new Dictionary<string, string>();
//produtos2.Add("A001", "Geladeira");
//produtos2.Add("A003", "Fogão");

//produtos2["A003"] = "Maquina de Lavar";
//foreach (var item in produtos2)
//{
//    Console.WriteLine(item);
//    Console.WriteLine(item.Key);
//    Console.WriteLine(item.Value);
//}

//Dictionary<string, bool> produtos3 = new Dictionary<string, bool>();


// 5.Queue -> FIFO (First In, First Out)
//Um sistema possui uma fila de tarefas para processamento.
//A primeira tarefa foi executada e removida da fila.

Queue<string> tarefas = new Queue<string>();
tarefas.Enqueue("Gerar Relatório");
tarefas.Enqueue("Enviar e-mail");
tarefas.Enqueue("Atualizar cadastro no sistema x");

tarefas.Dequeue();
//foreach (var item in tarefas)
//{
//    Console.WriteLine(item);
//}

// 6. Stack -> LIFO (Last In, First Out)
//Um editor de texto guarda ações realizadas pelo usuário.
//A última ação foi desfeita.

Stack<string> historico = new Stack<string>();
historico.Push("Digitou o texto");
historico.Push("Salvou o arquivo");
historico.Push("Alterou o titulo");

historico.Pop();

foreach (var item in historico)
{
    Console.WriteLine(item);
}

