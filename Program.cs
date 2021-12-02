using System;

namespace Code__1
{
    class Program
    {
        static void Main(string[] args)
        {

            Double num01;
            Double num02;
            Double num03;
            

            System.Console.WriteLine("Good Morning, What numbers would you like to find the average of");

            System.Console.WriteLine("Number 1: ");
            num01 = Convert.ToDouble(System.Console.ReadLine() );

            System.Console.WriteLine("Number 2: ");
            num02 = Convert.ToDouble(System.Console.ReadLine() );

            System.Console.WriteLine("Number 3: ");
            num03 = Convert.ToDouble(System.Console.ReadLine() );

            Double average = (num01 + num02 + num03) / 3;
  

            System.Console.WriteLine("The Average is: " + average);

        
        
        }
    }
}
