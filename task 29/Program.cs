//  Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());

}
int []GenArray(int Length,int min ,int max)
{
    int[] array=new int[Length];
Random rand=new Random();
for (int i = 0; i < Length; i++)
{
    array[i]=rand.Next(min,max+1);
}
return array;
}
void PrintArray(int[]array){

    System.Console.WriteLine("[" + string.Join(",",array)+ "]");
}
int Length = ReadInt("введите длину массива");
int min = ReadInt("введите минимальное значение элемента массива");
int max = ReadInt("введите максимальное значение массива");
int [] array=GenArray(Length,  min , max);
PrintArray(array);