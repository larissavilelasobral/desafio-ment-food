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
    Item hamburguer = new Item("hamburguer",5.00);
    Item batata = new Item("batata",3.00);
    Item coca = new Item("Coca-Cola",1.00);
    Item pepsi = new Item("Pepsi Cola",2.00);

    Item chocolate = new Item("Chocolate", 12.00);
    Item chocolateBranco = new Item("Chocolate Branco", 11.00);
    Item suco = new Item("suco", 3.00);

    List<Item> itensKids = new List<Item>();
    itensKids.Add(chocolate);
    itensKids.Add(chocolateBranco);
    itensKids.Add(suco);

    List<Item> itens = new List<Item>();
    itens.Add(hamburguer);
    itens.Add(batata);
    itens.Add(coca);
    itens.Add(pepsi);

    Cardapio menuKids = new Cardapio(itensKids);
    menuKids.Exibir();
    Cardapio menu = new Cardapio(itens);
    menu.Exibir();
    
    // Pedido novoPedido = new Pedido(cliente, endereco, itens);

    // for (var i = 0; i < 3; i++)
    // {
    //   itens[i] = Console.ReadLine() ?? string.Empty;
    // }
    
    
    // Resumo resumoPedido = new Resumo(cliente, endereco, itens);
    // resumoPedido.valorTotal();
    // resumoPedido.NomeItem();
    // resumoPedido.Exibir();


    // Console.WriteLine(novoPedido.valorTotal(itens));
    // Console.WriteLine(novoPedido.Valor);
  }
}

// classe recebe valores basicos
// hambu - batat-bab
// guardar no lista