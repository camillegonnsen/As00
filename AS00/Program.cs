using System;

namespace AS00
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UserInputIsLeapYear();
        }

 
        public static bool IsLeapYear(int year){
            if(year%4 == 0){
                if(year%100 != 0 || year%400 == 0)
                return true;
            }else {
                return false;
            }
            return false;
        }

        public static void UserInputIsLeapYear(){
            try{

                int input = Convert.ToInt32(Console.ReadLine());

                if(input < 1582){
                    throw new ArgumentException("The year has to be 1582 or bigger");
                }

                if(IsLeapYear(input)){
                    Console.WriteLine("yay");
                }else{
                    Console.WriteLine("nay");
                }

            }catch(ArgumentException e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
