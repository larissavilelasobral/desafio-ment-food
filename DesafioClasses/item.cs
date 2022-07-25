class Item 
{
  private string nome;
  private double valor;

  public Item(string nome, double valor)
  {
    this.nome = nome;
    this.valor = valor;
  }

  public void imprimirItem()
  {
    Console.WriteLine("nome: {0} valor: {1}", this.nome, this.valor);
  }
}