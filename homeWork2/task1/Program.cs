/*Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа*/
Random rand = new Random();
int num = rand.Next(100,1000);
System.Console.WriteLine(num);
    int num1 = num / 100;
    int num3 = num % 10; 
    int num2 = (num - num1*100 - num3) / 10;
    System.Console.WriteLine(num2);