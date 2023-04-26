using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part1
{
    class Steps
    {
        public Steps()
        {
            int[] numOfSteps = new int[1];

            Console.WriteLine("Please enter the number of steps:");

            for (int i = 0; i < numOfSteps.Length; i++)
            {
                numOfSteps[i] = Convert.ToInt32(Console.ReadLine());
            }

            string[] descOfSteps = new string[numOfSteps[0]];

            Console.WriteLine("Please list each step:");

            for (int i = 0; i < descOfSteps.Length; i++)
            {
                descOfSteps[i] = Console.ReadLine();
            }

            Console.Clear();

            Menu menu = new Menu();
        }
    }
}
