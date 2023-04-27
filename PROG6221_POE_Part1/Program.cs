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
                Console.WriteLine("\nEnter '1' to start a new recipe." +
                    "\nEnter '2' to scale the recipe." +
                    "\nEnter '3' to reset the scaling." +
                    "\nEnter '0' to quit.");
                string input = Console.ReadLine();

                Console.Clear();

                if (input == "1")
                {
                    recipe = CreateRecipe();
                    DisplayRecipe(recipe);
                }

                else if (input == "2")
                {
                    ScaleRecipe(recipe);
                    DisplayRecipe(recipe);
                }

                else if (input == "3")
                {
                    ResetScaling(recipe);
                    DisplayRecipe(recipe);
                }

                else if (input == "0")
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
            Recipe recipe = new Recipe();

            Console.WriteLine("Enter the number of ingredients:");
            int numIngredients = int.Parse(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"\nIngredient {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit of measurement: ");
                string unit = Console.ReadLine();

                recipe.Ingredients.Add(new Ingredients(name, quantity, unit));
            }

            Console.WriteLine("\nEnter the number of steps:");
            int numSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"\nStep {i + 1}:");
                string description = Console.ReadLine();
                recipe.Steps.Add(description);
            }

            Console.Clear();
            return recipe;
        }

        static void DisplayRecipe(Recipe recipe)
        {
            Console.Clear();

            Console.WriteLine("\nRECIPE\n");

            foreach (Ingredients ingredient in recipe.Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} {ingredient.Name}");
            }

            Console.WriteLine();

            for (int i = 0; i < recipe.Steps.Count; i++)
            {
                Console.WriteLine($"Step {i + 1}: {recipe.Steps[i]}");
            }
        }

        static void ScaleRecipe(Recipe recipe)
        {
            Console.WriteLine("\nEnter the scaling factor (2 or 3):");
            double factor = double.Parse(Console.ReadLine());
            
            foreach (Ingredients ingredient in recipe.Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        static void ResetScaling(Recipe recipe)
        {
            foreach (Ingredients ingredient in recipe.Ingredients)
            {
                ingredient.Quantity /= recipe.ScaleFactor;
            }

            recipe.ScaleFactor = 1;
        }
    }
}