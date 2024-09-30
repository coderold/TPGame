using System;
using static TPGame.GameCharacter;

namespace TPGame
{
    class MainClass
    {
        static INFO info;
        static STATS stats;
        static PROFESSION prof;

        public static void Main(string[] args)
        {
            //INFO
            Console.Write("Enter your Character's Name         : ");
            info.name = Console.ReadLine();
            info.level = getLevel();

            printInfo(info.name, info.level);

            //STATS
            getStats();
            printStats();

            //PROFESSION
            chooseProf();
            congrats();

        }

        static int getLevel() 
        {
            int level = 0;
            while (level <= 0 || level >= 100) {
                Console.Write("Enter your character level (1 - 99) : ");
                level = Convert.ToInt32(Console.ReadLine());
            }
            return level;
        }

        static void printInfo(string name, int level)
        {
            Console.WriteLine("\nGame Character's Information: ");
            Console.WriteLine("Name   : " + name);
            Console.WriteLine("Level  : " + level);
        }

        static void getStats()
        {
            string[] statsList = {"Strength", "Agility", "Vitality", "Intelligence", "Dexterity", "Luck"};
            int[] statsValue = new int[statsList.Length];
            int i = 0;
            int value;

            Console.WriteLine();

            while (true)
            {
                Console.Write("Enter your Character's " + statsList[i] + " : ");
                value = Convert.ToInt32(Console.ReadLine());
                if (value <= 0 || value >= 100)
                {
                    Console.WriteLine("Invalid Input. Dapat (1 - 99) lang po! ulit lahat!\n");
                    i = 0;
                }
                else
                {
                    statsValue[i] = value;
                    i++;
                    if (i == statsList.Length)
                    {
                        break;
                    }
                }

            }

            stats.Strength = statsValue[0];
            stats.Agility = statsValue[1];
            stats.Vitality = statsValue[2];
            stats.Intelligence = statsValue[3];
            stats.Dexterity = statsValue[4];
            stats.Luck = statsValue[5];
        }

        static void printStats()
        {
            Console.WriteLine("\n" + info.name + "'s Stats : ");
            Console.WriteLine("Strength     : " + stats.Strength);
            Console.WriteLine("Agility      : " + stats.Agility);
            Console.WriteLine("Vitality     : " + stats.Vitality);
            Console.WriteLine("Intelligence : " + stats.Intelligence);
            Console.WriteLine("Dexterity    : " + stats.Dexterity);
            Console.WriteLine("Luck         : " + stats.Luck);
        }

        static void chooseProf()
        {
            string[] profList = {"Swordman", "Merchant", "Theif", "Acolyte", "Mage", "Archer" };
            Console.WriteLine("\n1. Swordman \n2. Merchant \n3. Thief \n4. Acolyte \n5. Mage \n6. Archer.\n");
            
            while (true)
            {
                Console.Write("Enter the number of your desire profession: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input <= 0 || input >= 7)
                {
                    Console.WriteLine("Mali ka, Dapat kasi (1-6) lang e! wag hanapin ang wala!\n");
                }
                else
                {
                    prof.profession = profList[input - 1];
                    break;
                }
            }
        }

        static void congrats()
        {
            Console.WriteLine("\nWow naman, Congrats isa ka nang ganap na " + prof.profession + "!!!!");
            Console.WriteLine("Goodluck sa iyong mahabang paglalakbay!");
        }
        
    }
}