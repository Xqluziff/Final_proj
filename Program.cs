﻿string[] allMas = { "Russian", "Belarus", "China", "UAE" };
Console.Write("All arrey: ");
PrintMas(allMas);
int countSymbol = 3;
string[] newMas = NewMas(allMas, countSymbol);
Console.Write("\nNew arrey: ");
PrintMas(newMas);


string[] NewMas(string[] str, int cS)
{
    int size = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 4)
        {
            size++;
        }
    }

    if (size > 0)
    {
        string[] newMas = new string[size];
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i].Length <= cS)
            {
                newMas[count] = str[i];
                count++;
            }
        }
        return newMas;
    }
    return new string[0]; // null

}
void PrintMas(string[] str)
{
    Console.Write('[');
    for (int i = 0; i < str.Length; i++)
    {
        if (i == str.Length - 1) Console.Write($"{str[i]}");
        else Console.Write($"{str[i]}, ");
    }
    Console.Write("] \n");
}