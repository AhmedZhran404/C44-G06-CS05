namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ahmed");
            #region Arrays

            #region 1D Array

            // Array Is Class - Reference Type
            int[] numbers;
            // Declare For Reference of Type Array Of Integer
            // This Reference numbers is refering to The Default Value of The referenceType = null
            // This  reference can refere to an object of type "Array of Integer"
            // CLR Will Allocate 4 Bytes For This Reference [Uninitialized] in stack
            // CLR Will Allocate 0 Bytes in heap
            numbers = new int[3]; // First method for declare array 
                                  // CLR Will Allocate 12 Bytes in heap
                                  // Will Be initialized with The Default Vaule Of int = 0
                                  // return The Address of The fisrt element in array For "numbers"
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            // numbers[3] = 4; // Will Throw Exception

            // Protective code
            if (numbers.Length > 3)
            {
                Console.WriteLine("Tamam");
                numbers[3] = 4;
            }

            Console.WriteLine(numbers[0]); // 10 
            Console.WriteLine(numbers[1]); // 20
            Console.WriteLine(numbers[2]); // 30


            int[] numbers02 = new int[] { 1, 2, 3, 4 }; // Second Method

            int[] numbers03 = { 1, 2, 3, 4, 5 }; // Third Method


            // int[] numbers04 = [1,2,3,4,5]; // .net 8.0 -> c# 12.0

            Console.WriteLine($"The Length Of Array: {numbers03.Length} And The dimention is: {numbers03.Rank}");




            #endregion

            #region 2D Rectangle

            int[,] Grades = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };

            // CLR Will Allocate 24Bytes in heap ,
            // Initialized With data

            for (int r = 0; r < Grades.GetLength(0); r++)
            {
                Console.WriteLine($"Student Num#{r + 1}");
                for (int c = 0; c < Grades.GetLength(1); c++)
                {
                    Console.WriteLine($"Grades Of Student: {Grades[r, c]}");

                }

            }
            uint[,] Grades01 = new uint[2, 3]
            {
                     {1,2,3} ,
                     {4,5,6}
            };

            for (int r = 0; r < Grades01.GetLength(0); r++)
            {
                Console.WriteLine($"Ensert The Value Of Student {r + 1}: ");
                for (int c = 0; c < Grades01.GetLength(1);)
                {

                    Console.Write($"Enter Grade Of Subject{c + 1}: ");

                    c = uint.TryParse(Console.ReadLine(), out Grades01[r, c]) ? ++c : c;

                }
            }

            //   Console.Clear();
            Console.WriteLine("------------- Print Grades Of Students ----------------");

            for (int r = 0; r < Grades01.GetLength(0); r++)
            {
                Console.WriteLine($"Student Num#{r + 1}");
                for (int c = 0; c < Grades01.GetLength(1); c++)
                {
                    Console.WriteLine($"Grades Of Student: {Grades01[r, c]}");

                }

            }

            // ------------------------------------------------

            for (int i = 0; i < Grades01.Length; i++)
            {
                Console.WriteLine(Grades01[i / 3, i % 3]); // 
            }
            #endregion


            #region gaddged Array

            int[][] marks = new int[3][];

            marks[0] = new int[3] { 1, 2, 3 };
            marks[1] = new int[2] { 4, 5 };
            marks[2] = new int[1] { 6 };

            Console.WriteLine(marks.Length);
            for (int i = 0; i < marks.Length; i++)
            {
                for (int j = 0; j < marks[i].Length; j++)
                {
                    Console.WriteLine(marks[i][j]);
                }
            }


            #endregion


            #region MethodsOfArray

            #region Class Member method

            // Class Member method => A Class Member Method is a method that belongs to the class itself,
            // not to any specific object of the class.
            // You can call it without creating an object of the class.

            int[] arr01 = { 5, 4, 10, 2, 7, 6, 12 };
            int[] arr02 = new int[10];

            Array.Sort(arr01);

            foreach (int i in arr01)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("-------------------------------------");

            Array.Copy(arr01, 0, arr02, 0, 4);


            foreach (int i in arr02)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("-------------------------------------");

            Array.Clear(arr02);

            foreach (int i in arr02)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("-------------------------------------");

            Array.ConstrainedCopy(arr01, 5, arr02, 3, 1);

            foreach (int i in arr02)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("-------------------------------------");

            // int[] arr03  = (int[])  Array.CreateInstance(typeof(int) , 10);
            // int[,] arr04  = (int[,])  Array.CreateInstance(typeof(int) , 2 , 4);

            // int[,] arr05 = (int[,])Array.CreateInstance(typeof(int), 2, 4 , 3);


            Array.IndexOf(arr01, 10); // return index of 10

            Array.LastIndexOf(arr01, 10); //  return Last index of 10

            Console.WriteLine("-------------------------------------");

            #endregion


            #region Member Method

            int[] nums01 = { 1, 2, 3, 4 };
            int[] nums02 = new int[nums01.Length];


            nums01.CopyTo(nums02, 0);

            foreach (int i in nums02)
            {
                Console.Write($"{i} ");
            }
            // --------------------------------------------------

            Console.WriteLine(nums01.GetLength(0)); // 4
            Console.WriteLine(nums01.GetValue(3)); // 4
            nums01.SetValue(100, 1); // 4
            Console.WriteLine(nums01.GetValue(1));

            #endregion


            #endregion

            #endregion



        }
    }
}