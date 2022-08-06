// Создаем массив
int lenArray = new Random().Next(5,10);
int[] array = new int[lenArray];

//Заполнение массива
void FillArr(int[] coll)
{
    int i = 0;
    while(i < coll.Length)
    {
        coll[i] = new Random().Next(100, 1000);
        i++;
    }
    Console.WriteLine("[{0}]", string.Join(", ", coll));
}

// Счетчик четных чисел
int ChetNumbers (int[] array)
{
    int num = 0;
    int i = 0;
    while(i < array.Length)
    {
        if(array[i] % 2 == 0)
        {
            num++;
        }
        i++;
    }
    return num;
}

FillArr(array);
Console.WriteLine($"Четных чисел в данном массиве = {ChetNumbers(array)}");

