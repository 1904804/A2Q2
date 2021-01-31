using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            double vectorValue;
            double vectorNormalized;

            Console.WriteLine("Please enter the value of the vector you wish to be normalized - ");
            vectorValue = Convert.ToDouble(Console.ReadLine());

            if ( vectorValue == 0)//to ajust is zero is entered
            {
                //function to calculate normlized value and value is ajusted to cope a zero entry
                vectorValue = vectorValue + 1;
                vectorNormalized = vectorValue / vectorValue;
                Console.WriteLine("The normalized value of the vector you entered is - " + vectorNormalized);

            }else
            {
                vectorNormalized = vectorValue / vectorValue;
                Console.WriteLine("The normalized value of the vector you entered is - " + vectorNormalized);
            }
        }
    }
}
