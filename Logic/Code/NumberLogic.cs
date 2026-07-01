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
        public void Logic19() {
            int number = 12345;
            int count=0;
          
            while (number > 0)
            {
                number = number / 10;
                count++;
            }
            Console.WriteLine("Count " + count);

        
        }
        //20. Reverse Number → extract digits and rebuild
        public void Logic20() {
            int number = 12345;
            int rev = 0;

            while (number > 0)
            {
                int digit = number % 10;
                rev = rev * 10 + digit;
                number = number / 10;
            }
            Console.WriteLine("rev " + rev);

        }
        //21.Palindrome Number → reverse and compare
        public void Logic21() {
            int number = 12321;
            int rev=0;
            int temp = number;
            while (number > 0)
            {
                int digit= number % 10;
                rev = rev * 10 + digit;
                number = number / 10;
            }
            if(temp == rev)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Not");
            }
        
        }
        //22. Sum Digits → repeatedly add last digit
        public void Logic22() {
            int Number = 123456789;
            int sum = 0;
            while (Number > 0)
            {
                int digit= Number % 10;
                sum += digit;
                Number = Number / 10;
            }
            Console.WriteLine("Sum" + sum);
        
        }
        //23.Product Digits → repeatedly multiply last digit
        public void Logic23()
        {
            int Number = 123456789, product=1;

            while (Number > 0)
            {
                int digit = Number % 10;
                Number = Number / 10;
                product = product * digit;
            }

            Console.WriteLine("Product " + product);
        }
        //24.Armstrong → sum of digits ^ digitCount
        public void Logic24() {
            int Number = 153, sum = 0;
            int lenth = 0;
            int temp = Number;

            int check = Number;
            while(temp > 0)
            {
                lenth++;
                temp = temp / 10;
            }
            while (Number > 0)
            {
                int digit=Number % 10;
                Number /= 10;

                int value = 1;
                for(int i = 0; i < lenth; i++)
                {
                    value = value * digit;
                }
                sum = sum + value;
            }
            if (check == sum)
            {
                Console.WriteLine("Number is arm");
            }
            else
            {
                Console.WriteLine("Mot");
            }

        }
        //25. Perfect Number → sum factors excluding self
        public void Logic25() {
            int Number = 28;
            int Sum = 0;
        
            for(int i=1; i <= Number / 2; i++)
            {
                if(Number % i == 0)
                {
                    Sum = Sum + i;
                }
            }
            if(Sum == Number)
            {
                Console.WriteLine("Perfect");
            }
            else
            {
                Console.WriteLine("Not Perfect");
            }
        
        }
        //26.Strong Number → sum factorials of digits
        public void Logic26() {
            int number = 145;
            int Original = number;
            int Sum = 0;
            while(number > 0)
            {
                int digit=number % 10;
                number = number / 10;
                int fact = digit;
                for(int i = digit-1; i >0; i--)
                {
                    fact = fact * i;
                }
                Sum = Sum + fact;

            }
            if (Original == Sum)
            {
                Console.WriteLine("Strong");
            }
            else
            {
                Console.WriteLine("Not Strong");
            }
        
        }
        //27.Automorphic → square ends with original number
        public void Logic27() {

            int Number = 0;
            int tempNumber=Number;
            int tempSquare = Number * Number;
            bool isAutomorphic = true;
            while(tempNumber > 0)
            {
                int digit=tempNumber % 10;
                tempNumber = tempNumber / 10;
                int SquareDigit = tempSquare % 10;
                tempSquare = tempSquare / 10;
                if (digit != SquareDigit)
                {
                    isAutomorphic = false;
                    break;
                }
                
            }
            Console.WriteLine(isAutomorphic ? $"{Number} is Automorphic" : $"{Number} is not");
        }
        //28. Harshad → divisible by sum of digits
        public void Logic28() {

            int number = 19;//24
            int tempNumber = number;
            int sum = 0;
            while (tempNumber > 0)
            {
                int digit=tempNumber % 10;
                tempNumber /= 10;
                sum += digit;
            }
            Console.WriteLine(number % sum == 0 ? $"{number} is harshad Number":$"{number} is not harshad Number");
        
        }
        //29. GCD → Euclidean algorithm
        public void Logic29() {

            int num1 = 18;
            int num2 = 48;
            while (true)
            {
                int remainder = num1 % num2;
                if (remainder == 0)
                {
                    Console.WriteLine($"GCD is {num2}");
                    break;
                }
                num1=num2;
                num2 = remainder;
            }
           
        }
        //30.LCM → `(a* b)/GCD`
        public void Logic30() {
            int num1 = 18;
            int num2 = 48;
            int originalNum1 = num1;
            int OriginalNum2=num2;
            int GCD = 0;
            while (true)
            {
                int remainder=num1 % num2;
                if(remainder == 0)
                {
                    GCD = num2;
                    break;
                }
                num1 = num2;
                num2 = remainder;
            }
            Console.WriteLine($"LCM={(originalNum1 * OriginalNum2) / GCD}");
        }
        //31. Power → repeated multiplication
        public void Logic31() {
            int Number = 2;
            int Power = 3;
            int output = 1;
            for(int i=Power; i>0; i--) {
                output = output * Number;
            }
            Console.WriteLine(output);
        
        }
        //32.Decimal → Binary → divide by 2 repeatedly
        public void Logic32() {
            int num = 13;
            int output=0;
            int binary=0;
            while (num > 0)
            {
                int reminder = num % 2;
                num /= 2;
                output = output * 10 + reminder;
            }
            while(output > 0)
            {
                int reminder = output % 10;
                output /= 10;
                binary = binary * 10 + reminder;
            }
            Console.WriteLine($"Binary {binary}");
        
        }
        //33. Binary → Decimal (Cheated)
        public void Logic33()
        {
            int binary = 1101;
            int tempBinary = binary;

            int decimalNumber = 0;
            int power = 0;

            while (tempBinary > 0)
            {
                // Get the last binary digit (0 or 1)
                int digit = tempBinary % 10;

                // Calculate 2^power manually
                int value = 1;
                for (int i = 0; i < power; i++)
                {
                    value *= 2;
                }

                // Add digit × 2^power
                decimalNumber += digit * value;

                // Increase the power for the next digit
                power++;

                // Remove the last digit
                tempBinary /= 10;
            }

            Console.WriteLine($"Decimal Number = {decimalNumber}");
        }
        //34. Count Even Digits → digit%2==0
        public void Logic34() {

            int number = 12345678, count = 0;
            while (number > 0)
            {
                int digit = number % 10;
                number = number / 10;
                if (digit % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Even Count" + count);
        }
        //35. Count Odd Digits → digit%2!=0
        public void Logic35() {
            int number = 12345678, count = 0;
            while (number > 0)
            {
                int digit = number % 10;
                number = number / 10;
                if (digit%2 !=0)
                {
                    count++;
                }
            }
            Console.WriteLine("Odd Count" + count);
        
        }
    }
}
