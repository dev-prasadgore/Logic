using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Logic.Code
{
    internal class Patterns
    {
        //36. Right Triangle → rows, print row count stars
        public void Logic36()
        {
            int row = 3;
            for (int i = 1; i <= row; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        //37.Inverted Triangle → decreasing stars
        public void Logic37()
        {
            int row = 3;
            for(int i = row; i > 0; i--)
            {
                for(int j=i;j>0;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void Logic38() {

             
        
        }
            //38.Pyramid → spaces + stars
            //39. Inverted Pyramid → reverse pyramid
            //40.Diamond → pyramid + inverted pyramid
            //41.Number Triangle → print 1..row
            //42. Reverse Number Triangle → decreasing numbers
            //43.Floyd Triangle → running counter
            //44.Pascal Triangle → combination formula
            //45.Hollow Square → borders only
            //46.Hollow Pyramid → edges only
            //47.X Pattern → i==j or i + j == n - 1
            //48. Butterfly → left stars +spaces + right stars
            //49. Sandglass → shrink then expand
            //50. Hourglass → inverted + normal pyramid

    }
}
