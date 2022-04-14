Console.Write("Введите первое число :");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число :");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number == number_2) 
{
    Console.WriteLine("Числа равны");
}
else if  (number < number_2) 
    Console.WriteLine(number_2);
else 
    Console.WriteLine(number);