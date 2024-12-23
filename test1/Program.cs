// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//1-simple adding 
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sumation = 0;
for (int x = 0; x < number.Length; x++) {  ;
sumation += x;

    }
Console.WriteLine("the value is  " + sumation);





//4-Simple events 
#region fun 
    string val (int num )
{

    if (num % 2 != 0)
    {
        return "true";
    }

    else
    {
        return "false";
    }
}
Console.WriteLine(val(4602225));  
Console.WriteLine(val(460222));   

#endregion






//2-vowel count 
#region fun 
int Vowelcount(string letter) {

        //if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        int count = 0;
        foreach (char c in letter)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        return count;
    }



   

#endregion 


//string input = "All cows eat grass and moo";
//Console.WriteLine(VowelCount(letter));





//int count = 0;
//foreach (char c in letter)
//{

// if ((vowels, vowel => vowel == c))
// {
//count++;
//}
//
//return count;
//}


//3 first factorial 

Console.WriteLine("Enter a number between 1 and 18:");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 18)
{
    Console.WriteLine($"the factorial of {num} is: {FirstFactorial(num)}");
}
else
{
    Console.WriteLine("please enter a number within the range of 1 to 18.");
}
    

     int FirstFactorial(int num)
{
    int result = 1;

    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }

    return result;
}


//5 one dec
 //double OneDec;
Console.WriteLine("Enter a string of digits:");
string input = Console.ReadLine();
int result = OneDec(input);
Console.WriteLine($"The digits that are less than the previous digit is: {result}");

int OneDec(string str)
{
    int counter = 0;

    for (int i = 1; i < str.Length; i++)
    {
        int currentDigit = str[i] - '0';
        int previousDigit = str[i - 1] - '0';

        if (currentDigit == previousDigit - 1)
        {
            counter++;
        }
    }

    return counter;
}

