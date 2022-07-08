class Principal
{
  static void Main(string[] args)
  {
    Console.WriteLine("Bem Vindo ao UaiFood!");
    Console.WriteLine("Digite seu nome: ");
    string cliente = Console.ReadLine() ?? string.Empty;

    Console.WriteLine("Digite seu Enderço: ");
    string endereco = Console.ReadLine() ?? string.Empty;

    Console.WriteLine("O que gostaria de pedir? ");
    // class menu
    Hamburguer hamburguer = new Hamburguer();
    hamburguer.ExibirDados();

    Batata batataFrita = new Batata();
    batataFrita.ExibirDados();

    CocaCola coca = new CocaCola();
    coca.ExibirDados();
    
    PepsiCola pepsi = new PepsiCola();
    pepsi.ExibirDados();

    string[] itens = new string[3];
    Pedido novoPedido = new Pedido(cliente, endereco, itens);

    for (var i = 0; i < 3; i++)
    {
      itens[i] = Console.ReadLine() ?? string.Empty;
    }

    Resumo resumoPedido = new Resumo(cliente, endereco, itens);
    resumoPedido.valorTotal();
    resumoPedido.NomeItem();
    resumoPedido.Exibir();

    Console.WriteLine(novoPedido.Valor);
  }
}
