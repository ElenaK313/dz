Console.WriteLine("Введите размер мaссива:");
int num = Convert.ToInt32(Console.ReadLine());

double[] array = new double[num];
double Min = double.MaxValue;
double Max = double.MinValue;
double result = 0;

for(int i = 0; i<array.Length; i++)
{
    array[i]= new Random().NextDouble()*100;        
    System.Console.Write(Math.Round((array[i]), 2) + "    "); 
}
Console.WriteLine();

for(int i = 0; i<array.Length; i++)
{
    if(array[i] < Min)
    {
        Min = array[i];
    }
        
    if(array[i] > Max)
    {
       Max = array[i];
    }   
}
result = Max - Min; 
System.Console.WriteLine(Math.Round(result, 2));

