using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static Func<int, int, int> IsInOrderDesc { get; set; }

        public static int Power2(int a)
        {
            return a*a;
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static bool IsMajeur(int age)
        {
            if (age < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsEven(int a)
        {
            throw new NotImplementedException();
        }

        public static bool IsDivisible(int a, int b)
        {
            if ((a % b) == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsPrimary(int a)
        {
            if (a == 2)
            {
                return true;
            }
            if(a%a ==0 && a%2 == 0)
            {
                return false;
            }
            return true;
        }

        public static List<int> GetAllPrimary(int a)
        {
            throw new NotImplementedException();
        }

        public static int Power(int a, int b)
        {
            int c = a;
            for (int i = 1; i < b; i++)
            { 
                a *= c;
            }
            return a;
        }

        public static int IsInOrder(int a, int b)
        {
            if (a < b)
            {
                return 1;
            }
            if (a > b)
            {
                return -1;
            }
            if (a == b)
            {
                return 0;
            }
            throw new NotImplementedException();
        }

        public static bool IsListInOrder(List<int> list)
        {
            throw new NotImplementedException();
        }

        public static object Sort(List<int> toSort)
        {
            throw new NotImplementedException();
        }

        public static object GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            throw new NotImplementedException();
        }
    }
}
