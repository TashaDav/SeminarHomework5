/*
 Задать массив заполненный случайными положительными трёхзначными числами. Написать программу,
 которая покажет количество чётных чисел в массиве.
 [345, 897, 568, 234] -> 2.
 */

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] randomArr = new int[n];

for (int i = 0; i < n; i++)
{
    randomArr[i] = new Random().Next(999);
    Console.Write(randomArr[i] + " ");
}
int element(int[] randomArr)
{
    int element = 0;
    for(int i = 0; i < randomArr.Length; i++)
    {
        if(randomArr[i] % 2 ==0)
        element = element + 1;
    }
    return element;
}
Console.WriteLine($"Количество четных элементов в массиве: {element(randomArr)}");

//Не до конца выполнено условие, т.к. не задан вывод именно трехзначных цифрами массива.
