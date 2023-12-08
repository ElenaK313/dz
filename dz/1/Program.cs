
int[] array = new int[10];
int count = 0;

for(int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(1,101);
    System.Console.Write(array[i]+ " ");

    if((array[i]>=20) && (array[i]<=90))
    {
        count = count + 1;
        
    } 
}

Console.WriteLine();
Console.WriteLine(count);



