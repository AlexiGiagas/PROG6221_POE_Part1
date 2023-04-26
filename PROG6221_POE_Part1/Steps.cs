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


        }
    }
}
