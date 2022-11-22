/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8

*/
Console.WriteLine("Введите число");
int N1 = int.Parse(Console.ReadLine());
if (99 < N1 && N1 < 1000)
{
    int N2 = N1%10;
    Console.WriteLine(N2);
}
else
{
    Console.WriteLine( "Число не трехзначное");
}
