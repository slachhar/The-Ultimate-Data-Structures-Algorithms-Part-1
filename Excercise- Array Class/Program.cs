using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Excercise__Array_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Array numbers = new Array(3);
            numbers.insert(10);
            numbers.insert(20);
            numbers.insert(30);
            numbers.insert(40);
            numbers.insert(50);
            numbers.insert(60);
            numbers.print();
            numbers.removeAt(2);
            numbers.print();
            numbers.removeAt(1);
            numbers.print();
            numbers.removeAt(3);
            numbers.print();
            Console.WriteLine(numbers.indexOf(20));
            Console.WriteLine(numbers.indexOf(40));
            Console.WriteLine(numbers.max());
            Array array2 = new Array(4);
            array2.insert(20);
            array2.insert(30);
            array2.insert(50);
            Console.WriteLine(string.Join(",",numbers.intersect(array2)));
            numbers.reverse();
            numbers.print();
            numbers.insertAt(33, 1);
            numbers.print();
            Console.ReadLine();
        }
    }

    public class Array
    {
        private int defaultCapacity = 5;
        private int[] intArray;
        private int count = 0;
        public Array(int capacity)
        {
            intArray = new int[capacity];
        }

        public Array()
        {
            intArray = new int[defaultCapacity];
        }

        public void insert(int value)
        {
            if (count == intArray.Length)
            {
                int[] largerArray = new int[intArray.Length * 2];
                System.Array.Copy(intArray, largerArray, intArray.Length);
                intArray = largerArray;
            }

            intArray[count++] = value;
        }

        public void removeAt(int index)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine(new ArgumentException("illegal argument"));
            }

            for (int i = index; i < count; i++)
            {
                if (i + 1 == count)
                {
                    intArray[i] = 0;
                }
                else
                {
                    intArray[i] = intArray[i + 1];
                }
            }

            count--;

        }

        public int indexOf(int value)
        {
            int index = 0;
            foreach (var valueArray in intArray)
            {
                if (value == valueArray)
                    return index;
                index++;
            }

            return -1;
        }

        public void print()
        {
            for (int index = 0; index < count; index++)
            {
                Console.Write(intArray[index] + ",");
            }
            Console.WriteLine();
        }

        public int max()  //// O(n)
        {
            int largestNum = intArray[0];
            for (int index = 0; index < count; index++)
            {
                if (intArray[index] > largestNum)
                    largestNum = intArray[index];
            }

            return largestNum;
        }

        public int[] intersect(Array array2)  ///O(n^2)
        {
            int[] commonInts = new int[count];
            int newCount = 0;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < array2.count; j++)
                {
                    if (intArray[i] == array2.intArray[j])
                    {
                        commonInts[newCount] = intArray[i];
                        newCount++;
                        break;
                    }
                }
            }

            return commonInts;
        }

        public void reverse()   ///O(n)
        {
            int[] reverseInts = new int[count];
            for (int i = count-1, j = 0; i >= 0; i--, j++)
            {
                reverseInts[j] = intArray[i];
            }

            intArray = reverseInts;
        }

        public void insertAt(int item, int index)
        {
            if (index < 0 || index >= intArray.Length - 1)
            {
                throw new ArgumentException("Invalid arguments");
            }

            if (count == intArray.Length)
            {
                int[] largerArray = new int[intArray.Length * 2];
                System.Array.Copy(intArray, largerArray, intArray.Length);
                intArray = largerArray;
            }

            for (int i = count; i > index; i--)
            {
                intArray[i] = intArray[i-1];
            }

            intArray[index] = item;
            count++;
        }
    }
}
