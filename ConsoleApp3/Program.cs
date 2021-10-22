using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //printnumberswithoutloop(1, 100);
            //int[] arr=sortarray();
            //for reversing array
            //reversearray(arr);

            //sumofprevious2elementsinarray();

            //Console.WriteLine(ConversionFunction("123"));
            //findSum(1234);
            //Console.WriteLine(findSum(1234));

            //Swapping Two Variables Without Using Third
            //int a = 5, b = 10;
            //Console.WriteLine("Before swap a= " + a + " b= " + b);
            //a = a * b; //a=50 (5*10)      
            //b = a / b; //b=5 (50/10)      
            //a = a / b; //a=10 (50/5)    
            //Console.Write("After swap a= " + a + " b= " + b);


            //Palindrom string

            //string s, revs = "";
            //Console.WriteLine(" Enter string");
            //s = Console.ReadLine();
            //for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
            //{
            //    revs += s[i].ToString();
            //}
            //if (revs == s) // Checking whether string is palindrome or not  
            //{
            //    Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            //}
            //else
            //{
            //    Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            //}
            //Console.ReadKey();

            //multiple two numbers without using * operator

            //int num1, num2;  //input numbers  
            //Console.WriteLine("Enter first number");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= num2; i++) //add 1 num times the second number 
            //{
            //    num1 += num1;
            //}
            //Console.WriteLine("Product= " + num1);

            //Repeated Characters
            RepeatedCharsString();
        }
        static string str = "proffession";
        static int n = str.Length;
        static string dupstr = "";
        static int cnt = 0;
        public static void RepeatedCharsString()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (str[i] == str[j])
                    {
                        dupstr = dupstr + str[i];
                        cnt = cnt + 1;
                    }
                }
            }
            Console.WriteLine("Repeated chars are: " + dupstr);
            Console.WriteLine("No of repeated chars are: " + cnt);
        }
        public static int ConversionFunction(string value)
        {
            int number = 0;
            for (int i = 0; i < value.Length; i++)
            {
                number = number * 10 + ((int)value[i] - 48);
            }
            return number;
        }

        public static void sumofprevious2elementsinarray()
        {
            int[] array = new int[20]; //array size 20
            array[0] = 0;//first element in array is 0
            array[1] = 1;//second element in array is 1

            for (int i = 1; i < 20; i++)//loop starts from 1 and goes until 19
            {
                //Console.WriteLine(array[i - 1]);//1
                //Console.WriteLine(array[i - 2]);//0
                //Console.WriteLine("sum of "+array[i - 1]+array[i-2]);

                array[i] = array[i - 1] + array[i - 2];//sum of previous 2 element values in array and save it into current array variable

                Console.WriteLine(array[i]);//print that value
            }

        }
        public static int[] sortarray()
        {
            int[] list = { 45, 78, 22, 96, 10, 87, 68, 2 };
            for (int i = 1; i < list.Length; i++)
            {
                //Console.WriteLine(list[i]);//starting from 78
                //Console.WriteLine(list[i - 1]);//starting from 45
                if (list[i] < list[i - 1])
                {
                    list[i] = list[i] + list[i - 1];
                    list[i - 1] = list[i] - list[i - 1];
                    list[i] = list[i] - list[i - 1];
                    i = 0;
                }
            }
            Console.WriteLine("Sorted array is : ");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i] + " ");
            }
            return list;
        }
        static int findSum(int N)
        {
            if (N < 10)
                return N;

            int sum = 0;
            while (N > 0)
            {
                sum += N % 10;
                N = N / 10;
            }
            return findSum(sum);
        }
        public static void reversearray(int[] arr)
        {
            int[] secondhighest = new int[arr.Length];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Reverse array is : " + arr[i]);
                if (i == 2)
                {
                    Console.WriteLine("Second Highest Value is : " + arr[1]);

                }
            }

            //Console.WriteLine("Second Highest Value" + secondhighest[1]);

        }
        public static void printnumberswithoutloop(int start, int condition)
        {
            if (start <= condition)
            {
                Console.WriteLine(start);
                start++;
                printnumberswithoutloop(start, condition);
            }
        }
    }
}
