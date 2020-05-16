using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Engine
    {
        private BirdFactory birdFactory;
        private FelineFactory felineFactory;
        private MammalFactory mammalFactory;
        private FoodFactory foodFactory;
        private List<Animal> animals;
        private Animal animal;

        public Engine()
        {
            this.birdFactory = new BirdFactory();
            this.felineFactory = new FelineFactory();
            this.mammalFactory = new MammalFactory();
            this.foodFactory = new FoodFactory();
            this.animals = new List<Animal>();
        }
        public void Run()
        {

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] animalInfo = input.Split();
                string[] foodInfo = Console.ReadLine().Split();

                string animalType = animalInfo[0];
                string animalName = animalInfo[1];
                double animalWeight = double.Parse(animalInfo[2]);
                if (animalType == "Hens" || animalType == "Owl")
                {

                    double wingSize = double.Parse(animalInfo[3]);
                    animal = this.birdFactory.CreateBird(animalType, animalName, animalWeight, wingSize);
                    //this.animals.Add(bird);

                }
                else if (animalType == "Mouse" || animalType == "Dog")
                {
                    string livingRegion = animalInfo[3];
                    animal = this.mammalFactory.CreateMammal(animalType,animalName,animalWeight,livingRegion);
                    //this.animals.Add(mammal);
                }
                else if (animalType == "Cat" || animalType == "Tiger")
                {
                    string livingRegion = animalInfo[3];
                    string breed = animalInfo[4];

                    animal = this.felineFactory.CreateFeline(animalType, animalName, animalWeight, livingRegion, breed);
                    //this.animals.Add(feline);
                }
                string foodType = foodInfo[0];
                int quantity = int.Parse(foodInfo[1]);
                var food = this.foodFactory.CreateFood(foodType,quantity);

                animal.ProduceSound();
                animal.Eat(food);
                animals.Add(animal);

                input = Console.ReadLine();


            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

    }
}
