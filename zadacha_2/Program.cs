/*Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница
*/
Console.WriteLine("Введите номер дня недели");
int data = int.Parse(Console.ReadLine());
if (data == 1)
{
    Console.WriteLine("Понедельник");
}
if (data == 2)
{
    Console.WriteLine("Вторник");
}
if (data == 3)
{
    Console.WriteLine("Среда");
}
if (data == 4)
{
    Console.WriteLine("Четверг");
}
if (data == 5)
{
    Console.WriteLine("Пятница");
}
if (data == 6)
{
    Console.WriteLine("Суббота");
}
if (data == 7)
{
    Console.WriteLine("Воскресенье");
}
if (data > 7)
{
    Console.WriteLine("Неверно");
}
if (data < 1)
{
    Console.WriteLine("Неверно");
}