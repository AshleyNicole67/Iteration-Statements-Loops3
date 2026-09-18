namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()

        public static void PrintNumbersFrom1000ToNegative1000()
        {
            Console.WriteLine("--- Problem 1: Numbers 1000 through -1000 ---");
            
            for (int currentNumber = 1000; currentNumber >= -1000; currentNumber--)
            {
                Console.WriteLine(currentNumber);
            }
        }
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        
        public static void PrintNumbersByThree()
        {
            Console.WriteLine("\n--- Problem 2: Counting by 3 ---");

            for (int currentNumber = 3; currentNumber <= 999; currentNumber += 3)
            {
                Console.WriteLine(currentNumber);
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        
        public static void CheckIfNumbersAreEqual(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
            {
                Console.WriteLine($"{firstNumber} and {secondNumber} are the same!");
            }
            else
            {
                Console.WriteLine($"{firstNumber} and {secondNumber} are not the same!");
            }
        }

        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        
        public static void CheckIfNumberIsEvenOrOdd(int number)
        {
           

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        public static void PositiveOrNegative(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"{number} is zero.");
            }
            else
            {
                Console.WriteLine($"{number} is negative.");
                
            }
                
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.

        public static void VoteEligibility()
        {
            Console.WriteLine("Please enter your age:");
            var userAge = int.TryParse(Console.ReadLine(), out int age);

            while (userAge == false)
            {
                Console.WriteLine("Please enter your valid age:");
                userAge = int.TryParse(Console.ReadLine(), out int validAge);
            }
            
            if (age >= 18)
            {
                Console.WriteLine($"Congrats, {userAge} is old enough to vote.");
                
            }
            else
            {
                {
                    Console.WriteLine($"Sorry, {userAge} is not old enough to vote.");
                    
                }
            }
            
        }
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        
        public static bool IsInRange(int number)
        {
           
            if (number >= -10 && number <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        
        public static void DisplayMultiplicationTable(int number)
        {
            for (int multiplier = 1; multiplier <= 12; multiplier++)
            {
                int result = multiplier * number;

                Console.WriteLine($"{multiplier} * {number} = {result}");
            }
        }
       

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            // PrintNumbersFrom1000ToNegative1000();
           // PrintNumbersByThree();
           // CheckIfNumbersAreEqual(firstNumber:2, secondNumber:2);
           // CheckIfNumberIsEvenOrOdd(number: 30);
          // PositiveOrNegative(number: 10);
           // VoteEligibility();
          
           //Heating up - Answer to #1
           //  Console.Write("Enter a whole number: ");
          // int userNumber = int.Parse(Console.ReadLine());

          // bool numberIsInRange = IsInRange(userNumber);

           //Console.WriteLine(numberIsInRange);

           // Heating up - Answer to #2
          // Console.Write("Enter a number for the multiplication table: ");

           //int userNumber = int.Parse(Console.ReadLine());

          // DisplayMultiplicationTable(userNumber);

        }
    }
}
