/*// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

int Trex(int x)
{
    int des = x/10;
    int second = des%10;
    return second;

}
//int a = new Random().Next(100,1000);
//Console.WriteLine($" дано число {a}");
Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int d = Trex (a);
Console.WriteLine($"Второе число {d}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//метод поиска первых трех цифр слева
int T(int x)
{
while (x/10 >= 100)
{
    x = x/10;
    
}
return x ;
}
//метод поиска третьего числа из первых трех цифр слева
int Tri(int x)
{
    int a = x%10;
    return a;
}

 Console.WriteLine("введите число n: ");  
int n = Convert.ToInt32(Console.ReadLine());
if (n>=100)
{
int N = T(n);
Console.WriteLine($"это первые три цифры {N} ");
int A= Tri (N);
Console.WriteLine($"третья цифра: {A} ");
}
else 
{
    Console.WriteLine("третьей цифры нет"); 
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет


void Den (int a)
{
    if ((a==7) && (a==6))
    {
        Console.WriteLine("да");
    }
    else {
        Console.WriteLine("нет");
    }
}
Console.WriteLine("Введите число дня недели от 1 до 7");
int x = Convert.ToInt32(Console.ReadLine());

Den(x);


