using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace Logic.Code
{
    internal class Arrays
    {
        public Arrays()
        {
            Console.WriteLine("### Arrays ###");
        }
        //71. Find Maximum → traverse and update max.
        public void Logic71()
        {
            Console.WriteLine("//71. Find Maximum → traverse and update max.");
            int[] numberArray = { 4, 6, 10, 2, 3, 8, 5 };
            int max = numberArray[0];
            for (int i = 1; i < numberArray.Length; i++)
            {
                if (numberArray[i] > max)
                {
                    max = numberArray[i];
                }
            }
            Console.WriteLine($"max of array is {max}");
        }
        //72.Find Minimum → traverse and update min.
        public void Logic72()
        {
            Console.WriteLine("//72.Find Minimum → traverse and update min.");
            int[] numberArray = { 4, 6, 10, 2, 3, 8, 5 };
            int min = numberArray[0];
            for (int i = 1; i < numberArray.Length; i++)
            {
                if (numberArray[i] < min)
                {
                    min = numberArray[i];
                }
            }
            Console.WriteLine($"min of array is {min}");
        }
        //73.Sum Array → accumulate.
        public void Logic73()
        {
            Console.WriteLine("//73.Sum Array → accumulate.");
            int[] numberArray = { 4, 6, 10, 2, 3, 8, 5 };
            int sum = 0;
            for (int i = 1; i < numberArray.Length; i++)
            {
                sum = sum + numberArray[i];
            }
            Console.WriteLine($"Sum of elements of array is {sum}");
        }
        //74. Average → sum/count.
        public void Logic74()
        {
            Console.WriteLine(" //74. Average → sum/count.");
            int[] numberArray = { 4, 6, 10, 2, 3, 8, 5 };
            int sum = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                sum += numberArray[i];
            }
            Console.WriteLine($"Average of array element is {sum / numberArray.Length}");
        }
        //75. Count Even → num%2==0.
        public void Logic75()
        {
            Console.WriteLine("//75. Count Even → num%2==0.");
            int[] numberArray = { 4, 6, 10, 2, 3, 8, 5 };
            int count = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Count of Even Numbers from array is {count}");
        }
        //76. Count Odd → num%2!=0.
        public void Logic76()
        {
            Console.WriteLine("//76. Count Odd → num%2!=0");
            int[] numberArray = { 4, 6, 10, 2, 3, 8, 5 };
            int count = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Count of odd Numbers from array is {count}");

        }
        //77. Second Largest → track largest &second
        public void Logic77()
        {
            Console.WriteLine("//76. Count Odd → num%2!=0");
            int[] numberArray = { 4, 6, 10, 2, 3, 8, 5, 12, 1, 12 };
            int First_Largest = 0;
            int Second_Largest = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] > First_Largest)
                {
                    Second_Largest = First_Largest;
                    First_Largest = numberArray[i];
                }
                else if (numberArray[i] > Second_Largest && numberArray[i] != First_Largest)
                {
                    Second_Largest = numberArray[i];
                }
            }
            Console.WriteLine($"First Largest is {First_Largest} and second largest is {Second_Largest}");
        }
        //78. Second Smallest → track smallest &second
        public void Logic78()
        {
            Console.WriteLine("//76. Count Odd → num%2!=0");
            int[] numberArray = { 4, 6, 10, 2, 3, 8, 5, 12, 1, 12, 2 };
            int First_Smallest = numberArray[0];
            int Second_Smallest = numberArray[1];
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] < First_Smallest)
                {
                    Second_Smallest = First_Smallest;
                    First_Smallest = numberArray[i];
                }
                else if (numberArray[i] < Second_Smallest && numberArray[i] != First_Smallest)
                {
                    Second_Smallest = numberArray[i];
                }
            }
            Console.WriteLine($"First smallest is {First_Smallest} and second is{Second_Smallest}");

        }
        //79. Reverse Array → swap ends inward
        public void Logic79()
        {
            Console.WriteLine("//79.Reverse Array → swap ends inward");
            int[] numberArray = { 4, 6, 10, 2, 3, 8, 5, 12, 1, 12, 2 };
            for (int i = 0; i < numberArray.Length / 2; i++)
            {
                int j = numberArray.Length - 1 - i;
                int temp = numberArray[i];
                numberArray[i] = numberArray[j];
                numberArray[j] = temp;

            }
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }

        }
        //80. Copy Array → loop/copy method
        public void Logic80()
        {
            Console.WriteLine("//80. Copy Array → loop/copy method");
            int[] source = { 4, 6, 10, 2, 3, 8, 5, 12, 1, 12, 2 };
            int[] destination = new int[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }
            for (int i = 0; i < destination.Length; i++)
            {
                Console.WriteLine(destination[i]);
            }
        }
        //81.Merge Arrays → append both
        public void Logic81()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6, 7 };
            int[] arr3 = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[arr1.Length + i] = arr2[i];
            }
            foreach (int item in arr3)
            {
                Console.WriteLine(item);
            }
        }
        //82.Remove Duplicates → HashSet
        public void Logic82()
        {
            int[] numberArray = { 4, 6, 10, 2, 3, 8, 5, 12, 1, 12, 2 };

            HashSet<int> uniqueNumbers = new HashSet<int>();

            for(int i = 0; i < numberArray.Length; i++) { 
             uniqueNumbers.Add(numberArray[i]);
            }
            foreach(int item in uniqueNumbers)
            {
                Console.WriteLine(item);
            }
        }
        //83. Rotate Left → shift left, first to end 
        public void Logic83()
        {
            Console.WriteLine("//83. Rotate Left → shift left, first to end");
            int[] numberArray = { 4, 6, 10, 2, 3, 8, 5, 12, 1, 12, 2 };
            int temp = numberArray[0];
            for(int i=0;i<numberArray.Length; i++) 
            {
                numberArray[i] = numberArray[i + 1];          
            }
            numberArray[numberArray.Length-1] = temp;
            foreach (int item in numberArray)
            { 
                Console.WriteLine(item);
            }
        }
        //84.Rotate Right → shift right, last to front
        public void Logic84()
        {
            Console.WriteLine("//84.Rotate Right → shift right, last to front");
            int[] numbers = { 1, 2, 3, 4 };
            int temp = numbers[numbers.Length - 1];
            for(int i= numbers.Length-1; i>0; i--) {
                numbers[i] = numbers[i - 1];
            }
        
            numbers[0] = temp;
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        //85.Linear Search → scan all elements
        public void Logic85()
        {
            Console.WriteLine("//85.Linear Search → scan all elements");
            int[] numbers = { 1, 2, 3, 4 };
            int numberToFind = 3;
            for(int i=0;i<numbers.Length; i++) {
                if(numbers[i] == numberToFind) {
                    Console.WriteLine($"{numberToFind} is on index{i}");
                    break;
                }
            }
        }
        //86. Binary Search → divide sorted array
        //87. Missing Number → expected sum -actual sum
        //88. Find Duplicates → frequency map
        //89.Find Unique → frequency=1
        //90. Array Equality → compare size and values
    }
}


