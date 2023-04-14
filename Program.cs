double devidendo, divisor, quociente;

Console.WriteLine("== Divisão ==");

Console.Write("Digite o devidendo: ");
devidendo = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o divisor: ");
divisor = Convert.ToDouble(Console.ReadLine());
 
bool invalido = divisor == 0;
if (invalido)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("Não é possível fazer a divisão por zero. ");
    Console.ResetColor();
}
else
{
quociente = devidendo / divisor;
Console.WriteLine($" O resultado da divisao entre {devidendo:N1} por {divisor:N1} é: {quociente:N1}.");
}