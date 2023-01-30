/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
1. Создать массив
2. Проверка на положительность чисел
3. Определить количество четных чисел
    3.1 Проверка на четность
    3.2 Вывод количества четных чисел в массиве
*/

Console.Clear();

int[] get_array(int size, int min_value, int max_value)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min_value, max_value + 1);
    }
    return res;
}



int proverka (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    } 
    return count;
}

void print(int result)
{
    Console.WriteLine($"В данном массиве {result} четных чисел");
}


void main()
{
    int[] array = get_array(8, 0, 1000);
    int result = proverka (array);
    Console.WriteLine(string.Join(",", array));
    print(result);
}

main();