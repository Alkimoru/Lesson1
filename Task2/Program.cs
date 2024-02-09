Console.WriteLine("Введите X координату: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = 0;
if (x == 0)
{
    Console.Write("Значение X должно быть отлично от нуля");
}
else
{
Console.WriteLine("Введите Y координату: ");
y = Convert.ToInt32(Console.ReadLine());
if (y == 0)
{
    Console.Write("Значение Y должно быть отлично от нуля");
}
}
if (x > 0 && y > 0)
{
    Console.Write("Точка находится в 1 координатной четверти");
}
if (x < 0 && y > 0)
{
    Console.Write("Точка находится во 2 координатной четверти");
}
if (x < 0 && y < 0)
{
    Console.Write("Точка находится в 3 координатной четверти");
}
if (x > 0 && y < 0)
{
    Console.Write("Точка находится в 4 координатной четверти");
}