// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int num;
Boolean cont = true;
while (cont)
{
    System.Console.WriteLine("Введи любое число что бы получить таблицу кубов до него!");
    num = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= num; i++) Console.Write(Math.Pow(i, 3) + " ");
    System.Console.WriteLine("\nЕсли хотите продолжить напишите Yes/No");
    string next = Console.ReadLine();
    cont = next.ToLower() == "yes" ? true : false;
}


