/*
Поэлементное копирование массива
*/


int[] FillArrayRandom(int tmpLength, int tmpMin, int tmpMax)
{
    int[] tmpArray = new int[tmpLength];
    Random randnum = new Random();

    for (int i = 0; i < tmpArray.Length; i++)
    {
        tmpArray[i] = randnum.Next(tmpMin, tmpMax + 1);
    };

    return tmpArray;
}

void PrintArray(int[] tmpArray)
{
    Console.WriteLine($"[" + string.Join(", ", tmpArray) + "]");
}

int[] CopyArray(int[] ArrayToCopy)
{
    int[] resultArray = new int[ArrayToCopy.Length];
    for (int i =0; i< ArrayToCopy.Length; i++)
    {
        resultArray[i] = ArrayToCopy[i];
    }
    return resultArray;
}

int[] array1 = FillArrayRandom(10, -100, 100);
int[] array2 = CopyArray(array1);
//array1[0] = 300;
PrintArray(array1);
PrintArray(array2);