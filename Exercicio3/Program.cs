// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n-----------\nEXERCÍCIO 3\n-----------");
int horasTrab;
double valorHora, salario;

Console.Write("\nInsira o número de horas trabalhadas: ");
horasTrab = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira o valor que recebe por hora: ");
valorHora = Convert.ToDouble(Console.ReadLine());
salario = horasTrab * valorHora;
Console.WriteLine($"O valor do salário é: R$ {salario.ToString("F")}.");