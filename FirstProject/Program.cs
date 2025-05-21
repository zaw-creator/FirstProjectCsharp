using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1st
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //2
            // 3 -> 1 + 2 + 3
            //key take away cant return a value inside a void method

            //Console.WriteLine("Enter any Numbers");

            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //for (int i = 1; i <= num; i++)
            //{
            //    //Console.WriteLine(i);

            //    sum = sum + i;
            //}
            //Console.WriteLine("Sum of the enter numbers " + sum);
            //Console.ReadLine();

            //3
            //ReverseAString();

            //4
            //key take away: use the for each with char to convert a string to char array
            // also use the tostring to convert a char to string

            //VowelCount();

            //5
            //LargestNumber();

            //6
            //CallingPerson();

            //7
            //// refactor - pass the arguments to the method to print the even numbers and this make the code more reusable
            //int[] numbers = { 3, 6, 9, 12, 15 };
            //PrintEvenNumbers(numbers);

            //8
            //Console.WriteLine("ENTER ANY WORDS");
            //string input = Console.ReadLine();

            //PrintEachChar(input);

            //9 summary of array numbers
            //SummaryOfArray();

            //10 create and use multiple instance of a class 

            // CallingPerson();
            //CallingPerson();
            //CallingPerson();
            //:)) maybe this is the real solution for this task

            //11 refactor the calling person method to add the authentication for the name and age
            CallingPersonRefactor();
        }

        static void ReverseAString()
        {
            Console.WriteLine("Enter any words to reverse!!");
            string inputFromUser = Console.ReadLine();
            char[] reverse = inputFromUser.ToCharArray();
            Array.Reverse(reverse);

            Console.WriteLine("reverse string : " + new string(reverse));
        }

        static void VowelCount()
        {
            Console.WriteLine("Enter any words to count vowels!!");
            string userInput = Console.ReadLine().ToLower();
            string[] vowels = { "a", "e", "i", "o", "u" };

            int count = 0;

            foreach (string vowel in vowels)
            {
                foreach (char c in userInput)
                {
                    if (c.ToString() == vowel)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Vowels count : " + count);
        }

        static void LargestNumber()
        {
            int[] nums = { 4, 7, 1, 12, 9 };

            int max = 0;

            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("largest number is " + max);
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void Display()
            {
                Console.WriteLine($"Name : {Name}, Age: {Age}");
            }
        }

        //static void CallingPerson()
        //{
        //    Person p = new Person();
        //    p.Name = "Alice";
        //    p.Age = 24;
        //    p.Display();
        //}

        static void CallingPerson()
        {
            Person p = new Person();
            Console.WriteLine("enter the person name ");
            p.Name = Console.ReadLine();
            Console.WriteLine("enter the person age ");
            p.Age = int.Parse(Console.ReadLine());
            p.Display();
        }

        static void CallingPersonRefactor()
        {
            Person p = new Person();
            Console.WriteLine("enter the person name ");
            string nameInput = Console.ReadLine();

            if (string.IsNullOrEmpty(nameInput))
            {
                Console.WriteLine("Name cannot be empty");
                return;
            }
            p.Name = nameInput;
            Console.WriteLine("enter the person age ");
            string ageInput = Console.ReadLine();
            if (int.TryParse(ageInput, out int age))
            {
                if (age < 0 || age > 100)
                {
                    Console.WriteLine("Age must be between 0 and 100");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid age input");
                return;
            }
            p.Age = age;
            p.Display();
        }

        static void PrintEvenNumbers(int[] numbers)
        {
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
            Console.ReadLine();
        }

        static void PrintEachChar(string input)
        {
            foreach (char c in input)
            {
                Console.WriteLine(c);
            }
        }

        static void SummaryOfArray()
        {
            int[] numbers = { 2, 4, 6, 8 };
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
        }
    }
}
