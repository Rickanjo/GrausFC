// Converta uma temperatura digitada pelo usuário em °F para °C.


double tempF;
double tempC;

Console.WriteLine("---Conversor de °F para °C\n");

Console.Write("Digite a temperatura em °F:");
tempF = Convert.ToDouble(Console.ReadLine()!);

tempC = tempF - 32 / 1.8;
 
Console.WriteLine($"A temperatura em Celsius é: {tempC:F2} °C");