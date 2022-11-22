//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
int numberA = new Random().Next(-1000, 1000);
Console.WriteLine(numberA);
int numberB = new Random().Next(-1000, 1000);
Console.WriteLine(numberB);
if (numberA > numberB)
{
    Console.WriteLine(numberA);
}
else
{
    Console.WriteLine(numberB);
}

    
   
