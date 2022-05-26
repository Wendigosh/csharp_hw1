// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

string num_1 = Console.ReadLine();
string num_2 = Console.ReadLine();
int num1 = int.Parse(num_1);
int num2 = int.Parse(num_2);

if (num1 > num2)
{
    Console.Write($" Число {num1} больше чем  {num2}");
}
else if (num1 == num2)
{
    Console.Write($"Число {num1} равно числу {num2}");
}
else
{
    Console.Write($"Число {num2} больше числа {num1}");
}
