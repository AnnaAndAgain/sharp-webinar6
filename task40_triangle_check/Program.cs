/*
На вход 3 числа.
Проверяем, может ли существовать треугольник с такими сторонами.
(каждая сторона меньше суммы двух других сторон.)
*/ 

void FillArrayUser(int[] tmpArray)
{
    for (int i = 0; i < tmpArray.Length; i++)
    {
        tmpArray[i] = ReadInt($"Введите длину стороны {i+1}.");
    };
}

int ReadInt(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] tmpArray)
{
    Console.WriteLine($"[" + string.Join(", ", tmpArray) + "]");
}

bool CheckSides(int[] tmpArray)
{
    if (tmpArray[0] < tmpArray[1]+tmpArray[2] && tmpArray[1] < tmpArray[0]+tmpArray[2] && tmpArray[2] < tmpArray[0]+tmpArray[1]) return true;
    return false;
}

int[] sides = new int[3];
FillArrayUser(sides);
if (CheckSides(sides)) System.Console.WriteLine("Треугольник получится.");
else System.Console.WriteLine("Треугольник НЕ получится.");
