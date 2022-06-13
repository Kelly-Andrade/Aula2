// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n-----------\nEXERCÍCIO 2\n-----------");
int valor, soma = 0;

Console.Write("\nInsira 10 valores inteiros: ");

for (int i = 0; i < 10; i++)
{
    valor = int.Parse(Console.ReadLine());
    soma += valor;
}
Console.WriteLine("Resultado da soma dos valores inseridos: " + soma);