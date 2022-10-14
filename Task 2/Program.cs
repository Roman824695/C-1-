Console.WriteLine("Введите 3 числа");

string input = Console.ReadLine();

int a = Convert.ToInt32(input);

string input2 = Console.ReadLine();

int b = Convert.ToInt32(input2);

string input3 = Console.ReadLine();

int c = Convert.ToInt32(input3);

if (a > b && a > c)
{
    Console.Write(a);
}
else if (b > a && b > c)
{
    Console.Write(b);
}
else if ( c > a && c > b)
{
    Console.Write(c);
}