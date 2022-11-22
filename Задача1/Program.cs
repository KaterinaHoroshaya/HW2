//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/* 456 -> 5
782 -> 8
918 -> 1 */

int randomNumber = new Random().Next(100,1000);
int firstDigit = randomNumber / 10; //45
int secondDigit = firstDigit % 10; //5

Console.WriteLine(randomNumber);

Console.WriteLine($"{secondDigit}");