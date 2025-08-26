/* Write a C# Sharp program to accept two integers and check whether they are equal or not.
Test Data :
Input 1st number: 5
Input 2nd number: 5
Expected Output :
5 and 5 are equal
Test Data :
Input 1st number: 5
Input 2nd number: 15
Expected Output :
5 and 15 are not equal
*/
int num1, num2;
num1 = 5;
num2 = 15;

if (num1 == num2)
{
    Console.WriteLine($"{num1} and {num2} are equal");
}
else
Console.WriteLine($"{num1} and {num2} are not equal");