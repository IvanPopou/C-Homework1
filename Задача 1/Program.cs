//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите число a > ");
string inputA = Console.ReadLine();
Console.Write("Введите число b > ");
string inputB = Console.ReadLine();
int valueA = Convert.ToInt32(inputA);
int valueB = Convert.ToInt32(inputB);

if (valueA>valueB)
{
    System.Console.WriteLine($"Число a больше числа b");
}
else if (valueA<valueB)
{
    System.Console.WriteLine($"Число a меньше числа b");
}
else if (valueA==valueB)
{
    System.Console.WriteLine($"Числа a и b равны");
}

