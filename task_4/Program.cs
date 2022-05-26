// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


string sN = Console.ReadLine();

int N = int.Parse(sN);
int a = 2;

while (a <= N)
{
    Console.Write($"{a} ");
    a += 2;

} 
