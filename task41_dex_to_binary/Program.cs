/*
Превратить десятичное число в двоичное
44 - 101100
3 - 11
2 - 10
*/

int ReadInt(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

/* решение без рекурсии
void DexToBin(int X)
{
    string tmpBin = string.Empty;
    while (X > 0)
    {
        tmpBin = Convert.ToString(X%2) + tmpBin;
        X /=2;
    }
    Console.WriteLine(tmpBin);
}

int N = ReadInt("Введите число:");
DexToBin(N);
*/

//решение с рекурсией
void DexToBin2(int X)
{
    if (X == 0) return;
    DexToBin2(X/2);
    System.Console.Write(X%2);
}

int N = ReadInt("Введите число:");
DexToBin2(N);
System.Console.WriteLine();