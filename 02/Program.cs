
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[]funcranmas ()
{
Console.WriteLine("ВВедите размер массива");
int s = Convert.ToInt32(Console.ReadLine());
int [] mas = new int[s];
for (int i=0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(-1000,1000);
    Console.Write (mas[i]+" ");
}
Console.WriteLine();
return mas;
}
int[]mass = funcranmas();
int kolchet (int[]mas )
{
    int sum = 0;
    for(int i=0; i<mas.Length;i++ )
    {
        if (i%2!=0) sum = sum + mas[i];
    }
    return sum;
}
Console.WriteLine(kolchet(mass));