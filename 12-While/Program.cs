// Crie um algoritmo que receba números inteiros e enha como operador as opções + , - , * , / . (Método Soma, Método Subtração, Método Multiplicação, Método Divisão.

using _12_While;

Console.WriteLine("Deseja continuar operando? Digite S para SIM e N para NÃO");
var entrada = Console.ReadLine();
int total = 0;

Console.WriteLine("Informe um número:");
int primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe um segundo número:");
int segundoNumero = Convert.ToInt32(Console.ReadLine());

while (entrada == "S")
{
    Console.WriteLine("Digite o operador:");
    entrada = Console.ReadLine();

    if (entrada == "+") 
    {
        total = Calculadora.Somar(primeiroNumero, segundoNumero);
    }

   if (entrada == "-")
    {
        total = Calculadora.Diminuir(primeiroNumero, segundoNumero);
    }

   if (entrada == "*")
    {
        total = Calculadora.Multiplicar(primeiroNumero, segundoNumero);
    }

   if (entrada == "/")
    {
        total = Calculadora.Dividir(primeiroNumero, segundoNumero);
    }

    Console.WriteLine("O total é: " + total);

    Console.WriteLine("Deseja contiuar operando? Digite S para SIM e N para NÃõ.");
    Console.ReadLine();
}




