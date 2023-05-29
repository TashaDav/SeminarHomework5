//Задайть одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] randomArr = new int[n];

void mas(int n)
{
for (int i = 0; i < n; i++)
{
randomArr[i] = new Random().Next(1,20);
Console.Write(randomArr[i] + " ");
}

}

int element(int[] randomArr)
{
int sum = 0;
int i = 1;
while (i < randomArr.Length)
{
sum = sum + randomArr[i];
i = i + 2;
}
return sum;
}

mas(n);
Console.Write($"Cумма элементов на нечётных позициях =  {element(randomArr)}");