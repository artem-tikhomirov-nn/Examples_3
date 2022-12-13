// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите значения для векторов А(aX aY aZ) и B(bX bY bZ).\nИспользуя разделитель(пробел или запятая)");
Boolean cont = true;
int result = 0;
while (cont)
{
    System.Console.WriteLine("Введите значение для вектора А:");
    string vectorA = Console.ReadLine();
    int[] vectorArrA = convertVector(vectorA);

    System.Console.WriteLine("Введите значение для вектора B:");
    string vectorB = Console.ReadLine();
    int[] vectorArrB = convertVector(vectorB);

    for (int i = 0; i < +3; i++)
    {
        int sum = Convert.ToInt32(Math.Pow((vectorArrA[i] - vectorArrB[i]), 2));
        result += sum;
        System.Console.WriteLine("A = " + vectorArrA[i] + " | " + " B = " + vectorArrB[i] + " | Sum = " + sum);
    }

    result = Convert.ToInt32(Math.Sqrt(result));
    System.Console.WriteLine("Резульат: " + result + "\nЕсли хотите продолжить напишите Yes/No");
    string next = Console.ReadLine();
    cont = next.ToLower() == "yes" ? true : false;

}

int[] convertVector(string vector)
{
    char[] charSeparators = new char[] { ',', ' ' };
    string[] vectorStr = vector.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
    if (vectorStr.Length != 3)
    {
        System.Console.WriteLine("Вы ввели не верное значение, должно быть 3 значения через разделитель");
    }
    int[] vectorInt = Array.ConvertAll(vectorStr, s => int.Parse(s));
    Console.WriteLine(String.Join(" ", vectorInt));
    return vectorInt;
}


// System.Console.WriteLine("A = " + " | " + a + " B = " + b + " | " + sum);