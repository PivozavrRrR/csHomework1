/*Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.*/
Console.Write("Enter number : ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);
if(num == 6 || num == 7)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}
