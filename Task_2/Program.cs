Console.Write("Введите первое число :");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число :");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число :");
int number_3 = Convert.ToInt32(Console.ReadLine());

int max = number;
if (max < number_2) 
{
   max = number_2;
}
if (max < number_3)
{
    max = number_3;
}
Console.WriteLine(max);