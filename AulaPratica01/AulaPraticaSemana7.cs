namespace AulaPratica01
{
    public class AulaPraticaSemana7
    {
        public static void Executar()
        {
            //Exemplo de for usando ....
            for (int i = 10; i != 0; i--)
            {
                Console.WriteLine(i);
            }
            var clientes = new List<string>();
            var quantidades = new List<int>();

            var executando = true;

            while (executando)
            {
                Console.Clear();

                Console.WriteLine("=========================");
                Console.WriteLine("LANCHONETE DO BAIRRO");
                Console.WriteLine("=========================");
                Console.WriteLine("1 - Novo Pedido");
                Console.WriteLine("2 - Listar Pedidos");
                Console.WriteLine("3 - Buscar Pedido");
                Console.WriteLine("4 - Verificar Prioridade");
                Console.WriteLine("5 - Encerrar");
                Console.WriteLine();

                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine("Opção inválida");
                    Pausar();
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        NovoPedido();
                        break;

                    case 2:
                        ListarPedidos();
                        break;

                    case 3:
                        BuscarPedido();
                        break;

                    case 4:
                        VerificarPrioridade();
                        break;

                    case 5:
                        executando = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        Pausar();
                        break;
                }
            }

            void VerificarPrioridade()
            {
                Console.Clear();

                if (clientes.Count == 0)
                {
                    Console.WriteLine("Nenhum pedido cadastrado.");
                    return;
                }

                for (int i = 0; i < clientes.Count; i++)
                {
                    Console.WriteLine($"Cliente: {clientes[i]}");

                    if (quantidades[i] > 5)
                    {
                        Console.WriteLine("Pioridade: Pedido Grande");
                    }
                    else
                    {
                        Console.WriteLine("Pioridade: Pedido Normal");
                    }

                    Console.WriteLine();
                }

                Pausar();
            }

            void NovoPedido()
            {
                Console.Clear();

                OpcoesDoCardapio();

                Console.Write("Nome do cliente: ");
                var nome = Console.ReadLine();

                Console.Write("Quantidade de itens: ");

                if (!int.TryParse(Console.ReadLine(), out int quantidade))
                {
                    Console.WriteLine("Quantidade inválida");
                    return;
                }

                clientes.Add(nome);
                quantidades.Add(quantidade);
                Console.WriteLine();
                Console.WriteLine("Pedido cadastrado com sucesso!");

                Pausar();
            }

            void OpcoesDoCardapio()
            {
                Console.WriteLine("=========================");
                Console.WriteLine("LANCHONETE DO BAIRRO");
                Console.WriteLine("=========================");
                Console.WriteLine("1 - Hamburguer");
                Console.WriteLine("2 - Cachorro-quente");
                Console.WriteLine("3 - Pizza");
                Console.WriteLine("4 - Encerrar");
                Console.WriteLine();

                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine("Opção inválida");
                    Pausar();
                }

                switch (opcao)
                {
                    case 1:
                        clientes.Add("Hamburguer");
                        break;

                }
            }

            void ListarPedidos()
            {
                Console.Clear();

                Console.WriteLine("PEDIDOS CADASTRADOS");
                Console.WriteLine();

                if (clientes.Count == 0)
                {
                    Console.WriteLine("Nenhum pedido cadastrado.");
                    return;
                }

                int contador = 1;

                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"{contador} - {cliente}");
                    contador++;
                }

                Pausar();
            }

            void BuscarPedido()
            {
                Console.Clear();

                Console.Write("Digite o nome do cliente: ");
                string nome = Console.ReadLine();

                bool encontrado = false;
                foreach (var cliente in clientes)
                {
                    if (cliente.ToLower() == nome.ToLower())
                    {
                        encontrado = true;
                        break;
                    }
                }

                Console.WriteLine();

                if (encontrado)
                {
                    Console.WriteLine("Pedido encontrado");
                }
                else
                {
                    Console.WriteLine("Pedido não encontra");
                }

                Pausar();
            }

            void Pausar()
            {
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
            }

        }
    }
}
