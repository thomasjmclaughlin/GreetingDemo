using System;

namespace GreetingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "are you okay?";

            string nextGreeting = "";

            if (greeting == "Hello world!")
            {
                nextGreeting = "It's great to be born!";
            }
            else if (greeting == "Hey there!")
            {
                nextGreeting = "I'm about to be born!";
            }
            else if (greeting == "Are you ok?")
            {
                nextGreeting = "yup! All good.";
            }
            Console.WriteLine(nextGreeting);
        }
    }
}
