// //3. Сумма элементов
using System.ComponentModel.DataAnnotations;

int[] scores = { 60, 80, 40, 80, 90 };
int SumArray(int[] numbers)
{
    int sum = 0;

    foreach (int number in numbers)
    {
        sum += number;
    }

    return sum;
}
Console.WriteLine(SumArray(scores));

// //ошибка 3
// int SumArray(int[] numbers)
// {
//     int sum = 0;

//     foreach (int number in numbers)
//     {
//         sum += number;
//     }

//     return sum;
// }
// Console.WriteLine(SumArray(new int[] { 5, -2, 7 }));


// //4. Подсчёт элементов по условию
int CountAtLeast(int[] numbers, int limit)
{
    int count = 0;

    foreach (int number in numbers)
    {
        if (number >= limit)
        {
            count++;
        }
    }

    return count;
}
Console.WriteLine(CountAtLeast(scores, 50));

// //ошибка 4
// int CountAtLeast(int[] numbers, int limit)
// {
//     int count = 0;

//     foreach (int number in numbers)
//     {
//         if (number >= limit)
//         {
//             count += 1;
//         }
//     }

//     return count;
// }
// Console.WriteLine(CountAtLeast(new int[] { 40, 50, 80 }, 50));

//5. Минимум и максимум
int FindMax(int[] numbers)
{
    int max = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }

    return max;
}
Console.WriteLine($"Максимум: {FindMax(scores)}");

int FindMin(int[] numbers)
{
    int min = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;
}
Console.WriteLine($"Минимум: {FindMin(scores)}");

// //ошибка 5
// int FindMin(int[] numbers)
// {
//     int min = numbers[0];

//     for (int i = 1; i < numbers.Length; i++)
//     {
//         if (numbers[i] < min)
//         {
//             min = numbers[i];
//         }
//     }
//     return min;
// }
// Console.WriteLine(FindMin(new int[] { 12, 4, 9 }));
