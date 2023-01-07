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
            return a * a;
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
            return a % 2 == 0;
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
            if (a % a == 0 && a % 2 == 0)
            {
                return false;
            }
            return true;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> primeNumbersList = new List<int>();
            for (int i = 1; i <= a; i++)
            {
                if (IsPrimary(i))
                    primeNumbersList.Add(i);
            }
            return primeNumbersList;
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
            if (list.Count == 1) return true;
            else for (int i = 1; i < list.Count; i++)
                {
                    if (IsInOrder(list[i - 1], list[i]) == -1) return false;
                }
            return true;
        }



        public static object Sort(List<int> toSort)
        {
            List<int> sortedList = new List<int>();
            int listExpectedCount = toSort.Count;
            int currentLowest;
            while (sortedList.Count != listExpectedCount)
            {
                currentLowest = toSort[0];
                for (int i = 1; i < toSort.Count; i++)
                {
                    if (currentLowest > toSort[i]) ;
                    currentLowest = toSort[1];
                }
                sortedList.Add(currentLowest);
            }
            return sortedList;
        }
        public static object GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            throw new NotImplementedException();
        }
    }
}
