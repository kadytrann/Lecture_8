namespace Lecture_8
{
    internal class Program
    {

        // Declare an array, type[].
        // Initialize with, new type[size]

        // How do we initilaize an array WITH values?
        // If key words are darkened out, the compiler is telling us they are redudant
        //static string[] names = new string[] { "Will" };
        static string[] names = {
            "Emma",
            "Noah",
            "Olivia",
            "Liam",
            "Ava",
            "William",
            "Sophia",
            "Mason",
            "Isabella",
            "James",
            "Charlotte",
            "Elijah",
            "Mia",
            "Benjamin",
            "Amelia",
            "Lucas",
            "Evelyn",
            "Oliver",
            "Abigail",
            "Ethan"
        };
        // ----------------------------

        static void Main(string[] args)
        {

            // Searching Algorithm
            // Asking : Does this name exist in the array
            // string, int, double, bool

            Console.Write("Please enter a name to search for: ");
            string lookingForUserName = Console.ReadLine(); ;
            bool userIsOnList = false;

            // Loop though our full array.
            for (int i = 0; i < names.Length; i++)
            {
                string currentName = names[i];
                // Checking to see if the current value is the same as the value we are searching
                if (currentName == lookingForUserName)
                {
                    userIsOnList = true;
                }

            }

            // After the for loop

            if (userIsOnList)
            {
                Console.WriteLine($"{lookingForUserName} is on the list");
            }
            else
            {
                Console.WriteLine("That name is not on the list.");
            }


        } // Main

        // Two Topics Discussed
        // 1. Arrays
        // 2. Nested Conditions

        // Todays topic is continuing with arrays
        // Declaring and initiazling them ( multiple methods to initilaization
        // How to manipulate and add data
        // Review the keyword : Index

        public static void AskForNamesExample()
        {
            // This declares a string array, and intializes it with 5 empty elements
            string[] names = new string[5];

            // We are going to ask the user to enter 5 names

            // For loops are commonly used to iterate through an array

            // use your arrayName.Length to tell the computer how many times to loop
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Please enter a name for index {i}: ");
                string userName = Console.ReadLine();

                // [index] is how you access an individual element. 
                names[i] = userName;

                Console.WriteLine($"The named store at index {i} is {names[i]}");
            }

        } // AskForNamesExample()


        public static void WorkingWithMultipleArrays()
        {
            // Ask the user for an array size
            // This will create 3 arrays
            // One to hold all the numbers
            // One to hold even numbers
            // One to hold odd numbers
            // We want to display the average each of the 3 arrays.

            // Validating a number using TryParse

            //Console.Write("Please enter a number to indicate the size of an array: ");
            //string userNumber = Console.ReadLine();
            string userNumber;
            int usersArraySize;
            int[] fullArray, oddArray, evenArray;

            // Is the users input a number
            // False <---- Recognized as true
            // !
            do
            {
                Console.Write("Please enter a number to indicate the size of an array: ");
                userNumber = Console.ReadLine();
            } while (!int.TryParse(userNumber, out usersArraySize));

            fullArray = new int[usersArraySize];
            oddArray = new int[usersArraySize];
            evenArray = new int[usersArraySize];

            // Value :  4343, 123, 45, 1, 545, 34 
            // Element :  1,   2,   3,  4,  5,  6
            // Index :    0,   1,   2,  3,  4,  5

            // We have a finite number.
            for (int i = 0; i < fullArray.Length; i++)
            {
                // Declaring the variables for our values being stored INSIDE of our loop
                string userStringValue;
                int usersValue;

                // Prompting user for a valid number. Will repeat until assigned
                do
                {
                    Console.Write($"Enter a number for the {i + 1} element at index {i}: ");
                    userStringValue = Console.ReadLine();
                } while (!int.TryParse(userStringValue, out usersValue));

                // Storing users Number to our full array.
                fullArray[i] = usersValue;

            }


            int evenIndex = 0;
            int oddIndex = 0;

            for (int i = 0; i < fullArray.Length; i++)
            {
                bool isEven = fullArray[i] % 2 == 0;

                if (isEven) // <--- Just looking for true or false
                {
                    // Get the current value
                    int currentValue = fullArray[i];
                    // Add it to the even array and the CURRENT EVEN ARRAY INDEX
                    evenArray[evenIndex] = currentValue;
                    // Increment the evenIndex by 1
                    evenIndex++; // <---- Increment by 1
                }
                else
                {
                    int currentValue = fullArray[i];
                    oddArray[oddIndex] = currentValue;
                    oddIndex++;
                }


                Console.WriteLine($"{i} : {fullArray[i]} : Is Even {isEven}");
            }

            // To get the average, you sum up all the number, and divide by the number of elements

            double fullSum = 0;
            Console.WriteLine("Full Array");
            for (int i = 0; i < fullArray.Length; i++)
            {
                Console.Write(fullArray[i] + " ");
                fullSum += fullArray[i];

            }
            double fullAverage = fullSum / fullArray.Length;
            Console.WriteLine($"The sum of all the values in full array is {fullSum} and the averge is {fullAverage}");


            // Display the even numbers, get the sum, and get the average

            double evenSum = 0;
            Console.WriteLine();
            Console.WriteLine("Even array");
            for (int i = 0; i < evenArray.Length; i++)
            {
                Console.Write(evenArray[i] + " ");
                evenSum += evenArray[i];
            }
            double evenAverage = evenSum / evenIndex;
            Console.WriteLine($"The sum of all the values in full array is {evenSum} and the averge is {evenAverage}");

            // Display the odd numbers, get the sum, and get the average

            double oddSum = 0;
            Console.WriteLine();
            Console.WriteLine("Odd Array");
            for (int i = 0; i < oddArray.Length; i++)
            {
                Console.Write(oddArray[i] + " ");
                oddSum += oddArray[i];
            }
            double oddAverage = oddSum / oddIndex;
            Console.WriteLine($"The sum of all the values in full array is {oddSum} and the averge is {oddAverage}");



            // How do we check to see if a number is even or odd
            // How do we check to see if a value is divisible by two?
            // Mod
            //if(userNumber % 2 == 0) { is Even }
            // else { isOdd }

        }



    } // class

} // namespace