Console.WriteLine("Введите число");

string input = Console.ReadLine();

int N = Convert.ToInt32(input);

int number = 2;

while (number < N + 1)
{
  Console.Write(number + "|" );
  number = number + 2 ; 
}


