/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[]funcranmas ()
{
Console.WriteLine("ВВедите размер массива");
int s = Convert.ToInt32(Console.ReadLine());
double [] mas = new double[s];
Console.WriteLine("введите элементы массива");
for (int i=0; i < mas.Length; i++)
{
    mas[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine();
return mas;
}
double[]mass = funcranmas();
string kolchet (double[]mas )
{
    double sum = 0;
    double max = mas[0];
    double min = mas[0];
    foreach(double i in mas)
    {
        if (i>max ) max = i;
        else if (i<min)min = i;
        Console.Write (i+" ");
    }
    Console.WriteLine();
    sum = max - min;
    return ($"Разница между максимумом и минимумом {sum}");
}
Console.WriteLine(kolchet(mass));