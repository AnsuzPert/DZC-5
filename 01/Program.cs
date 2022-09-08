/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
int[]funcranmas ()
{
Console.WriteLine("ВВедите размер массива");
int s = Convert.ToInt32(Console.ReadLine());
int [] mas = new int[s];
for (int i=0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(100,1000);
    Console.Write (mas[i]+" ");
}
Console.WriteLine();
return mas;
}
int[]mass = funcranmas();
int kolchet (int[]mas )
{
    int sum = 0;
    foreach(int i in mas)
    {
        if (i%2==0) sum++;
    }
    return sum;
}
Console.WriteLine(kolchet(mass));