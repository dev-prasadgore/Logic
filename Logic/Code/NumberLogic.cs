using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Code
{
    public class NumberLogic
    {
        // 16. Prime → check divisibility 2 to √n.
        public void Logic16() {
            Console.WriteLine("Enter Number to check Prime Number or not");
            int.TryParse(Console.ReadLine(), out int Num);
            bool isPrime = true;
            for (int j = 2; j < Num; j++)
            {
                if (Num % j == 0)
                {
                    isPrime = false;
                    break;
                }

            }
            Console.WriteLine(isPrime ? $"{Num} is PRime" : $"{Num} is not PRime");
        }
        //17. Prime 1..N → call prime logic repeatedly.
        public void Logic17() {
            Console.WriteLine("Enter Number Till You want Prime Number");
            int.TryParse(Console.ReadLine(), out int Num);

            for (int i = 3; i <= Num; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write($" {i}");
                }

            }
        }
        //18.Fibonacci → next = a+b
        public void Logic18() {

            int numInit = 0;
            int numNext=1;
            int numEnd = 35;

            while (numNext < numEnd)
            {
                numInit = numNext;
                numNext = numNext + numInit;
                Console.WriteLine(numNext);
            }
        
        }
        //19. Count Digits → repeatedly divide by 10
        public void Logic19() { }
        //20. Reverse Number → extract digits and rebuild
        public void Logic20() { }
        //21.Palindrome Number → reverse and compare
        public void Logic21() { }
        //22. Sum Digits → repeatedly add last digit
        public void Logic22() { }
        //23.Product Digits → repeatedly multiply last digit
        public void Logic23() { }
        //24.Armstrong → sum of digits ^ digitCount
        public void Logic24() { }
        //25. Perfect Number → sum factors excluding self
        public void Logic25() { }
        //26.Strong Number → sum factorials of digits
        public void Logic26() { }
        //27.Automorphic → square ends with original number
        public void Logic27() { }
        //28. Harshad → divisible by sum of digits
        public void Logic28() { }
        //29. GCD → Euclidean algorithm
        public void Logic29() { }
        //30.LCM → `(a* b)/GCD`
        public void Logic30() { }
        //31. Power → repeated multiplication
        public void Logic31() { }
        //32.Decimal→Binary → divide by 2 repeatedly
        public void Logic32() { }
        //33. Binary→Decimal → powers of 2
        public void Logic33() { }
        //34. Count Even Digits → digit%2==0
        public void Logic34() { }
        //35. Count Odd Digits → digit%2!=0
        public void Logic35() { }
    }
}
