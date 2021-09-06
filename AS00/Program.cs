using System;

namespace AS00
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool IsLeapYear(int year){
            if(year%4 == 0){
                if(year%100 != 0 || year%400 == 0)
                return true;
            }else {
                return false;
            }

            return false;
        }
    }
}
