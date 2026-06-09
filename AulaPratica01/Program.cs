// Meu Cartão de Apresentação:
// nome, idade, profissão, cidade natal

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

ExibirInformacoesDeProduto("Teclado", 299,5);

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


