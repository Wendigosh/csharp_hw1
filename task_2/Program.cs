// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


string num_1 = Console.ReadLine();
string num_2 = Console.ReadLine();
string num_3 = Console.ReadLine();
int num1 = int.Parse(num_1);
int num2 = int.Parse(num_2);
int num3 = int.Parse(num_3);

if (num1 < num2)
{
    num1 = num2;
}
if (num1 < num3)
{
    num1 = num3;
}

Console.Write($"Число {num1} является максимальным из представленных");