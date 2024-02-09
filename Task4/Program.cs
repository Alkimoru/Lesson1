Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
while (a > 0)
{
    b = a % 10;
    a = a / 10;
    Console.Write(b + ", ");
}