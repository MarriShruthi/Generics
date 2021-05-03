using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome To Generics");
            //Console.WriteLine("Maximum Number ");
            //Console.WriteLine(MaximumNumber.MaxIntNumber(3000, 2000, 1000));
            // Console.WriteLine(MaximumNumber.MaxIntNumber(100f, 200f, 300f));
            //string StringOutput = MaximumNumber.StringMaximumNumber("Apple", "Peach", "Banana");
            //Console.Read(StringOut);

             int[] Output = { 11, 22, 50, 60, 90 };
              Generic<int> genericint = new Generic<int>(Output);//create object using int data type
              genericint.PrintValue();
              Console.WriteLine();

              double[] Output1 = { 11.2, 22.5, 50.45, 55.92 };
              Generic<double> genericdouble = new Generic<double>(Output1);
              genericdouble.PrintValue();
              Console.WriteLine();

              //String array
              string[] stringArray = { "Apple", "Banana", "Mango"  };
              Generic<string> genericstring = new Generic<string>(stringArray);
              genericstring.PrintValue();
              Console.Read(); 
        }
    }      
}

