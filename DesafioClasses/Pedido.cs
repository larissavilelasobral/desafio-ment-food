class Pedido // nome da classe
{
  private double valor;
  private string cliente;
  private string endereco;
  private string itens; // (máximo de 3).

  public Pedido(string cliente, string endereco, string itens)
  {
    this.cliente = cliente;
    this.endereco = endereco;
    this.itens = itens;
  }

  public string Cardapio(string numero)
  {
    string nomePedido = "";
     
    switch (numero)
    {
      case "1":
        nomePedido = "X-Tudo";
        this.valor = 6.50;
        break;
      case "2":
        nomePedido = "Batata";
        this.valor = 4.00;
        break;
      case "3":
        nomePedido = "Coca-Cola";
        this.valor = 5.00;
        break;
      case "4":
        nomePedido = "Pepsi Cola";
        this.valor = 3.50;
        break;
      default:
        break;
    }
    return nomePedido;
  }

  public void ResumoPedio(string nomePedido)
  {
    Console.WriteLine("------------");
    Console.WriteLine("Resumo do Pedido: \n Cliente: {0} \n Endereço: {1} \n Itens: {2} \n Total: R$ {3}", this.cliente, this.endereco, nomePedido, this.valor);
    Console.WriteLine("------------");
  }
}