// See https://aka.ms/new-console-template for more information

//Declare variables

int milesDriven;
int gallonsUsed;

Console.Write("Enter the number of miles driven: ");
milesDriven = int.Parse(Console.ReadLine());

Console.Write("Enter the amount of gasoline used (in gallons): ");
gallonsUsed = int.Parse(Console.ReadLine());

// Calculate the mpg
double mpg = milesDriven / gallonsUsed;

//Output result to user
Console.WriteLine($"For {milesDriven} miles and {gallonsUsed} gallons of gas used, your vehicle is consuming roughly {mpg} miles per gallon. ");
