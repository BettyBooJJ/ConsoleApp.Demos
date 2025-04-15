// See https://aka.ms/new-console-template for more information


using System;

Console.WriteLine("Please enter the first number");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = 0;
    Console.Write("please enter the second number:");
num2 = Convert.ToInt32(Console.ReadLine());

/*
        Math Operation and Operators
*/
// Add the Number
int sum = num1 + num2;
//multipy
int product = num1 * num2;
//division
int quotient = num1 / num2;
//subtraction
int difference = num1 - num2;
//Modulus
int mod = num1 % num2;


Console.WriteLine("*************Math Results********");
Console.WriteLine();
Console.WriteLine($"difference:{difference}");
Console.WriteLine($"Product:{product}");
Console.WriteLine($"Quotient:{quotient}");
Console.WriteLine($"Modlus:{mod}");
Console.WriteLine();
Console.WriteLine("************* End Math Results********");
/*
     Logic Operation and Operators
*/
Console.WriteLine("*************Math Results********");
var isGreaterThan=num1 > num2;
bool isLessThan=num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo=num1<=num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("*************Logic Results********");
Console.WriteLine();
Console.WriteLine($"Is Greater Than:{isGreaterThan}");
Console.WriteLine($"Is Less Than:{isLessThan}");
Console.WriteLine($"Is Equal To:{isEqualTo}");
Console.WriteLine($"Is Greater Than Or Equal To:{isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than Or Equal To:{isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal:{isNotEqual}");
Console.WriteLine();
Console.WriteLine("*************End Logic Results********");

/*
//    Assignment Operation and Operators
*/
int RandomValue = Convert.ToInt32(Console.ReadLine());
//  int inccreaseValue = num1 + RandomValue;

Console.WriteLine("************* Assignment Results********");
Console.WriteLine();
// num1 = num1 +5;
num1 += RandomValue;
Console.WriteLine($"Num 1 increased by {RandomValue} : {num1}");
// num1 = num1 -randomValue;
num1 -= RandomValue;
Console.WriteLine($"Num 1 reduced by {RandomValue} : {num1}");
// num1 = num1 *randomValue;
num1 /= RandomValue;
Console.WriteLine($"Num 1 divived by {RandomValue} : {num1}");
// num1 = num1 /randomValue;
num1 %= RandomValue;
Console.WriteLine($"Num 1 mod by{RandomValue}: {num1}");
// num1 = num1 %randomValue;
num1 *= RandomValue;
Console.WriteLine($" Num 1 multipied by {RandomValue}: {num1}");
Console.WriteLine();
Console.WriteLine("*************End Operation Results********");