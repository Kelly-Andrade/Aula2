// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n-----------\nEXERCÍCIO 4\n-----------");
int idade, meses, dias;

Console.Write("\nInsira sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());
meses = idade * 12;
dias = idade * 365;
Console.WriteLine($"Anos: {idade}\nMeses: {meses}\nDias: {dias}");