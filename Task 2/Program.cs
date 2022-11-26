//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите число a > ");
string inputA = Console.ReadLine();
int valueA = Convert.ToInt32(inputA);
Console.Write("Введите число b > ");
string inputB = Console.ReadLine();
int valueB = Convert.ToInt32(inputB);
Console.Write("Введите число с > ");
string inputC = Console.ReadLine(); 
int valueC = Convert.ToInt32(inputC);

int max = valueA;

if (valueB>max) max = valueB;
if (valueC>max) max = valueC;

System.Console.WriteLine($"Максимальное число {max}");
