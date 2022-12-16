Console.WriteLine("Введите число a: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int number1 = int.Parse(Console.ReadLine());

int k = number / number1;
if(k == number1)
{
   Console.WriteLine($"Число {number} является квадратом числа {number1}"); 
}
else
{
 Console.WriteLine($"Число {number} НЕ является квадратом числа {number1}");   
}
