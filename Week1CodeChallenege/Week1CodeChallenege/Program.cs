using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenege
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a loop for the numbers 0 to 20 and call your FizzBuzz function for each number in the loop
            for (int number = 0; number <= 20; number++)
            {
                FizzBuzz(number);
            }

            //create a loop for the numbers 92 to 79 and call your FizzBuzz function for each number in the loop
            for (int number = 92; number >= 79; number--)
            {
                FizzBuzz(number);
            }

            Yodaizer(string ("I like code"));

            isPrime(1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25);

            DashInsert(8675309);



            Console.ReadKey();
        }




        //create a FizzBuzz function with number as the parameter
        static void FizzBuzz(int number)
        {
            //if number is divisible by 5 print out "Fizz"
            if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }

                //if number is divisible by 3 print out "Buzz"
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }


                //if the number is divisible by both 5 & 3 then print out "FizzBuzz"
            else if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }

                //if the number is not divisible by 5 and 3 then print out the parameter (number)
            else if (number % 5 != 0 && number % 3 != 0)
            {
                Console.WriteLine(number);
            }
            //Create a function called TextStats that takes a parameter called "input". This function will process a string and print out the following information
            string Yodaizer = "text";
            string End_Value = "";
        }

            private void buttonclick(object sender, EventArgs e)
            {
                //1.Number of characters
                string word = "";

                foreach (Char Chara in Yodaizer)
                {
                    if (Chara == ' ')
                    {
                        End_Value += new string(word.Reverse().ToArray());
                        End_Value += " ";
                        word = "";
                    }
                    else
                    {

                        word += Chara;

                    }
            
                }
                End_Value += " ";
                End_Value += new string(word.Reverse().ToArray());


            static void TextStats (string input);
                string s;
                int i = 0;
                int space = 0;
                int a = 0;

                for (; i < s.Length; i++)
                    if (s[i] == 'a')
    {
        a++;
    }
    else if (s[i] == ' ')
{
    space++;
}
}
Console.WriteLine("A: {0}", a);
Console.WriteLine("Space {0}", space);
Console.WrieLine();


//number of words
for (int i = 0; i < input.length; i++)
			{
			 console.writeline[i].counter i+(string)
			}

//number of vowels
string vowels = "aeiou"
if (vowels.Contains (letter.ToLower()))
{ output = output + letter.ToUpper();
}
else
{
output = output + letter.ToLower();

}
{

Console.WriteLine(output);

}



//checking if a number is prime
//loop from 2 to number
static void isPrime (int number)
{
for (int i = 2; i < number; i++)
			{
			 if (number % 1 == 0
			{
return false;
}
}
return true;


static void DashInsert (int number)
{
for (int i = 2; i < number; i++)
			{
			 Console.Writeline("-");
			}











        }
    }
    }
