// Задать массив вещественных чисел. Найти разницу между максимальным и минимальным
// элементов массива. Диапазон [-10, 10]

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double [] Arr = new double [n];
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    Arr[i] = rnd.Next(-10, 10);
    Console.Write($"{Arr[i]}");
}
int min = 0;
int max = 0;
foreach (int i in Arr)
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"Минимальный элемент массива: {min}. Максимальный элемент массива: {max}");
Console.WriteLine($"Разница между минимальным и максимальным элементов массива: {max-min}");