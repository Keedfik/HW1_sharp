// Задача 2: Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input first number ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second number ");
double num2 = Convert.ToDouble(Console.ReadLine());
if(num1>num2){
    Console.WriteLine("Max number is " + num1);
    Console.WriteLine("Min number is " + num2);
}else{
    Console.WriteLine("Max number is " + num2);
    Console.WriteLine("Min number is " + num1);
}
*/

// Задача 4: Напишите программу, которая принимает на 
// вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input first number ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second number ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input third number ");
double num3 = Convert.ToDouble(Console.ReadLine());
if(num1>num2){
    if(num1>num3){
        Console.WriteLine("Max number is " + num1);
    }else{
        Console.WriteLine("Max number is " + num3);
    }
}else{
    Console.WriteLine("Max number is " + num2);
}
*/

// Задача 6: Напишите программу, которая на вход принимает 
// число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
if(number%2==0){
    Console.WriteLine(number + " - четное число");
}else{
    Console.WriteLine(number + " - нечетное число");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N

/*
Console.Write("Input positiv number ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 2;
while(current <= number){
    Console.Write(current + " ");
    current += 2; 
}
*/