// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.




Console.WriteLine("Введите первое число: ");
string input = Console.ReadLine();
int a = Convert.ToInt32(input);

Console.WriteLine("Введите второе число: ");
string input2 = Console.ReadLine();
int b = Convert.ToInt32(input2);



if (a > b)
{
    Console.WriteLine("Max" + " = " + a);
    Console.WriteLine("Min" + " = " + b);
}
 
else if (b > a)
{
       Console.WriteLine("Max" + " = " + b);
       Console.WriteLine("Min" + " = " + a);
}