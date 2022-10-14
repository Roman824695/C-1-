Console.WriteLine("Введите число чтобы узнать четное или не четное");

string input = Console.ReadLine();

int number = Convert.ToInt32(input);

if (number % 2 == 0)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
