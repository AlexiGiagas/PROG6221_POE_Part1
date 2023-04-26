using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part1
{
    class Menu
    {
        public Menu() 
        {
            Console.WriteLine("Please select what you would like to do:");
            Console.WriteLine("1. Enter the Ingredients for the recipe.");
            Console.WriteLine("2. Enter the Steps for the recipe.");
            Console.WriteLine("3. Review the recipe.");
            
            int selection = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (selection == 1)
            {
                Ingredients ingredients = new Ingredients();
            }

            else if (selection == 2)
            {
                Steps steps = new Steps();
            }
        }
    }
}
