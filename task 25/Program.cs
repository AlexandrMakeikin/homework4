//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int result(int numberA, int numberB)

{
    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result *= numberA;
    }
    return result;
}
int numberA = ReadInt("введите число А: ");
int numberB = ReadInt("введите число B: ");
System.Console.WriteLine($"{numberA}  ^  {numberB} = {result( numberA,  numberB)} ");