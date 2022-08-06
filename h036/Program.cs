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

// Счетчик четных чисел
int SumNechetNumbers (int[] array)
{
    int num = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        num += array[i];
    }
    return num;
}

FillArr(array);
Console.WriteLine($"Сумма эллементов на нечетных позициях = {SumNechetNumbers(array)}");

