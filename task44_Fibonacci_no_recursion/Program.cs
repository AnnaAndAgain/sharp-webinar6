/*
Не используя рекурсия,
выведите первые N чисел Фибоначчи.
Первые 2 числа: 0 и 1
N = 5 -> 0 1 1 2 3
N = 7 -> 0 1 1 2 3 5 8
*/

int ReadInt(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArraySpace(int[] tmpArray)
{
    Console.WriteLine($"[" + string.Join(" ", tmpArray) + "]");
}

int[] FibonacciFill(int len)
{
    int[] FiboArray = new int[len];
    FiboArray[0]=0;
    FiboArray[1]=1;
    for (int i = 2; i < len; i++)
    {
        FiboArray[i] = FiboArray[i-1] + FiboArray[i-2];
    }
    return FiboArray;
}

int N = ReadInt("Сколько чисел Фибоначчи вам вывести?");
int[] array = FibonacciFill(N);
PrintArraySpace(array);