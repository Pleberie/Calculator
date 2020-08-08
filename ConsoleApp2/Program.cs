using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;


namespace ConsoleApp2
{
    
  public  class Program
    { 
        public static int Sum(int n1, int n2)
        {
            int total;
            total = n1 + n2;
            return total;
        }
        public static int Subtraction(int n1, int n2)
        {
            int total;
            total = n1 - n2;
            return total;
        }

        public static int Product(int n1, int n2)
        {
            int total;
            total = n1 * n2;
            return total;
        }

        public static int Devide(int n1, int n2)
        {
            int total;
            total = n1 / n2;
            return total;
        }
        
     public static void Main(string[] args)
        {
           string name = "Tyler";
           
           Console.WriteLine("Choose a option");
           Console.WriteLine("press 1 for Addition");
           Console.WriteLine("Press 2 for Subtraction");
           Console.WriteLine("Press 3 for Multiplication");
           Console.WriteLine("Press 4 for Devision \n");
           int readSelected = Convert.ToInt32(Console.ReadLine());
           Console.Write("First Number: ");
           int readFirst = Convert.ToInt32(Console.ReadLine());
           Console.Write("Second Number: ");
           int readSecond = Convert.ToInt32(Console.ReadLine());
           int Selected = 0;
           switch (readSelected)
           {
               case 1:
               {
                   Selected = Sum(readFirst, readSecond);
                   break;
               }
               case 2:
               {
                   Selected = Subtraction(readFirst, readSecond);
                   break;
               }
               case 3:
               {
                   Selected = Product(readFirst, readSecond);
                   break;
               }
               case 4:
               {
                   Selected = Devide(readFirst, readSecond);
                   break;
               }
               default:  
                   Console.WriteLine("Please Select 1, 2, 3 or 4");  
                   break;  
           }

            // Making and Writing data to a txt
           Console.WriteLine("The result is: " +  Selected);
           StreamWriter SW = new StreamWriter("../../../../newtxt.txt", true /*true would append true meaning instead of overwriting what was there before it will move to the next available lines  */);
           SW.WriteLine("user selected " + readSelected);
           SW.WriteLine("user chose firstNumber: " + readFirst);
           SW.WriteLine("user chose secondNumber: " + readSecond);
           SW.WriteLine("users answer was: " + Selected );
           SW.WriteLine(" \n");
           
           SW.Close(); 
           
           
           
           // Reading data from a txt
   /*        Console.WriteLine("Reading Data...");
           Console.WriteLine("Heres the data from the text file: \n");
           StreamReader sr = new StreamReader("../../../newtxt.txt");
           string readLine = sr.ReadLine();
           while (readLine != null)
           {
               Console.WriteLine(readLine);
               readLine = sr.ReadLine();
           } */
           Console.ReadKey();  
        }
    }
}