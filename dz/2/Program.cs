﻿
int[] array = new int[10];
int count = 0;

for(int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(0,101);
    System.Console.Write(array[i]+ " ");

    if(array[i] % 2 == 0)
    {
        count = count + 1;
        
    } 
}

Console.WriteLine();
Console.WriteLine(count);
