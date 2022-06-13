// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n-----------\nEXERCÍCIO 5\n-----------");
double real, dolar, euro, libraEst, dolarCan, pesoArg, pesoChil;
Console.Write("\nInsira um valor em Real R$ ");
real = Convert.ToDouble(Console.ReadLine());
dolar = real / (4.87);
euro = real / (5.21);
libraEst = real / (6.13);
dolarCan = real / (3.89);
pesoArg = real / (0.040);
pesoChil = real / (0.0059);
//Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine($"Valor em Dólar: $ {dolar.ToString("F")}" +
    $"\nValor em Euro: € {euro.ToString("F")}" +
    $"\nValor em Libra Esterlina: £ {libraEst.ToString("F")}" +
    $"\nValor em Dólar Canadense: $ {dolarCan.ToString("F")}" +
    $"\nValor em Peso Argentino: $ {pesoArg.ToString("F")}" +
    $"\nValor em Peso Chileno: $ {pesoChil.ToString("F")}");