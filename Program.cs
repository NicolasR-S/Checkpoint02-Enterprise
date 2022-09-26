using Checkpoint02.Entidades;
using Checkpoint02.Enums;

List<Produto> produtos = new List<Produto>();
List<Funcionario> funcionarios = new List<Funcionario>();
List<Pedido> pedidos = new List<Pedido>();


int opcao = 0;


do
{
    Console.WriteLine("1 - Cadastrar Produto");
    Console.WriteLine("2 - Cadastrar Funcionario");
    Console.WriteLine("3 - Efetuar Venda");
    Console.WriteLine("4 - Listar Produtos");
    Console.WriteLine("5 - Listar Funcionarios");
    Console.WriteLine("6 - Listar Pedidos");
    Console.WriteLine("7 - Calcular Pagamento de Funcionario");

    Console.WriteLine("8 - Sair");
    Console.Write("Opcao: ");

    opcao = int.Parse(Console.ReadLine());

    Console.Clear();

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Cadastrar Produto");
            Produto produto = new Produto();

            Console.Write("Id: ");
            produto.Id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Valor: ");
            produto.Valor = double.Parse(Console.ReadLine());

            produtos.Add(produto);
            break;

        case 2:
            Console.WriteLine("Cadastrar Funcionario");
            Console.Write("Qual o tipo de funcionario? (G)erente ou (V)endedor: ");
            String tipoFuncionario = Console.ReadLine();

            if(tipoFuncionario == "V")
            {
                Funcionario vendedor = new Funcionario();

                Console.Write("Nome: ");
                vendedor.Nome = Console.ReadLine();

                Console.Write("Matricula: ");
                vendedor.Matricula = Console.ReadLine();

                Console.Write("Salario: ");
                vendedor.Salario = double.Parse(Console.ReadLine());

                funcionarios.Add(vendedor);

            }
            if(tipoFuncionario == "G")
            {
                Funcionario gerente = new Funcionario();

                Console.Write("Nome: ");
                gerente.Nome = Console.ReadLine();

                Console.Write("Matricula: ");
                gerente.Matricula = Console.ReadLine();

                Console.Write("Salario: ");
                gerente.Salario = double.Parse(Console.ReadLine());

                funcionarios.Add(gerente);
            }




            break;

        case 3:
            Console.WriteLine("Efetuar Venda");
            Pedido pedido = new Pedido();

            Console.Write("Matricula do Funcionario: ");
            String idFuncionario = Console.ReadLine();

            pedido.Funcionario = funcionarios.Find(Funcionario => Funcionario.Matricula == idFuncionario);

            Console.Write("Quantos itens irão compor o pedido? ");
            int qtdItens = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdItens; i++)
            {
                ItemPedido item = new ItemPedido();

                Console.Write($"Id do Produto {i + 1}: ");
                int idProduto = int.Parse(Console.ReadLine());

                item.Produto = produtos.Find(produto => produto.Id == idProduto);
                item.Valor = item.Produto.Valor;

                Console.Write($"Quantidade do Produto {i + 1}: ");
                item.Quantidade = int.Parse(Console.ReadLine());

                // Console.Write("Informe a Matricula do Funcionario que efetuou a venda: ");
                //String NumeroMatricula = Console.ReadLine();



                Console.WriteLine(item.SubTotal());




               

                pedido.AdicionarItem(item);
                
            }
            
            
     





            pedido.DataPedido = DateTime.Now;
            pedido.Status = StatusPedido.Processando;

            pedidos.Add(pedido);

            break;

        case 4:
            Console.WriteLine("Listar Produtos");

            produtos.ForEach(produto =>
            {
                Console.WriteLine(produto);
            });

            break;

        case 5:
            Console.WriteLine("Listar Funcioario");

            funcionarios.ForEach(funcionario =>
            {
                Console.WriteLine(funcionario);
            });

            break;

        case 6:
            Console.WriteLine("Listar Pedidos");

            pedidos.ForEach(pedido =>
            {
                Console.WriteLine(pedido);
            });

            break;

    }

    Console.ReadKey();
    Console.Clear();
} while (opcao != 8);
