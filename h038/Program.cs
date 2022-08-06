// Создаем массив
int lenArray = new Random().Next(5,15);
int[] array = new int[lenArray];

//Заполнение массива
void FillArr(int[] coll)
{
    int i = 0;
    while(i < coll.Length)
    {
        coll[i] = new Random().Next(1, 20);
        i++;
    }
    Console.WriteLine("[{0}]", string.Join(", ", coll));
}

// Считает разницу максимального и минимального элемента массива
int MinMaxNumbers (int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }
    Console.WriteLine($"{max} - {min}");
    return max-min;
}

FillArr(array);
Console.WriteLine($"{MinMaxNumbers(array)}");

