Console.WriteLine("Введите число");
int x=Convert.ToInt32(Console.ReadLine());
if(x<100)
{
    Console.WriteLine("Третьего числа нет");
    }
else
{
    while (x>1000)
    {
        x/=10;
    }

int result =x%10;

Console.WriteLine("Третья цифра"+result);}
