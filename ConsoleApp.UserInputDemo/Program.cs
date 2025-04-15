// Declare variables 
string? firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;
decimal salary = 0;
char gender = char.MinValue;
bool working = true;


//prompt the user for input
Console.Write("Please enter your first name:");
firstName = Console.ReadLine();

Console.Write("Please enter your last name:");
lastName = Console.ReadLine();

Console.Write("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary:");//int 2 decimal 2.5
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender (M or F):");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (True or Flase):");
working = Convert.ToBoolean(Console.ReadLine());


// Process the data
int workingYearsRemaining = retirementAge - age;

// Output the result to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"your salary is:{salary}");
Console.WriteLine($"Your Gender is:{gender}");
Console.WriteLine($"Are you employed:{working}");
Console.WriteLine($"Number of Working years remaining: {workingYearsRemaining}");


