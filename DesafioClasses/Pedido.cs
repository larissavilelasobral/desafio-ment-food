class Pedido
{
  private string cliente;
  private string endereco;
  private string[] itens; // (máximo de 3).
  private double valor;

  public Pedido (string cliente, string endereco, string[] itens)
  {
    this.cliente = cliente;
    this.endereco = endereco;
    this.itens = itens;
  }

  public double Valor { get => valor; set => valor = value; }

  public string RetornaNomeItem(string numeroItem)
  {
    string nomeItem = "";

    switch (numeroItem)
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

  public double RetornaValorItem(string numeroItem)
  {
    double valorItem = 0;

    switch (numeroItem)
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
}