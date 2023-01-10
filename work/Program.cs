
//Решение задачи - нахождение суммы четных чисел

int number = 4;
int sum = 0;
for (int i = 0; i <= number; i++)
{
     i += 2;
     sum = i + sum;
           
}
Console.Write($"{sum} ");

