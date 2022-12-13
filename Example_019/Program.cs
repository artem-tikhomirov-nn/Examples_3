// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
Boolean cont = true;
while (cont)
{
    string text = Console.ReadLine();
    char[] revtext = text.ToCharArray();
    if (revtext.Length - 1 == 4)
    {
        Array.Reverse(revtext);
        string finaltext = new string(revtext);
        string result = text == finaltext ? "Палиндром" : "Не палиндром";
        Console.WriteLine(result);
        Console.WriteLine("Продолжим(Yes/No) ?");
        string next = Console.ReadLine();
        cont = next.ToLower() == "yes" ? true : false;
    }
    else
    {
        Console.WriteLine("Вы ввели не верное значение, необходимо пятизначное.");
    }
}
