using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace PROG6221_POE_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();

            while (true)
            {
                Console.WriteLine("\nEnter 'new' to start a new recipe, 'scale' to scale the recipe, 'reset' to reset the scaling, or 'exit' to quit.");
                string input = Console.ReadLine();

                if (input == "new")
                {
                    recipe = CreateRecipe();
                    DisplayRecipe(recipe);
                }
                else if (input == "scale")
                {
                    ScaleRecipe(recipe);
                    DisplayRecipe(recipe);
                }
                else if (input == "reset")
                {
                    ResetScaling(recipe);
                    DisplayRecipe(recipe);
                }
                else if (input == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }

        static Recipe CreateRecipe()
        {
            
        }

        static void DisplayRecipe(Recipe recipe)
        {
            
        }

        static void ScaleRecipe(Recipe recipe)
        {
            
        }

        static void ResetScaling(Recipe recipe)
        {
            
        }
    }
}