using System;

namespace ProgrammingBasicsOnlineExam_6and7July2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProgrammingBasicsOnlineExam-6and7July2019

            //ex1  Басейн
            int peopleNum = int.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double priceForOne = double.Parse(Console.ReadLine());
            double priceForOneUmbrella = double.Parse(Console.ReadLine());

            tax = peopleNum * tax;

            double peopleNumTotal = Math.Ceiling(peopleNum * 0.75);
            double totalForOne = peopleNumTotal * priceForOne;

            double averagePeople = Math.Ceiling(peopleNum * 0.5);
            int averagePeop = (int)(averagePeople);
            double price = averagePeop * priceForOneUmbrella;

            double totalSumOfAll = tax + totalForOne + price;

            Console.WriteLine($"{totalSumOfAll:F2} lv.");

           // ex.2
            double moneyTheyHave = double.Parse(Console.ReadLine());
            int countOfNights = int.Parse(Console.ReadLine());
            double priceForNights = double.Parse(Console.ReadLine());
            int percentForExpense = int.Parse(Console.ReadLine());

            if (countOfNights > 7)
            {
                priceForNights = priceForNights * 0.95;
                var sumOfNights = priceForNights * countOfNights;

                var optionalExpense = moneyTheyHave * percentForExpense;
                var newOptionalExpense = optionalExpense / 100;

                var newSumOfNights = sumOfNights + newOptionalExpense;
                var moneyAfterHoliday = moneyTheyHave - newSumOfNights;
                var evenSum = newSumOfNights - moneyTheyHave;

                if (newSumOfNights <= moneyTheyHave)
                {
                    Console.WriteLine($"Ivanovi will be left with {moneyAfterHoliday:F2} leva after vacation.");
                }
                if (newSumOfNights > moneyTheyHave)
                {
                    Console.WriteLine($"{evenSum:F2} leva needed.");
                }
            }
            if (countOfNights <= 7)
            {
                var nights = countOfNights * priceForNights; //462
                // var budgetExpenses = moneyTheyHave * (percentForExpense / 100); //75

                var budge = moneyTheyHave * percentForExpense;
                var mewbudge = budge / 100;
                double totalMoney = nights + mewbudge;
                if (totalMoney > moneyTheyHave)
                {
                    var finalMoney = totalMoney - moneyTheyHave;
                    Console.WriteLine($"{finalMoney:F2} leva needed.");
                }
                else
                {
                    var finalMoney = moneyTheyHave - totalMoney;
                    Console.WriteLine($"Ivanovi will be left with {finalMoney:F2} leva after vacation.");
                }
            }

            //ex.3  Coffee Machine
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int countOfDrinks = int.Parse(Console.ReadLine());

            double totalCount = 0;
            double choosenDrink = 0;
            double discountDrink = 0;
            double espressoDiscount = 0;

            if (drink == "Espresso")
            {

                if (sugar == "Without")
                {
                    choosenDrink = countOfDrinks * 0.90; // 9
                    discountDrink = choosenDrink * 0.65; //5.85
                    espressoDiscount = discountDrink * 0.25;
                    if (countOfDrinks >= 5)
                    {
                        totalCount = discountDrink - espressoDiscount;
                        if (totalCount > 15)
                        {
                            totalCount = totalCount * 0.80;
                        }
                        Console.WriteLine($"You bought {countOfDrinks} cups of {drink} for {totalCount:F2} lv.");

                    }
                    if (countOfDrinks < 5)
                    {
                        totalCount = discountDrink;
                        Console.WriteLine($"You bought {countOfDrinks} cups of {drink} for {totalCount:F2} lv.");

                    }
                }
                if (sugar == "Normal")
                {
                    choosenDrink = countOfDrinks * 1.0; // 9
                    espressoDiscount = choosenDrink * 0.25;
                    if (countOfDrinks >= 5)
                    {
                        totalCount = choosenDrink - espressoDiscount;
                    }
                    if (totalCount > 15)
                    {
                        totalCount = totalCount * 0.80;
                    }
                    Console.WriteLine($"You bought {countOfDrinks} cups of {drink} for {totalCount:F2} lv.");

                }
                if (sugar == "Extra")
                {
                    choosenDrink = countOfDrinks * 1.20; // 9
                    espressoDiscount = choosenDrink * 0.25;
                    if (countOfDrinks >= 5)
                    {
                        totalCount = choosenDrink - espressoDiscount;
                    }
                    if (totalCount > 15)
                    {
                        totalCount = totalCount * 0.80;
                    }
                    Console.WriteLine($"You bought {countOfDrinks} cups of {drink} for {totalCount:F2} lv.");

                }
            }
            if (drink == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    choosenDrink = countOfDrinks * 1.0; // 9
                    if (choosenDrink > 15)
                    {
                        totalCount = choosenDrink * 0.80;
                    }
                    Console.WriteLine($"You bought {countOfDrinks} cups of {drink} for {totalCount:F2} lv.");
                }
                if (sugar == "Normal")
                {
                    choosenDrink = countOfDrinks * 1.20; // 9
                    if (choosenDrink > 15)
                    {
                        choosenDrink = choosenDrink * 0.80;
                    }
                    Console.WriteLine($"You bought {countOfDrinks} cups of {drink} for {choosenDrink:F2} lv.");

                }
                if (sugar == "Extra")
                {
                    choosenDrink = countOfDrinks * 1.60;

                    if (choosenDrink > 15)
                    {
                        choosenDrink = choosenDrink * 0.80;
                    }
                    Console.WriteLine($"You bought {countOfDrinks} cups of {drink} for {choosenDrink:F2} lv.");

                }
            }
            if (drink == "Tea")
            {
                if (sugar == "Without")
                {
                    choosenDrink = countOfDrinks * 0.50; // 9
                    if (choosenDrink > 15)
                    {
                        choosenDrink = choosenDrink * 0.80;
                    }
                    Console.WriteLine($"You bought {countOfDrinks} cups of {drink} for {choosenDrink:F2} lv.");
                }
                if (sugar == "Normal")
                {
                    choosenDrink = countOfDrinks * 0.60; // 9
                    if (choosenDrink > 15)
                    {
                        choosenDrink = choosenDrink * 0.80;
                    }
                    Console.WriteLine($"You bought {countOfDrinks} cups of {drink} for {choosenDrink:F2} lv.");

                }
                if (sugar == "Extra")
                {
                    choosenDrink = countOfDrinks * 0.70;

                    if (choosenDrink > 15)
                    {
                        choosenDrink = choosenDrink * 0.80;
                    }
                    Console.WriteLine($"You bought {countOfDrinks} cups of {drink} for {choosenDrink:F2} lv.");

                }
            }

            // ex.4   Club

            double sumINeed = double.Parse(Console.ReadLine());

            string coctailName = Console.ReadLine();
            var newSum = 0.0;
            var total = 0.0;
            var isTrue = false;

            while (coctailName != "Party!")
            {
                int countOfCoctails = int.Parse(Console.ReadLine());
                int newCoctailName = coctailName.Length;

                double sum = newCoctailName * countOfCoctails;

                if (sum % 2 == 1)
                {
                    sum = sum * 0.75;
                }
                newSum = sum;


                total += newSum;

                if (sumINeed <= total)
                {
                    isTrue = true;
                    Console.WriteLine($"Target acquired.");
                    Console.WriteLine($"Club income - {total:F2} leva.");
                    break;
                }

                coctailName = Console.ReadLine();
            }
            var totalSumWeNeed = sumINeed - total;
            if (isTrue == false)
            {
                Console.WriteLine($"We need {totalSumWeNeed:F2} leva more.");
                Console.WriteLine($"Club income - {total:F2} leva.");
            }

           // ex.5 Магазин за компютърни игри( for 20 min I make this task)

                int soldGamesCounter = int.Parse(Console.ReadLine());
            double sumOfGames = 0;
            double counterOfHeart = 0;
            double counterOfFortnite = 0;
            double counterOfOverwatch = 0;
            double counterOfOthers = 0;

            for (int i = 0; i < soldGamesCounter; i++)
            {
                string soldGames = Console.ReadLine();
                if (soldGames == "Hearthstone")
                {
                    counterOfHeart++;
                }
                if (soldGames == "Fornite")
                {
                    counterOfFortnite++;
                }
                if (soldGames == "Overwatch")
                {
                    counterOfOverwatch++;
                }
                if (soldGames != "Hearthstone" && soldGames != "Fornite" && soldGames != "Overwatch")
                {
                    counterOfOthers++;
                }

            }
            double percentOfHeart = (counterOfHeart / soldGamesCounter) * 100;
            double percentOfFortnite = (counterOfFortnite / soldGamesCounter) * 100;
            double percentOfOver = (counterOfOverwatch / soldGamesCounter) * 100;
            double percentOfOthers = (counterOfOthers / soldGamesCounter) * 100;



            Console.WriteLine($"Hearthstone - {percentOfHeart:F2}%");
            Console.WriteLine($"Fornite - {percentOfFortnite:F2}%");
            Console.WriteLine($"Overwatch - {percentOfOver:F2}%");
            Console.WriteLine($"Others - {percentOfOthers:F2}%");

            //ex.6 Игра на имена
            var name = "";
            var iterate = 0;
            var sum = 0;
            char character = ' ';
            var total = 0;
            var maxNum = 0;
            var finalname = "";

            while ((name = Console.ReadLine()) != "Stop")
            {
                var counterOfTen = 0;
                var counterOfTwo = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    character = Convert.ToChar(number);

                    if (character == name[i])
                    {
                        counterOfTen += 10;
                    }
                    if (character != name[i])
                    {
                        counterOfTwo += 2;
                    }
                }
                sum = +counterOfTen + counterOfTwo;  // 6

                if (total <= sum)
                {
                    total = sum;   //24
                    finalname = name; // Ivan

                }
                if (total > sum)
                {
                    maxNum = sum; //

                }
            }

            Console.WriteLine($"The winner is {finalname} with {total} points!");


        }
    }
}
