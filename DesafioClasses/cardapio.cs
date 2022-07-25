class Cardapio
{
  List<Item> listaItens;

  public Cardapio(List<Item> listaItens)
  {
    this.listaItens = listaItens;
  }

  public void Exibir()
  {
    for (var i = 0; i < this.listaItens.Count; i++)
    {
      this.listaItens[i].imprimirItem();
    }
  }
}