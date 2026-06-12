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
Console.Write("Nome: ");
var nome = Console.ReadLine();

Console.Write("Idade: ");
var idade = Convert.ToInt32(Console.ReadLine());

Console.Write("Cargo: ");
var cargo = Console.ReadLine();

Console.Write("Salário Base: ");
var salarioBase = Convert.ToDecimal(Console.ReadLine());

Console.Write("Horas Extras: ");
var horasExtras = Convert.ToInt32(Console.ReadLine());

Console.Write("Valor Hora Extra: ");
var valorHoraExtra = Convert.ToDecimal(Console.ReadLine());

void DadosDoFuncionario()
{
    Console.WriteLine("==========================");
    Console.WriteLine($"Nome: " + nome);
    Console.WriteLine($"Idade: " + idade);
    Console.WriteLine($"Cargo: " + cargo);
    Console.WriteLine($"Salário Base: " + salarioBase);
    Console.WriteLine($"Hora Extra: " + horasExtras);
    Console.WriteLine($"Valor Hora Extra: " + valorHoraExtra);
    var totalHoraExtra = CalcularHoraExtra(horasExtras, valorHoraExtra);
    Console.WriteLine($"Total das Horas Extras : R$ {totalHoraExtra}");
    var salarioFinal = CalcularSalarioFinal(totalHoraExtra, salarioBase);
    Console.WriteLine($"Salário Final: R$ {salarioFinal}");
    Console.WriteLine($"Plano de Saúde: {VerificarElegibilidadePlanoSaude(idade)}");
    Console.WriteLine($"Bônus: {VerificarBonus(salarioFinal)}");
    Console.WriteLine($"Nivel Técnico: {VerificarNivelTecnico(salarioFinal)}");
    Console.WriteLine("==========================");
}

DadosDoFuncionario();

//Calcular a hora extra 
decimal CalcularHoraExtra(int horasExtras, decimal valorHoraExtra)
{
    var resultado = horasExtras * valorHoraExtra;
    return resultado;
}

//Calcular Salário Final 
decimal CalcularSalarioFinal(decimal totalHoraExtra, decimal salarioBase)
{
    var resultado = totalHoraExtra + salarioBase;
    return resultado;
    
}

// Verifar Elegibilidade Para Plano de Saúde (idade maior ou igual a  18) 
string VerificarElegibilidadePlanoSaude(int idade)
{
    var resultado = idade >= 18 ? "Elegível" : "Não Elegível";
    return resultado;
}

// Verificar Bônus (salario final menor que 2000)
string VerificarBonus(decimal salarioFinal)
{
    var resultado = salarioFinal >= 2000 ? "Recebe Bonus" : "Não recebe bonus";
    return resultado;
}

//  -> Junior(menor que 2000),
//  -> Pleno(maior 2000 e menor 10000) 
//  -> Senior( maior ou igual  10.000)

string VerificarNivelTecnico(decimal salarioFinal)
{
    string resultado;

    if(salarioFinal < 2000)
    {
        resultado = "Junior";
    }
    if(salarioFinal >=2000 && salarioFinal < 10000)
    {
        resultado = "Pleno";
    }
    else
    {
        resultado = "Senior";
    }
    return resultado;
}

