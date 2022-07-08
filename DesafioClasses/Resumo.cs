class Resumo
{
  private string cliente;
  private string endereco;
  private string[] itens;
  private double valor;

  public Resumo(string cliente, string endereco, string[] itens)
  {
    this.cliente = cliente;
    this.endereco = endereco;
    this.itens = itens;
  }

  public void valorTotal()
  {
    double valores = 0;

    foreach (string item in this.itens)
    {
      Pedido pedido = new Pedido(cliente, endereco, itens);

      double valorItem = pedido.RetornaValorItem(item);
      valores += valorItem;
    }

    this.valor = valores;
  }

  public void NomeItem()
  {
    List<string> nomes = new List<string>();

    foreach (string item in this.itens)
    {
      Pedido pedido = new Pedido(cliente, endereco, itens);

      string nomeItem = pedido.RetornaNomeItem(item);
      nomes.Add(nomeItem);
    }
    string[] nomesArray = nomes.ToArray();

    this.itens = nomesArray;
  }

  public void Exibir()
  {
    Console.WriteLine("Resumo do Pedido: \n Cliente: {0} \n Endereço: {1} \n Itens: {2} \n Total: R$ {3}", this.cliente, this.endereco, String.Join(" - ", this.itens), this.valor);
  }
}


// class Resumo : Pedido
// {

//   //nome
//   //endereco
//   //Itens
//   //valor total

//   public Resumo(string cliente, string endereco, string[] itens) : base(cliente, endereco, itens)
//   {

//   }
//   //exibir 
//   public void Exibir()
//   {
// foreach (string item in this.itens)
// {
//   Pedido pedido = new Pedido(cliente, endereco, itens);

//   string nomeItem = pedido.RetornaNomeItem(item);
//   nomes.Add(nomeItem);
// }

//     Console.WriteLine("Resumo do Pedido: \n Cliente: {0} \n Endereço: {1} \n Itens: {2} \n Total: R$ {3}", this.cliente, this.endereco, String.Join(" - ", nomes), valores);
//   }
// }