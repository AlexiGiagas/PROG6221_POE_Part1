using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part1
{
    class Ingredients
    {
        public Ingredients()
        {
            int[] numOfIngredients = new int[1];

            Console.WriteLine("Please enter the number of ingredients:");

            for (int i = 0; i < numOfIngredients.Length; i++)
            {
                numOfIngredients[i] = Convert.ToInt32(Console.ReadLine());
            }

            string[] nameOfIngredients = new string[numOfIngredients[0]];

            Console.WriteLine("Please enter " + numOfIngredients[0] + " ingredients:");

            for (int i = 0; i < nameOfIngredients.Length; i++)
            {
                nameOfIngredients[i] = Console.ReadLine();
            }

            Console.WriteLine("Please enter the quantity for each ingredient:");

            int[] quantOfIngredients = new int[numOfIngredients[0]];

            for (int i = 0; i < quantOfIngredients.Length; i++)
            {
                quantOfIngredients[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Please enter the unit of measurement for each ingredient:");

            string[] unitOfIngredients = new string[numOfIngredients[0]];

            for (int i = 0; i < unitOfIngredients.Length; i++)
            {
                unitOfIngredients[i] = Console.ReadLine();
            }

            Console.Clear();

            Menu menu = new Menu();
        }
    }
}
