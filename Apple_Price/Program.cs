using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abad_LAB1_EX
{
    internal class Program
    {
        static void Main(string[] args)

        {  //Welcome Note 
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("☺♠♣♥☺♠♣♥☺♠♣♥ Hello! Costumer, Good Day ! ☺♠♣♥☺♠♣♥☺♠♣♥ ");
            Console.WriteLine("Welcome to our Apple Company ☻!!");
         

            //Declaring an apple price
            Console.WriteLine("Our Apple product price start @ 32.50 per piece(s) ");
            //no. of apple that want to purchase.
            Console.Write("\n►► How many pieces of apple you want to purchase?: ");
            string input = Console.ReadLine();
            int pieces;
            

            if (int.TryParse(input, out pieces) && pieces > 0)
            {


                //calculate the total price and 
                //the total price with decimal.
                float Apple_Price = 32.50f;
                float TotalPrice = pieces * Apple_Price;
                Console.WriteLine($"\n►► Your  {input} apple(s)' total price is: {TotalPrice:F2} ");

                int FinalValue = (int)TotalPrice;
                //the total cost after conversion of float to int.
                Console.WriteLine("►► The total value of the converted price is: " + FinalValue);

                Console.Write("\nYou Purchased in our Store at exactly " + DateTime.Now);
                Console.WriteLine("\n \nWe appreciate your choosing our product.\nWe value your trust and will do everything we can to meet your expectations.\n");
               

            }

            else
            {
                Console.WriteLine("\n Please input valid pieces \n THANK YOU! ");
            }
            Console.Write("\n \nPress any key to exit ..");
            Console.ReadLine();




        }
    }
}
