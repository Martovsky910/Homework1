Console.Write("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Делится на 2 без остатка");
}  
else
{
    Console.WriteLine("Не делится на 2 без остатка");
}