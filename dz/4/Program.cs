Console.WriteLine("Введите число от 1 до 100 000");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

while(num >= 1)
{
    System.Console.Write(num % 10 + "   ");
    num = num/10;
} 


