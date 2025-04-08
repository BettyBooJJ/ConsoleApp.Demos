// See https://aka.ms/new-console-template for more information

// different dadttypes
/*
    text - string
    intergers - int
    decimal - double , float , decimal
    logical - bool 
*/
string name = "Jodi ann Charlton";

Console.WriteLine(name);
Console.WriteLine("I am "+ name);   // String concatenation text is call static message string
Console.WriteLine($"They call me {name}");  // String interpolation
Console.WriteLine("I was given the name {0}", name);  // Formatted string

int age = 54;
int retirementYearsLeft = 11;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("My age is: " + age);
Console.WriteLine("My retirement age is: " + retirementAge);


bool isRetired = false;
Console.WriteLine("am i retired? " + isRetired);



