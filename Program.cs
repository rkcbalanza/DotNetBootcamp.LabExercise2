using System;

namespace CSharp.LabExercise2
{
    internal class Program
    {
        //Number 1
        static void Number1()
        {
            int inputCounter = 0;
            int[] inputNumbers = new int[5];
            do
            {
                bool isUserInputDuplicate = false;

                Console.Write("Enter number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                //Check if 10 - 100
                if (userInput < 10 || userInput > 100)
                {
                    Console.WriteLine("Please enter a number from 10 - 100 only.");
                    continue;
                }


                //Check if Duplicate
                foreach (int number in inputNumbers)
                {
                    if (number == userInput)
                    {
                        isUserInputDuplicate = true;
                    }
                }

                //Insert to Array if not Duplicate
                if (!isUserInputDuplicate)
                {
                    inputNumbers[inputCounter] = userInput;
                }

                //Display Array
                for (int index = 0; index <= inputCounter; index++)
                {
                    if(isUserInputDuplicate && index == inputCounter)
                    {
                        continue;
                    }

                    Console.Write("{0} \t", inputNumbers[index]);
                }

                Console.WriteLine("");

                //Display Duplicate Message + Skip Counter Increment
                if (isUserInputDuplicate)
                {
                    Console.WriteLine("{0} has already been entered!", userInput);
                    continue;
                }
                
                inputCounter++;

            } while (inputCounter <= 4);
        }

        //Number 2
        class Lasagna
        {
            public int ExpectedMinutesInOven()
            {
                int expectedMinutes = 40;
                return expectedMinutes;
            }

            public int RemainingMinutesInOven(int minutesInOven)
            {
                int remainingMinutes = ExpectedMinutesInOven() - minutesInOven;
                return remainingMinutes;
            }

            public int PreparationTimeInMinutes(int numberOfLayers)
            {
                int minutesPreparing = numberOfLayers * 2;
                return minutesPreparing;
            }
            
            public int ElapsedTimeInMinutes(int numberOfLayers, int minutesInOven)
            {
                int minutesCooking = PreparationTimeInMinutes(numberOfLayers) + RemainingMinutesInOven(minutesInOven);
                return minutesCooking;
            }
        }
        static void Number2()
        {
            var lasagna = new Lasagna();
            Console.WriteLine("Expected Minutes in Oven: {0} minutes", lasagna.ExpectedMinutesInOven());
            Console.WriteLine("Remaining Minutes in Oven: {0} minutes", lasagna.RemainingMinutesInOven(30));
            Console.WriteLine("Preparation Time: {0} minutes", lasagna.PreparationTimeInMinutes(2));
            Console.WriteLine("Elapsed Time: {0} minutes", lasagna.ElapsedTimeInMinutes(3, 20));

        }
        static void Main(string[] args)
        {
            Number1();
            //Number2();
        }
    }
}
