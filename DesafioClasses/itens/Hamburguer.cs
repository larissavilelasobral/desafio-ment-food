class Hamburguer
{
  public string nomeProduto = "X-Tudo";
  public string categoriaProduto = "Comida";
  public double valorProduto = 6.50;

  public void ExibirDados()
  {
    Console.WriteLine($"1. {nomeProduto} | Preço: {valorProduto} |");
  }
}
