/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int tmp = num;
int digs = (int)Math.Log10(num) + 1;
if (digs < 3) Console.WriteLine("третьей цифры нет");
else
{
    tmp = num / (int)Math.Pow(10, digs - 3);
    num = tmp % 10;
    Console.WriteLine(num);
}
