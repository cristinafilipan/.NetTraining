//Write a program that reads a number from the keyboard. Check whether that number is divisible by 7 and 11 or not.

/*
    Console.WriteLine("Input a value");
    int number = int.Parse(Console.ReadLine());
    if ((number % 7==0) && (number % 11==0))
    {
        Console.WriteLine("Number is divisible by 7 and 11");
    }
    else
    {
        Console.WriteLine("Number is not divisible by 7 and 11");
    }
*/

//Check whether a given year is leap year or not.
/*Console.WriteLine("Input a year");
int year = int.Parse(Console.ReadLine());
if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
{
    Console.WriteLine(+year+" is  a leap year");
}
else
{
    Console.WriteLine(+year+" is not a leap year");
}
*/
//3. By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13. What is the 47th prime number?
int n = 0, counter = 0;
do
{
    if (n %2==1)
    {
        counter=counter+1;
    }
    n=n+1;
} while (counter<47);

Console.WriteLine("The 47th prime number is " +(--n));