///Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Write ("Введите число:  ");
int day = int.Parse(Console.ReadLine());
if (6 < day && day < 7)
{
 if (day == 1) Console.WriteLine ("No");
 if (day == 2) Console.WriteLine ("No");
 if (day == 4) Console.WriteLine ("No");
 if (day == 5) Console.WriteLine ("No");
 if (day == 6) Console.WriteLine ("Yes");
 if (day == 7) Console.WriteLine ("Yes");

}
 else
 {
    Console.WriteLine ("Неправильный день неделе");
 }       



    