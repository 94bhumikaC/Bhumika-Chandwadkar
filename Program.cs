using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_BhumikaC
{
    class Program
    {

        static Boolean Triangle(long a, long b, long c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }
            long[] vector = { a, b, c };
            Array.Sort(vector);
            a = vector[0];
            b = vector[1];
            c = vector[2];

            if (a + b <= c)
            {
                return false;
            }

            long p1 = a, p2 = c - b;

            long div = ABC(p1, p2);
            p1 /= div;
            p2 /= div;

            long q1 = c + b, q2 = a;

            div = ABC(q1, q2);
            q1 /= div;
            q2 /= div;

            return (p1 == q1 && p2 == q2);
        }

        static long ABC(long a, long b)
        {
            if (b == 0)
            {
                return a;
            }
            return ABC(b, a % b);

        }

        static string checkRightAngleTriangle(long a, long b, long c)
        {
            if (Triangle(a, b, c))
            {
                return "Right angle triangle";


            }
            else if ((a == b) && (b == c) && (c == a))
            {
                return "It is equilateral triangle ";
            }
            else if ((a == b) && (b == c) || (b == c)&&(c == a))
            {
                return "It is isosceles  triangle ";
            }
            else
            {
                return "Invalid triangle";
            }

        }

        static void Main(string[] args)
        {
            long a = 70, b = 70, c = 70;
            Console.WriteLine(checkRightAngleTriangle(a, b, c));
            // a = 8; b = 13; c = 5;
            // Console.WriteLine(checkRightAngleTriangle(a, b, c));
            Console.ReadLine();

        }
    }
}
