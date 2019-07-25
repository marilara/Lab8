using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    class Program
    {
        private static readonly object student;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class.");
            Console.WriteLine("Which student would you like to learn more about? (enter a number 1 - 15):");

            bool repeat = true;

            while (repeat)
            {
                bool askAgain = true;
                while (askAgain)
                {
                    try
                    {
                        askAgain = false;
                        string num = Console.ReadLine();
                        int studentNumber = int.Parse(num);
                        string[] emptyArray = new string[15];

                        Console.WriteLine("Student " + studentNumber + " is " + GetStudentName(studentNumber) + ". What would you like to know about " + GetStudentName(studentNumber) + "? Enter hometown or favorite food.");
                        Console.WriteLine();
                        string input = Console.ReadLine().ToLower();

                        if (input == "hometown" || input == "favorite food")
                        {
                            if (input.ToLower() == "hometown")
                            {
                                Console.WriteLine(GetStudentName(studentNumber) + " is from " + GetHometown(studentNumber) + ".");
                            }
                            else if (input.ToLower() == "favorite food")
                            {
                                Console.WriteLine(GetStudentName(studentNumber) + "'s favorite food is " + GetFavoriteFood(studentNumber) + ".");
                            }


                            Console.WriteLine("That data does not exist.Please try again. (enter or “hometown” or “favorite food”):");
                        }
                        else
                        {
                            

                            Console.WriteLine("Would you like to know more? (enter yes or no)");
                            string answer = Console.ReadLine().ToLower();
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("That student does not exist. Please try again. (enter a number 1-15):");
                        askAgain = true;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("The format of your response is incorrect. Please try again.");
                        askAgain = true;
                    }
                }
                

                Console.WriteLine("Would you like to learn about another student? (enter yes or no)");
                string response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    repeat = true;
                }
                else
                {
                    break;
                }
            }

        }

        public static string GetStudentName(int studentNumber)
        {
            string[] emptyArray = { "Dakota", "Joshua", "Tommy", "James", "Maricela", "KimVy", "Sam", "Cody", "Flaka", "Mahruchirhee", "Manik", "Moise", "Liz", "Jason", "Robert" };
            return emptyArray[studentNumber - 1];
        }

        public static string GetHometown(int studentNumber)
        {
            string[] emptyArray = { "Kent City", "Grand Rapids", "Raleigh", "Grand Rapids", "Morelia", "Grand Rapids", "Grand Rapids", "Lawton", "Pristina", "Teaneck", "Cox'sBazar", "Grand Rapids", "Planet Earth", "Holland", "Detroit" };
            return emptyArray[studentNumber - 1];
        }

        public static string GetFavoriteFood(int studentNumber)
        {
            string[] emptyArray = { "pho", "Cheese tortellini", "indian style curried chicken", "cheeseburgers and french fries", "tacos", "sushi", "tacos", "potato soup", "thai", "chicken wings", "spicy beef curry", "lasagna", "smoked salmon", "burgers", "burgers" };
            return emptyArray[studentNumber - 1];
        }
    }
}
