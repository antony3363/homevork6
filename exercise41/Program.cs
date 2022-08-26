//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

int M = 5;

int b = 0;

int [] numbers = new int[M];


for (int i = 0; i < M; i++)
 {
    System.Console.WriteLine("Введите число");
    numbers [i] = int.Parse(Console.ReadLine()!);
    
 }

Console.Write("[");
for (int i = 0; i < numbers.Length; i++)
 {
    
    Console.Write(" " + numbers [i] + " ");
 }


Console.Write("]");

for (int i = 0; i < numbers.Length; i++)
 {
    if (numbers [i] > 0)
    {
        b+=1;
    }
    
 }




Console.Write(" -> " + b);



