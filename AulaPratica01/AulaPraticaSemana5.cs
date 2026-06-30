namespace AulaPratica01
{
    public class AulaPraticaSemana5
    {
        public static void Executar()
        {
            //Sistema de Cadastro de Funcionário

            //Requisitos : Nome, Idade, Cargo, Salário, Quantidade de Horas Extras, Valor da hora extra
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

                if (salarioFinal < 2000)
                {
                    resultado = "Junior";
                }
                if (salarioFinal >= 2000 && salarioFinal < 10000)
                {
                    resultado = "Pleno";
                }
                else
                {
                    resultado = "Senior";
                }
                return resultado;
            }


            Console.WriteLine("Ola");


        }
    }
}
