Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0)
{
Console.Write("Число кратно 7 и 23");
}
else 
{
    Console.Write("Число не кратно 7 и 23");
}