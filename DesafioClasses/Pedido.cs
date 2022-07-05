class Pedido // nome da classe
{
  private double valor;
  private string cliente;
  private string endereco;
  private string[] itens; // (máximo de 3).

  public Pedido(string cliente, string endereco, string[] itens)
  {
    this.cliente = cliente;
    this.endereco = endereco;
    this.itens = itens;
  }

  public string nomeItem(string numero)
  {
    string nomeItem = "";

    switch (numero)
    {
      case "1":
        nomeItem = "X-Tudo";
        break;
      case "2":
        nomeItem = "Batata";
        break;
      case "3":
        nomeItem = "Coca Cola";
        break;
      case "4":
        nomeItem = "Pepsi Cola";
        break;
      default:
        break;
    }
    return nomeItem;
  }

  public double Cardapio(string numero)// metodo
  {
    double valorItem = 0;

    switch (numero)
    {
      case "1":
        valorItem = 6.50;
        break;
      case "2":
        valorItem = 4.00;
        break;
      case "3":
        valorItem = 5.00;
        break;
      case "4":
        valorItem = 3.50;
        break;
      default:
        break;
    }
    
    return valorItem;
  }

  public void ResumoPedio(string nomePedido)
  {
    Console.WriteLine("------------");
    Console.WriteLine("Resumo do Pedido: \n Cliente: {0} \n Endereço: {1} \n Itens: {2} \n Total: R$ {3}", this.cliente, this.endereco, nomePedido, this.valor);
    Console.WriteLine("------------");
  }

  public void ResumoPedio()
  {

    List<string> nomes = new List<string>();

    foreach (string item in this.itens)
    {
      string valor = nomeItem(item);
      nomes.Add(valor);
    }

    double valores = 0;

    foreach (string item in this.itens)
    {
      double valor = Cardapio(item);
      valores += valor;
    }

    Console.WriteLine("Resumo do Pedido: \n Cliente: {0} \n Endereço: {1} \n Itens: {2} \n Total: R$ {3}", this.cliente, this.endereco, String.Join(" - ", nomes), valores);
  }
}