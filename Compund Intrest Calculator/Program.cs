int principalAmt;
Console.WriteLine("Enter the principal amount: ");
principalAmt = Convert.ToInt32(Console.ReadLine());


int rateOfInterest;
Console.WriteLine("Enter the annual rate of interest as a whole number: ");
rateOfInterest = Convert.ToInt32(Console.ReadLine());

int years;
Console.WriteLine("Enter the number of years: ");
years = Convert.ToInt32(Console.ReadLine());

var n = 12; //Compunded Monthly, 12 Months in a year

//Compund Intrest Formula
var compundIntrest = principalAmt * Math.Pow(1 + rateOfInterest / 100.0 / n, n * years);


//Convert to a string to print to Console            
Convert.ToString(compundIntrest);

//Write to Console
Console.WriteLine($"In {years} years you will have: $"
                  + compundIntrest. /**This function eliminates everything after two decimals places*/ToString("F2"));