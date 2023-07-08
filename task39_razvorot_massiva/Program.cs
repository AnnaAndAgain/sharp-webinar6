/*
Разворачиваем массив неизвестной длины
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

// В новый массив
int[] ReverseArrayNew (int[] tmpArray)
{
    int[] resultArray = new int[tmpArray.Length];
    for (int i = 0; i < tmpArray.Length; i++)
    {
        resultArray[i] = tmpArray[tmpArray.Length-i-1];
    }
    return resultArray;
}

// В том же  массиве
int[] ReverseArraySame (int[] tmpArray)
{
    int tmpElem = 0;
    for (int i = 0; i < tmpArray.Length/2; i++)
    {
        tmpElem = tmpArray[i];
        tmpArray[i] = tmpArray[tmpArray.Length-i-1];
        tmpArray[tmpArray.Length-i-1] = tmpElem;
    }
    return tmpArray;
}

int[] array = FillArrayRandom(6, 0, 10);
PrintArray(array);
PrintArray(ReverseArrayNew(array));
System.Console.WriteLine();
int[] array2 = FillArrayRandom(6, 0, 10);
PrintArray(array2);
PrintArray(ReverseArraySame(array2));