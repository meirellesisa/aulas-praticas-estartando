using System.Collections;
namespace AulaPratica01
{
    public class AulaPraticaSemana6
    {
        public static void Executar()
        {
            // Aula Prática Estrutura de dado
            //1.ArrayList->usa indice
            //Uma integração com um sistema legado retornou os dados de um usuário.
            //Após o cadastro, foi necessário corrigir a idade informada.


            var dadosUsuario = new ArrayList();
            dadosUsuario.Add("Isabella Meirelles"); // indice 0
            dadosUsuario.Add(25);                   // indice 1
            dadosUsuario.Add("Rio de Janeiro");     // indice 2

            dadosUsuario[1] = 26;

            dadosUsuario.Remove("Rio de Janeiro");
            dadosUsuario.RemoveAt(1);
            foreach (var item in dadosUsuario)
            {
                Console.WriteLine(item);
            }


            //2. ArrayTipado -> usa indice 
            //Uma empresa registrou as vendas da semana, mas um valor
            //foi lançado incorretamente e precisou ser corrigido.

            int[] vendas = { 100, 250, 300, 150, 400 };

            vendas[0] = 350;

            foreach (var item in vendas)
            {
                Console.WriteLine(item);
            }


            // 3. Lista Genérica  -> usa indice
            //Uma equipe de desenvolvimento possui uma lista de projetos ativos.
            //Um projeto foi cancelado e outro mudou de nome.

            var projetos = new List<string>();

            projetos.Add("Sistema Financeiro"); // indice 0
            projetos.Add("Portal do Cliente"); // indice 1 
            projetos.Add("Aplicativo Mobile"); // indice 2

            projetos[1] = "Portal do Cliente V2";

            projetos.Remove("Aplicativo Mobile");

            foreach (var item in projetos)
            {
                Console.WriteLine(item);
            }

            // 4. Dicionário -> usa chave-valor
            //Um catálogo de produtos possui código e descrição.
            //Um produto mudou de descrição e outro saiu do catálogo.

            Dictionary<int, string> produtos = new Dictionary<int, string>();
            var produtos2 = new Dictionary<int, string>();

            produtos.Add(1, "Notbook");
            produtos.Add(100, "Mouse");
            produtos.Add(4, "Teclado");

            produtos[100] = "Teclado Mecânico";

            produtos.Remove(4);

            foreach (var item in produtos)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            //Dictionary<string, string> produtos2 = new Dictionary<string, string>();
            //produtos2.Add("A001", "Geladeira");
            //produtos2.Add("A003", "Fogão");

            //produtos2["A003"] = "Maquina de Lavar";
            foreach (var item in produtos2)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Dictionary<string, bool> produtos3 = new Dictionary<string, bool>();


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

        }
    }
}
