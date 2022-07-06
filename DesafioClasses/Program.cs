class Principal
{
  static void Main(string[] args)
  {

    string cliente = "";
    string endereco = "";
    string[] itens = new string[3];

    Pedido novoPedido = new Pedido(itens);

    Console.WriteLine("Bem Vindo ao UaiFood!");
    Console.WriteLine("Digite seu nome: ");
    cliente = Console.ReadLine() ?? string.Empty;
    Console.WriteLine("------------");

    Console.WriteLine("Digite seu Enderço: ");
    endereco = Console.ReadLine() ?? string.Empty;
    Console.WriteLine("------------");

    Console.WriteLine("O que gostaria de pedir? ");
    novoPedido.Menu();

    for (var i = 0; i < 3; i++)
    {
      itens[i] = Console.ReadLine() ?? string.Empty;
    }

    novoPedido.ResumoPedio(cliente, endereco);
  }
}

//---
// cliemte passa as informações para a entrega;
// mostrar menu numerado de pedidos;
// o cliente escolhe um numero
// cliente informa quel itens quer pedir;
// é calculado o valor total dos itens;
// é retornado o valor total do pedido para o cliente;

//----------------------------------------------------------------//
//Lorena é proprietária de uma franquia de fast food e quer disponibilizar para seus franqueados um sistema de pedidos online. O sistema idealizado por ela deverá trabalhar com informações de pedidos de clientes, como valor total do pedido, cliente, endereço de entrega e os itens selecionados (máximo de 3).

//Te desafiamos a criar uma composição de classes que poderá ser usada no desenvolvimento do sistema da Lorena. Vamos ao desafio?