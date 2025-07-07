using System.Text;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            /*
             1- . Write a program that prints an identity matrix using for loop, in other 
                words takes a value n from the user and shows the identity table of size n * n. 
             */
            int[,] arr04 = (int[,])Array.CreateInstance(typeof(int), 2, 4);

            Console.Write("Enter Your Number N Of Matrix: ");
            bool isParse = int.TryParse(Console.ReadLine(), out int n);
            if (isParse)
            {

                int[,] identityMatrix = (int[,])Array.CreateInstance(typeof(int), n, n);
                for (int i = 0; i < n; i++)
                {
                    identityMatrix[i, i] = 1;
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{identityMatrix[i, j]}  ");
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("InVaild Number");
            }


            #endregion


            #region Q2

            /*
             2- Write a program in C# Sharp to find the sum of all elements of the array. 
             */

            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            Console.WriteLine(sum);

            #endregion



            #region Q3

            /*
             * 3- Write a program in C# Sharp to merge two arrays of the same size sorted in 
                ascending order.
             */


            int[] nums01 = new int[] { 10, 20, 30, 40, 80, 60, 70 }; // 4
            int[] nums02 = new int[] { 5, 6, 7, 8, 87, 76, 78 }; // 4

            int size = nums01.Length + nums02.Length;

            int[] Num03 = new int[size];

            // Method 0ne1

            for (int i = 0; i < size; i++)
            {
                if (i < nums01.Length)
                {
                    Num03[i] = nums01[i % nums01.Length]; // [0 % 4] => 0 1 2 3  
                }
                else if (i >= nums01.Length)
                {
                    Num03[i] = nums02[i % nums01.Length]; // 
                }
            }

            foreach (int i in Num03)
            {
                Console.Write($"{i} ");
            }

            // Method 2



              #endregion

            #region Q4

            /*
             Write a program in C# Sharp to find maximum and minimum element in an 
               array  = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 }; 
             */

            int[] numbers01 = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };

            Array.Sort(numbers01);

            int maximum = numbers01[0];
            int minimum = numbers01[numbers01.Length - 1];


            Console.WriteLine($"Minimum Number in This Array is: {minimum} , And Maximum Number is: {maximum}");



            #endregion


            #region Q5

            /*
             5- Write a program in C# Sharp to find the second largest element in an array. 
             */

            Console.Write("Enter The Size Of Array: ");
            bool isParseConverted = int.TryParse(Console.ReadLine(), out int sizeOfArray);

            int[] numsOfArray = new int[sizeOfArray];
            int maxNumber;
            int secondMaxNumber = 0;
            Console.WriteLine("-------- Enter Your Array ---------------");
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write($"Please Enter Element{i + 1}: ");
                bool isParse01 = int.TryParse(Console.ReadLine(), out numsOfArray[i]);
            }
            Console.WriteLine("-----------------------------------------");
            Array.Sort(numsOfArray);
            maxNumber= numsOfArray[ numsOfArray.Length - 1 ];

            for(int  i = 0; i< sizeOfArray; i++)
            {
                if(maxNumber == numsOfArray[i + 1])
                {
                    secondMaxNumber = numsOfArray[i];
                    break;
                }
            }

            Console.WriteLine($"the second largest element in an array {secondMaxNumber}");
            #endregion


            #region Q6
            /*
              Consider an Array of Integer values with size N, having values as     
                in this Example 
                [ 7 , 0 , 0 , 0 , 0 , 5 , 6 , 7 , 5 , 0 , 7 , 5 , 3 ]
                write a program find the longest distance between Two equal cells. In this example. The distance 
                is measured by the number Of cells- for example, the distance between the first and the fourth 
                cell is 2 (cell 2 and cell 3). 
                In the example above, the longest distance is between the first 7 and the 
                10th 7, with a distance of 8 cells, i.e. the number of cells between the 1st 
                And the 10th 7s. 
                Note: - Array values will be taken from the user - If you have input like 1111111 then the distance is the number of 
                Cells between the first and the last cell. 
             */


            Console.Write("Please, Entre The Size of Array: ");
            bool isConvert = uint.TryParse(Console.ReadLine(), out uint sizearr);
            if (isConvert)
            {

                int[] arr01 = new int[sizearr];
                int Maxdistace = 0;
                int element = 0;

                for (int i = 0; i < sizearr; i++)
                {
                    Console.Write($"Please Enter Element {i + 1}: ");
                    bool isParse01 = int.TryParse(Console.ReadLine(), out arr01[i]);

                   
                    if (!isParse)
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                        i--; 
                    }
                }

                for (int i = 0; i < sizearr; i++)
                {
                    for (int j = i + 1; j < sizearr; j++)
                    {

                        if (arr01[i] == arr01[j])
                        {
                                int distance = j - i - 1;

                                if (distance > Maxdistace)
                                {
                                    Maxdistace = distance;
                                    element = arr01[i];
                                }
                        }
                    }
                }

                Console.WriteLine($"Max Distance is: {Maxdistace}, For Element {element}");
            }

            #endregion


            #region Q7


            /*
            7- Given a list of space separated words, reverse the order of the words.                                                                                     
               Input: this is a test  Output: test a is this 
               Input: all your base  Output: base your all 
               Input: Word   Output: Word 
               Note :  
               Check the Split Function (Member in String Class) Output will be a Single Console.WriteLine 
               Statement 
            */


            // Method One
            Console.Write("Please , Enter Your Statment: ");
            string message = Console.ReadLine() ?? "";
            bool hasDigit = message.Any(char.IsDigit);
            if (message != "" && !hasDigit)
            {
                StringBuilder result = new StringBuilder("");
                string word = "";
                // this is a test
                for (int i = 0; i < message.Length; i++)
                {
                    if (message[i] != ' ')
                    {
                        word += message[i];

                    }

                    if (message[i] == ' ' || (i == message.Length - 1))
                    {

                        result.Insert(0, word + ' '); // a is this 
                        word = ""; // ""
                    }
                }

                Console.WriteLine($"After reverse the order of the words become: {result}");
            }
            else
            {
                Console.WriteLine("The Message is Empty or Contain Digits");
            }

            // Method two 
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine() ?? "NotFound";

            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);

            string result01 = string.Join(" ", words);

            Console.WriteLine("Reversed: " + result01);


            #endregion


            #region Q8


            /*
              - Write a program to create two multidimensional arrays of same size. Accept 
                value from user and store them in first array. Now copy all the elements of 
                first array on second array and print second array. 
             */

            Console.Write("Please, Enter Number Of Columns: ");
            bool isParseColumn = int.TryParse(Console.ReadLine(), out int numColumn);
            Console.Write("Please, Enter Number Of Rows: ");
            bool isParseRows = int.TryParse(Console.ReadLine(), out int numRows);

            Console.WriteLine("----------------- Fisrt Array --------------------");
            if (isParseColumn && isParseRows)
            {
                int[,] firstArray = new int[numRows, numColumn];
                int[,] secondArray = new int[numRows, numColumn];

                for (int i = 0; i < numRows; i++)
                {
                    Console.WriteLine($"----- {i + 1} Row ----------");
                    for (int j = 0; j < numColumn; j++)
                    {
                        Console.Write($"Enter Number[{i} , {j}]: ");
                        bool isParseArr = int.TryParse(Console.ReadLine(), out firstArray[i, j]);

                        if (isParseArr)
                        {

                            secondArray[i, j] = firstArray[i, j];
                        }
                        else
                        {
                            --j;
                        }
                    }

                }

                Console.WriteLine("----------------- second Array --------------------");
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numColumn; j++)
                    {
                        Console.Write($"{secondArray[i, j]} ");
                    }
                    Console.WriteLine();
                }

            }





            #endregion


            #region Q9

            /*
             * 9- Write a Program to Print One Dimensional Array in Reverse Order 
             */

            Console.Write("Pease, Enter Size of Array: ");
            int.TryParse(Console.ReadLine(), out int sizeArray);
            int[] D_array = new int[sizeArray];
            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write($"Pease, Enter Element{i + 1}: ");
                int.TryParse(Console.ReadLine(), out D_array[i]);
            }

            D_array.Reverse();

            Console.WriteLine("-------- Print Array ---------------");

            foreach (int i in D_array)
            {
                Console.Write($"{D_array[i]} ");
            }

            Console.WriteLine("-----------------------------------");

            #endregion

        }
    }
}