using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Number_1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            double calculateCharge(double numHours)
            {
                double parkingCost = 0;
                if (numHours <= 3)
                {
                    parkingCost = 2.0;
                }
                else if (numHours > 3 && numHours <= 19)
                {
                    parkingCost = 2.0 + 0.5 * (numHours);
                }
                else if (numHours > 19)
                {
                    parkingCost = 10.0;
                }

                return parkingCost;
            }

            string[] customers = new string[8] { "Tom", "Stacy", "Kyle", "Reed", "Katie", "Bell", "Sam", "Percy" };
            int[] parkedTime = new int[8] { 12, 5, 6, 22, 2, 14, 1, 7 };

            Console.WriteLine("Name:\tHours:\tCharges:");
            Console.WriteLine(customers[0] + "\t" + parkedTime[0] + "\t" + "$" + calculateCharge(parkedTime[0]));
            Console.WriteLine(customers[1] + "\t" + parkedTime[1] + "\t" + "$" + calculateCharge(parkedTime[1]));
            Console.WriteLine(customers[2] + "\t" + parkedTime[2] + "\t" + "$" + calculateCharge(parkedTime[2]));
            Console.WriteLine(customers[3] + "\t" + parkedTime[3] + "\t" + "$" + calculateCharge(parkedTime[3]));
            Console.WriteLine(customers[4] + "\t" + parkedTime[4] + "\t" + "$" + calculateCharge(parkedTime[4]));
            Console.WriteLine(customers[5] + "\t" + parkedTime[5] + "\t" + "$" + calculateCharge(parkedTime[5]));
            Console.WriteLine(customers[6] + "\t" + parkedTime[6] + "\t" + "$" + calculateCharge(parkedTime[6]));
            Console.WriteLine(customers[7] + "\t" + parkedTime[7] + "\t" + "$" + calculateCharge(parkedTime[7]));

        }
    }
}
