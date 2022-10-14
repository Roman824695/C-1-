// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");

string input = Console.ReadLine();

int N = Convert.ToInt32(input);

int number = 2;

while (number < N + 1)
{
  Console.Write(number + "|" );
  number = number + 2 ; 
}


