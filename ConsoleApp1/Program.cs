namespace ConsoleApp1
{
    internal class Program
    {

        //this is our main function, it does main stuff
        static void Main(string[] args)
        {
            //common Variable types
            int newInt = 1; //whole number integers
            float newFloat = 42.0f; //float has decimals, and isnt as accurate as double
            double newDub = 80.00D; // double is more precise but can be slower,
            char newChar = 'a'; //well... its 'a' char
            string newString = "hello world???"; //string is an array/list of Char
            short newShort = 1;
            long newLong = 2;
            bool newBool = true; // bool is true or false, we use these for Logic and comparing

            /* comapring operators
             * op   name                         e.g
             * ==	Equal to	                x == y
             * !=	Not equal	                x != y
             * >	Greater than	            x > y
             * <	Less than	                x < y
             * >=	Greater than or equal to	x >= y
             * <=	Less than or equal to	    x <= y
             * 
             * Logical Operators
             * || (OR)
             * != (not equal)
             * ! (not)
             * && (AND)
             * 
             * for more...
            //https://www.w3schools.com/cs/cs_operators.php
             */

            //console out
            Console.WriteLine(newString);
            Console.WriteLine("please enter 2 numbers");
            //console in to variable
            newString = Console.ReadLine();

            //parse string to float, correct way
            //you should check if string can be parsed first, will show next week
            float firstNumb = float.Parse(newString);
            newString = Console.ReadLine();
            //parse string to int, then cast to float, this bad, but doable. wont accept decimals
            float secondNumb = Convert.ToInt32(newString);

            //some vector math because i need to be careful what i share
            float Magnitude = MathF.Sqrt(firstNumb * firstNumb + secondNumb * secondNumb);
            Console.WriteLine("the magnitude is " + Magnitude);

            //normalize vector (look at the /=, we can divide, add, subtract, multiply to the left side without having to re-reference)
            // we dont
            firstNumb = firstNumb/ Magnitude; 
            secondNumb /= Magnitude; //this is quicker to read

            //cleanest way of typing out this output
            Console.WriteLine($"Normalized vector: {firstNumb},{secondNumb} ");
            //find new magnitude of normalized vector
            Magnitude = MathF.Sqrt(firstNumb * firstNumb + secondNumb * secondNumb);
            //output sting the other way
            Console.WriteLine("the normalized magnitude is " + Magnitude);


        }



    }
}