using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pets.Feeders;
using Pets.Pets;

public class Pets_Food
{
    public static void Main(string[] args)
    {
        PetFeeder feeder;

        string selectedPet = "";

        while (true)
        {
            Console.WriteLine("Choose the pet you want to feed.: \n1 - Cat\n2 - Dog");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                selectedPet = "Cat";
                feeder = new CatFeeder();
                break;
            }
            else if (choice == "2")
            {
                selectedPet = "Dog";
                feeder = new DogFeeder();
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose 1 or 2");
            }
        }

        while (true)
        {
            Console.Write("Enter the amount of food in grams: ");
            if (int.TryParse(Console.ReadLine(), out int increment) && increment > 0)
            {
                if(selectedPet == "Cat")
                {
                    int maxFoodAmountCat = ((CatFeeder)feeder).maxFoodAmountCat;
                    if (increment > maxFoodAmountCat)
                    {
                        Console.WriteLine($"The amount exceeds the maximum food limit for a cat ({maxFoodAmountCat} grams). Try again.");
                    }
                    else if(increment <= maxFoodAmountCat)
                    {
                        Console.WriteLine("Yum Yum Yum!");
                        break;
                    }
                }


                else if(selectedPet == "Dog")
                {
                    int maxFoodAmountDog = ((DogFeeder)feeder).maxFoodAmountDog;
                    if (increment > maxFoodAmountDog)
                    {
                        Console.WriteLine($"The amount exceeds the maximum food limit for a dog ({maxFoodAmountDog} grams). Try again.");
                    }
                    else if(increment <= maxFoodAmountDog)
                    {
                        Console.WriteLine("Yum Yum Yum!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
    }

}

