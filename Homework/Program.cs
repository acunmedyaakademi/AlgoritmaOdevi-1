using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HOMEWORK 1 START

            Console.Write("Enter three different number: ");
            string input =Console.ReadLine();
            var numbers = input.Split(' ');
           
            int number_1 = Convert.ToInt32(numbers[0]);
            int number_2 = Convert.ToInt32(numbers[1]);
            int number_3 = Convert.ToInt32(numbers[2]);
            
            int sum = number_1 + number_2 + number_3;
            int average = sum / 3;
            int multiplication = number_1 * number_2 * number_3;

            Console.WriteLine($"Sum : {sum}");
            Console.WriteLine($"average : {average}");
            Console.WriteLine($"multiplication : {multiplication}");

            // EN BÜYÜK EN KÜÇÜK BULMA KISMI 

            if (number_1 > number_2 && number_1 > number_3) {
                Console.WriteLine($"largest number : {number_1}");
            }
            else if (number_2 > number_1 && number_2 > number_3)
            {
                Console.WriteLine($"largest number : {number_2}");
            }
            else if (number_3 > number_2 && number_3 > number_1)
            {
                Console.WriteLine($"largest number : {number_3}");
            }

            if (number_1 < number_2 && number_1 < number_3)
            {
                Console.WriteLine($"smallest number : {number_1}");
            }
            else if (number_2 < number_1 && number_2 < number_3)
            {
                Console.WriteLine($"smallest number : {number_2}");
            }
            else if (number_3 < number_2 && number_3 < number_1)
            {
                Console.WriteLine($"smallest number : {number_3}");
            }


            // HOMEWORK 1 STOP

            // HOMEWORK 2 START
            Console.WriteLine("\n\r**********************\n\r");
            Console.WriteLine("Number  square  cube ");
            for (int i = 0; i <=10; i++)
            {

                Console.Write($"    {i} ");
                Console.Write($"    {i * i} ");
                Console.Write($"    {i * i * i} \n\r");

                
            }
            Console.ReadKey();

            // HOMEWORK 2 STOP

            // HOMEWROK 3 START

            Console.WriteLine("\n\r**********************\n\r");
            double total_gasoline = 0.0;
            int total_kilometers = 0;
            while (true)
            {
                Console.Write("how many liters gasoline was spent (-1 for the out) : ");
                double gasoline = Convert.ToDouble( Console.ReadLine() );
                if (gasoline == -1)
                {
                    double total_result = total_kilometers / total_gasoline;
                    Console.WriteLine($"Total avarage kilometers/gasoline : {total_result}");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Write("How many kilometers traveled :");
                    int kilometers = Convert.ToInt32(Console.ReadLine());
                    double result = kilometers / gasoline;
                    Console.WriteLine($"Kilometers/ gasoline : {result}");
                    total_gasoline += gasoline;
                    total_kilometers += kilometers;
                
                }
                

            }
            

            // HOMEWORK 3 STOP

            // HOMEWROK 4 START

            Console.WriteLine("\n\r**********************\n\r");
            int weekly = 200;
            double commission = 0.09;
            while (true)
            {
                Console.Write("Enter the sales amount in dollars(-1 for the out) : ");
                double sales = Convert.ToDouble(Console.ReadLine());
                if (sales != -1)
                {   
                    double salary = (sales * commission) +(weekly * 4); 
                    Console.WriteLine($"salary : {salary}$");
                    
                }
                else
                {
                    break;
                }

            }
            // HOMEWORK 4 STOP

            // HOMEWORK 5 START
            
            while (true)
            {
                Console.WriteLine("\n\r**********************\n\r");
                Console.Write("Please enter a 5 digit number (-1 for the out): ");

                string is_palindrome = Console.ReadLine();
                
                if (is_palindrome != "-1" )
                {
                    if (is_palindrome.Length == 5)
                    {
                        
                        var list = is_palindrome.ToList();
                        if (list[0] == list[4] && list[1] == list[3])
                        {
                            Console.WriteLine("This is a palindrome number");

                        }
                        else
                        {
                            Console.WriteLine("This is not a palindrome number");

                        }
                        
                    }
                }
                else
                {
                    break;
                }  
            }

            // HOMEWORK 5 STOP

            // HOMEWORK 6 START

            double stage_1 = 2.00;
            double stage_2 = 0.50;
            double stage_3 = 10.00;
            List<Double> times = new List<double>();
            List<Double> prices = new List<double>();
            List<string> cars = new List<string>();
            double total_time = 0.0;
            double total_price = 0.0;

            for (int i = 1; i <= 3; i++)
            {
                double price = 0.0;
                Console.Write("enter license plate: ");
                string car = Console.ReadLine();
                Console.Write("how many hours left: ");
                double time = Convert.ToDouble(Console.ReadLine());

                if (time <= 3.0)
                {
                    price = stage_1;
                }
                else if ((time > 3.0) && (time <24.0))
                {
                    price = (time - 3) * stage_2 + stage_1;

                }
                else if (time == 24.0)
                {
                    price = stage_3;
                }
                times.Add(time);
                prices.Add(price);
                cars.Add(car);
            }

            Console.WriteLine("License       Hour    prices ");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine ($" {cars[i]}       {times[i]}     {prices[i]}");
                total_time += times[i];
                total_price += prices[i];
            }
            Console.WriteLine("***********************\n\r");
            Console.WriteLine($"Total         {total_time}        {total_price}");
            Console.ReadKey();
        }
    }
}
