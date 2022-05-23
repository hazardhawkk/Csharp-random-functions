using System;
namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = {234,4233,3424,42,321,1};
            //int[,] TwoDeeArr = { { 2, 3, 4 }, { 5, 6, 7 }, { 8, 9, 10 }, { 24, 25, 27 } };
            //BubbleSort(nums);
            //TimesTable(5);
            //Print2DArray(TwoDeeArr,4,3);
            //RecursiveCountUp(1);
            //int[] arr = { 2, 4, 3, 5, 6, 9, 1, 20, 25 };
            //Console.WriteLine(FindLowerBound(arr, 30)); 
            //Console.WriteLine(RecursiveContains(2, arr, 0)); 
            //int[] arrr = {4,7,34,4,3,2,5,12,7};
            //RecursiveBinaryContains(3, arrr, 0, 8);
            




            Console.ReadLine();
        }




        static int NumberOfMonth(string inpMonth)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };



            int i = 0;
            while (i < months.Length && inpMonth != months[i] )
            {
                i++;
            }
            if(i == months.Length)
            {
                return -1;
            }
            int inpMonthNum = i + 1;

            return inpMonthNum;
        }

        static int NumberOfMonth2(string inpMonth)
        {
            

            switch (inpMonth)
            {
                case "January":
                    return 1;
                    break;
                case "February":
                    return 2;
                    break;
                case "March":
                    return 3;
                    break;
                case "April":
                    return 4;
                    break;
                case "May":
                    return 5;
                    break;
                case "June":
                    return 6;
                    break;
                case "July":
                    return 7;
                    break;
                case "August":
                    return 8;
                    break;
                case "September":
                    return 9;
                    break;
                case "October":
                    return 10;
                    break;
                case "November":
                    return 11;
                    break;
                case "December":
                    return 12;
                    break;
                default:
                    return -1;
                    break;
            }
           
        }
        static void PrintOneAtATime(char[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }

        static void PrintInReverse(char[] input)
        {
            
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(input[i]);
            }
        }
        static string Contains(char[] chars, char ch)
        {
            int i = 0;
            while (i < chars.Length && ch != chars[i])
            {
                i++;
            }
            if (i == chars.Length) //gone through the whole array in the loop and not found ch in chars
            {
                return "No";
            }

            return "Yes"; //broke out of the loop because of the second condition so ch is equal to chars[i]

        }

        static string Contains2(char[] chars, char ch)
        {
            foreach (char letter in chars)
            {
                if(ch == letter)
                {
                    return "Yes";
                }
            }
            return "No";
        }

        static void BubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length -1; i++) //arr.length - 1 because max number of passes are n-1
            {

                for (int j = 0; j < arr.Length - (1 + i); j++)  //arr.length -1 because we are checking j and j+1 so must stay in bound
                {                                             //-i because after each pass the next last element is in correct position so doesnt have to be checked
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                    }
                }
            }

            foreach(int el in arr)
            {
                Console.WriteLine(el);
            }


        }

        /*static void Quicksort(int[] arr)
        {
            double pivotIndex = (arr.Length + 1) / 2;  
            pivotIndex = Math.Ceiling(pivotIndex) - 1;//arr[pivotIndex] is the number which is the pivot point
            foreach (int num in arr)
            {
                if (num > arr[pivotIndex])
                {

                }
            }
        }*/

        /*static void Intersection(int [] arr1, int[] arr2)
        {

        }*/

        static void PrintDeck()
        {
            string[] suits = { "clubs", "spades", "hearts", "diamonds", "gold", "brains", "limbs", "hawks"};
            char[] values = "A23456789TJQK".ToCharArray();

            foreach (string el in suits)
            { 
                foreach(char ele in values)
                {
                    Console.WriteLine(ele + " of " + el);
                }
                Console.WriteLine();
            }


        }

        static void TimesTable(int table)
        {
            for(int i = table; i <= table*10;i = i + table)
            {
                Console.WriteLine(i);
            }
        }

        /*static int FindSmallestInArray(int[] arr)
        {
            for(int i = 0; i<arr.Length;i++)
            {
                if arr[i]
            }
        }*/

        /*static void FindSmallestIn2DArray(int[,] arr)
        {

        }*/

        /*static void NaughtsAndCrosses()
        {
            char[,] Board = 
            { {' ',' ',' '}, 
              {' ',' ',' '},    //rows,collums
              {' ',' ',' '} 
            };

            char playerChar;           
            char enemyChar;
            bool invalidInput = false;
            do
            {
                Console.WriteLine("Pick o or x (no caps)");               //picking o or x
                playerChar = Convert.ToChar(Console.ReadLine());
   
                if (playerChar == 'o')
                {
                    enemyChar = 'x';
                    invalidInput = false;
                }
                else if (playerChar == 'x')
                {
                    enemyChar = 'o';
                    invalidInput = false;
                }
                else { Console.WriteLine("Invalid input!"); invalidInput = true;}
            } while (invalidInput == true);




            bool endGame = false;
            while (endGame == false)
            {

                for (int rows = 0; rows < 3; rows++)                       //printing board
                {
                    for (int collumns = 0; collumns < 3; collumns++)
                        Console.Write("|" + Board[rows, collumns] + "|");
                    Console.WriteLine("\n -----------");
                }

                Console.Write("Enter move coordinates in format row,collumn:");  //player's move
                Console.ReadLine();
            }*/

        static void Print2DArray(int[,] arr, int rows, int collumns)
        {
            for (int i=0; i < rows; i++)
            {
                for (int j = 0; j < collumns; j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }
        }

        static int FindMinimumBins(int[] arr, int capacity)
        {
            int sumOfArr = 0;
            foreach (int el in arr)  //sum of all nums / capacity of one bin
            {
                sumOfArr = sumOfArr + el;
            }
          
            double unroundedLowerBound = sumOfArr / capacity;
            
            var lowerBound = Convert.ToInt32(Math.Ceiling(unroundedLowerBound));
            return lowerBound;
            
        }

        static void VeryBadBinPackFirstFitKindOf(int capacity, int[] arr)
        {
            int lowerBound = FindMinimumBins(arr, capacity);

            //creating array of required size where rows represent bins, the lower bound is the optimal number of bins
            int[,] binsArr = new int[lowerBound, arr.Length]; //length of arr is the max amount of numbers in a single bin


            //first fit on remaining nums
            int tempNum = 0;
            int arrI = 0;
            int collumn = 0;
            for (int row = 0; row < lowerBound; row++)
            {
                for (int tempSum = 0; tempSum + tempNum <= capacity; tempSum = tempSum + tempNum) //for loop checks condition first
                {
                    if (arrI < arr.Length)
                    {
                        tempNum = arr[arrI]; 
                        binsArr[row, collumn] = tempNum;
                        arrI++;
                        collumn++;
                    }
                }
                collumn = 0;
            }
            Print2DArray(binsArr, lowerBound, arr.Length);
        }      

        static void RecursiveCountUp(int startNum)
        {
            Console.WriteLine(startNum);
            RecursiveCountUp(startNum+1);
        }

        static bool RecursiveContains(int num, int[] arr, int i) //i must be zero for first iteration
        {
            if(arr[i] == num)
            {
                return true;
            }
            else if(i >= arr.Length)
            {
                return false;
            }
   
            return RecursiveContains(num, arr, i++);
        }

        static bool RecursiveBinaryContains(int num, int[] arr, int startI, int endI)
        {
            int middleI = (startI + endI)/2;

            
            if (arr[middleI] == num)
            {
                return true;
            }

            if (startI == endI)
            {
                return false;
            }

            if (arr[middleI] > num)
            {
                return RecursiveBinaryContains(num, arr, startI, middleI-1 );
            }

            return RecursiveBinaryContains(num, arr, middleI+1, endI); //arr[middleI] < num
            
        }

        static void ShuffleArray(int[] arr)
        {
            int temp;
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int randomI = rand.Next(arr.Length-1);
                temp = arr[i];
                arr[i] = arr[randomI];
                arr[randomI] = temp;
            }
            foreach (int item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
 
    }




    
}
