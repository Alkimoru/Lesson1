Random rand = new Random();
int a = rand.Next(10, 100);
Console.WriteLine("Сгенерированное число - " + a);
int c = a / 10;
Console.WriteLine("Первая цифра - " + c);
int b = a % 10;
Console.WriteLine("Вторая цифра - " + b);
if (b > c)
{
    //Console.Write(b);
    Console.Write("В числе " + a + "большая цифра - " + b);
}
else
{
    //Console.Write(c);
    Console.Write("В числе " + a + " большая цифра - " + c);
}