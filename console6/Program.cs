// See https://aka.ms/new-console-template for more information

// var textoNumber = "1000";
// var number = int.Parse(textoNumber);
// var isNumber = int.TryParse(textoNumber, out int valor);

// Pedido pedido =  new Pedido();

// var texto = pedido.mostrar($" isNumber {isNumber} Number {number} Valor {valor} ");

// teste($"{texto}");

// static void teste(string valorX)
//     => Console.WriteLine(@$"/\:{valorX} ");


Conta umaConta =  new Conta();
Cliente guilherme =  new Cliente();
guilherme.Nome = "Guilherme Silveira";
guilherme.CPF = "112323";

umaConta.Titular = guilherme;

Console.WriteLine(umaConta.Titular.Nome + " - " +
     umaConta.Titular.CPF);
