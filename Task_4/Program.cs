Console.Write("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
int startnubmer = 1;

while (startnubmer < number)
{
   
    if (startnubmer % 2 == 0)
    {
       Console.Write(startnubmer + ". " );
    }
    startnubmer++;
}
