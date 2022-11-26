//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите число > ");
string inputA = Console.ReadLine();
int valueA = Convert.ToInt32(inputA);

if (valueA % 2==0) 
{
    System.Console.WriteLine($"Число {valueA} четное");
}
else 
{
    System.Console.WriteLine($"Число {valueA} нечетное");
}