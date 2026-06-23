using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Code
{
    public class Basic_Logic
    {
        public Basic_Logic()
        {
            Console.WriteLine("Basic Logic");
        }
        //1. Even/Odd → `num % 2`.
        public void Logic1()
        {
            Console.WriteLine("//1. Even/Odd → `num % 2`.");
            Console.WriteLine("Enter a Number To check Even or odd");
            int a=Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is Even Number");
            }
            else
            {
                Console.WriteLine($"{a} is a Odd Number");
            }
            // Optimized Single Line
            // Console.WriteLine(a % 2 == 0 ? $"{a} is Even Number" : $"{a} is Odd Number");

        }
        //2. Positive/Negative/Zero → compare with 0.
        public void Logic2()
        {
            Console.WriteLine("//2. Positive/Negative/Zero → compare with 0.");
            Console.WriteLine("Enter a Number To check Positive, Negative or Zero");
            int a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine($"{a} is Zero");
            }
            else if (a > 0)
            {
                Console.WriteLine($"{a} is positive Number");

            }
            else if (a < 0)
            {
                Console.WriteLine($"{a} is a negative Number");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        //3. Largest of 2 → compare a and b.
        public void Logic3()
        {
            Console.WriteLine("//3. Largest of 2 → compare a and b.");
            Console.WriteLine("Enter value for Number One");
            int.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("Enter Value for number Two");
            int.TryParse(Console.ReadLine(), out int b);

            if (a > b)
            {
                Console.WriteLine($"{a} is Greater Number");
            }
            else
            {
                Console.WriteLine($"{b} is Greater Number");
            }

            //Console.WriteLine(a > b ? $"{a} is greater Number" : $"{b} is greater Number");

        }
        //4. Largest of 3 → keep max variable.
        public void Logic4()
        {
            Console.WriteLine("//4. Largest of 3 → keep max variable.");
            int a = 10, b = 15, c = 12;

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a is Greater");
                }
                else
                {
                    Console.WriteLine("c is Greater");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("b is Greater");
                }
                else
                {
                    Console.WriteLine("C is Greater");
                }
            }
        }
        //5. Smallest of 3 → keep min variable.
        public void Logic5()
        {
            Console.WriteLine("//5. Smallest of 3 → keep min variable.");
            int[] numbers = { 10, 13, 12 };
            int small = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > small)
                {
                    small = numbers[i];
                }
            }
            Console.WriteLine($"{small} is smallest int");
        }
        //6. Leap Year → `(year%400==0) || (year%4==0 && year%100!=0)`.
        public void Logic6()
        {
            Console.WriteLine("//6. Leap Year → `(year%400==0) || (year%4==0 && year%100!=0)`.");
            Console.WriteLine("Enter a Year Here");
            int.TryParse(Console.ReadLine(), out int year);
            if(year %400 == 0)
            {
                Console.WriteLine($"{year} is a Leap Year");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year");
            }
            //Console.WriteLine(year % 400 == 0 ? $"{year} is a Leap Year" : $"{year} is not leap year");
        }
        //7. Calculator → switch on operator.
        public void Logic7()
        {
            Console.WriteLine("//7. Calculator → switch on operator.");
            bool isLive=true;

            do
            {
                Console.WriteLine("Enter Value For First Number");
                int.TryParse(Console.ReadLine(), out int firstNumber);
                Console.WriteLine("Enter Value For Second Number");
                int.TryParse(Console.ReadLine(), out int secondNumber);
                Console.WriteLine("Enter operator from + - ");
                string ?oprator = Console.ReadLine();
                int output = 0;
                switch (oprator)
                {
                    case "+":
                        output = firstNumber + secondNumber;
                        break;
                    case "-":
                        output = firstNumber - secondNumber;
                        break;
                    default:
                        output = 0;
                        break;

                }

                Console.WriteLine($"Output is {output}");
                Console.WriteLine("Enter x to stop other key to Continue");
                string choice=Console.ReadLine();
                if(choice.ToLower() == "x")
                {
                    isLive = false;
                }
            } while(isLive);
            

        }
        //8. Swap with temp → temp=a; a=b; b=temp.
        public void Logic8()
        {
            Console.WriteLine("//8. Swap with temp → temp=a; a=b; b=temp.");
            Console.WriteLine("Enter a Value For First Number");
            int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter a Value For Second Number");
            int.TryParse(Console.ReadLine(), out int secondNumber);
            int temp;
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine($"Current value of FirstNumber is {firstNumber} and SecondValue is {secondNumber}");
        }
        //9. Swap without temp → arithmetic/tuple swap.
        public void Logic9()
        {
            Console.WriteLine("//9. Swap without temp → arithmetic/tuple swap.");
            int a = 10, b = 20;
            Console.WriteLine($"New old values are a={a},b={b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"New Swap values are a={a},b={b}");
        }
        //10. Multiplication Table → loop 1–10.
        public void Logic10()
        {
            Console.WriteLine("//10. Multiplication Table → loop 1–10.");
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"\nMultiplication Table For {i}");
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($" {i} * {j}={ i* j}");
                }
            }
        }
        
        //11. Sum 1..N → accumulate sum.
        public void Logic11()
        {
            Console.WriteLine("//11. Sum 1..N → accumulate sum.");
            Console.WriteLine("Sum 1..N → accumulate sum,Enter the Number");
            int.TryParse(Console.ReadLine(), out int End);
            int output = 0;
            for(int i=1; i <= End; i++)
            {
                output = output + i;
                //output += i;
            }
            Console.WriteLine($"Sum of 1 to {End} is {output}");
        }
        //12. Factorial → multiply 1..N.
        public void Logic12()
        {
            Console.WriteLine("//12. Factorial → multiply 1..N.");
            Console.WriteLine("Enter a Number To calculate Factorial");
            int.TryParse(Console.ReadLine(), out int Number);
            int Factorial = 1;
            if (Number == 0)
            {
                Console.WriteLine($"Factorial of {Number} is {Factorial}");
            }
            for(int i = Number; i >= 1; i--)
            {
                Factorial=Factorial * i;
            }
            Console.WriteLine($"Factorial of {Number} is {Factorial}");

        }
        //13. Square → n*n.
        public void Logic13()
        {
            Console.WriteLine("//13. Square → n*n.");
            Console.WriteLine("Enter a Number To calcualte Square");
            int.TryParse(Console.ReadLine(), out int Number);
            Console.WriteLine($"Square of {Number} is {Number * Number}");
        }
        //14. Cube → n*n*n.
        public void Logic14()
        {
            Console.WriteLine("//14. Cube → n*n*n.");
            Console.WriteLine("Enter a Number To calcualte Cube");
            int.TryParse(Console.ReadLine(), out int Number);
            Console.WriteLine($"Cube of {Number} is {Number * Number* Number}");
        }
        //15. Divisible by 5 & 11 → both remainders 0
        public void Logic15()
        {
            Console.WriteLine("//15. Divisible by 5 & 11 → both remainders 0");
            Console.WriteLine("Enter a Number");           
            int.TryParse(Console.ReadLine(), out int Number);
            Console.Write("Number Devide by 11 and 5 ");
            for (int i = 1; i <= Number; i++)
            {
                if (i % 5 == 0 && i % 11 == 0)
                {
                    Console.Write($" {i}");
                }
            }
        }
    }
}
