//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число > ");
string inputN = Console.ReadLine();
int valueN = Convert.ToInt32(inputN);

int index = 0;
while(index<valueN)
{
    Console.WriteLine(index+1);
    index++;
}