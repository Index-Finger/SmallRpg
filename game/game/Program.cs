using System;

namespace game
{
    class Program
    {
        static void EndPara()
        {
            Console.WriteLine("XXXXXXXXXXXXXXX");
            Console.WriteLine("XXXXXXXXXXXXXXX");
            Console.WriteLine("XXXXXXXXXXXXXXX");
            Console.WriteLine("XXXXXXXXXXXXXXX");

        }

        static void FightStart()
        {
            Console.WriteLine("FIGHTFIGHTFIGHTFIGHTFIGHTFIGHTFIGHTFIGHTFIGHT");
            Console.WriteLine("XXXXXXXXXXXXXXX");
            Console.WriteLine("DIEDIEDIEDIEDIEDIEDIEDIEDIEDIEDIEDIEDIEDIEDIE");
            Console.WriteLine("XXXXXXXXXXXXXXX");
            Console.WriteLine("LIVELIVELIVELIVELIVELIVELIVELIVELIVELIVELIVE");
            Console.WriteLine("XXXXXXXXXXXXXXX");
            Console.WriteLine("BLOOD For The BLOOD GOD BLOOD For The BLOOD GOD");
        }

        static void AddInventory(string[] inventory, string item)
        {
            //Add things to inventory by calling these lines in main.
            //AddInventory(inventory, "bottle");
            for (int i = 0; i < 4; i++)
            {
                if (inventory[i] == null)
                { inventory[i] = item;
                    break;
                }
            }
        }

        static void CheckInventory(string[] inventory)
        {
            Console.WriteLine(inventory[0]);
            Console.WriteLine(inventory[1]);
            Console.WriteLine(inventory[2]);
            Console.WriteLine(inventory[3]);
        }

        static void Main(string[] args)
        {
            //create characters
            
            Character Machiavelli = new Character();
            Machiavelli.name = "Machiavelli";
            Machiavelli.health = 100;
            Machiavelli.maxHealth = 100;

            Character Dog = new Character();
            Dog.name = "Rabid";
            Dog.health = 30;
            Dog.damage = 15;
            Dog.maxHealth = 30;

            Character Cucumber = new Character();
            Cucumber.name = "Sea Cucumber";
            Cucumber.health = 2;
            Cucumber.damage = 0;
            Cucumber.maxHealth = 2;

            //create Weapons

            Weapon Bow = new Weapon();
            Bow.damage = 10;
            Bow.wName = "Bow";

            Weapon Bite = new Weapon();
            Bite.damage = 12;
            Bite.wName = "Bite";

            Weapon Sword = new Weapon();
            Sword.damage = 14;
            Sword.wName = "Sword";

            Weapon Spear = new Weapon();
            Spear.damage = 10;
            Spear.wName = "Spear";

            Weapon Fists = new Weapon();
            Fists.damage = 5;
            Fists.wName = "Fists";


            //declare inventory & implementation of objects for the inventory
            string[] inventory = { null, null, null, null };

            //AddInventory(inventory, "bottle");
            //AddInventory(inventory, "bayblade");
            //CheckInventory(inventory);
            //Console.ReadLine();


            Console.WriteLine("Welcome to danger island! Here you will be fighting many enemies. Choose your weapon number.");
            Console.WriteLine("1. Bow.");
            Console.WriteLine("2. Bite.");
            Console.WriteLine("3. Sword.");
            Console.WriteLine("4. Spear.");
            Console.WriteLine("5. Fists.");

            int pWeapon = Convert.ToInt32(Console.ReadLine());
            if (pWeapon == 1)
            {
                Machiavelli.PickUp(Bow.damage, Bow.wName);
            }
            if (pWeapon == 2)
            {
                Machiavelli.PickUp(Bite.damage, Bite.wName);
            }
            if (pWeapon == 3)
            {
                Machiavelli.PickUp(Sword.damage, Sword.wName);
            }
            if (pWeapon == 4)
            {
                Machiavelli.PickUp(Spear.damage, Spear.wName);
            }
            if (pWeapon == 5)
            {
                Machiavelli.PickUp(Fists.damage, Fists.wName);
            }
            Console.WriteLine("Ah, the " + Machiavelli.wName + ". A fine choice indeed.");

            System.Threading.Thread.Sleep(1000);

            EndPara();


            //Fight 1 lets go!!!!!


            Console.WriteLine("You see a dog. It's walking a little funny. You wish Atticus Finch would shoot it for you. Guess you'll have to get your own hands dirty...");
            Console.WriteLine();
            FightStart();
            while (Machiavelli.health > 0 && Dog.health > 0)
            {
                Console.WriteLine();
                EndPara();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You have " + Machiavelli.health + "/" + Machiavelli.maxHealth + " health left.");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("What do you you do? Enter the number");
                Console.WriteLine("1. Fight.");
                Console.WriteLine("2. Communicate.");
                Console.WriteLine("3. Item.");
                Console.WriteLine("4. Flee.");
                int action = Convert.ToInt32(Console.ReadLine());
                System.Threading.Thread.Sleep(1000);

                if (action == 1)
                {
                    Console.WriteLine("You attack the dog with your " + Machiavelli.wName);
                    Dog.Hurt(Machiavelli.damage);
                }
                if (action == 2)
                {
                    Console.WriteLine("You ask the dog what the value of a soul is.");
                    Console.WriteLine("He doesn't seem very interested in answering you.");
                }
                if (action == 3)
                {
                    Console.WriteLine("No items doofus. You gotta pick one up first.");
                }
                if (action == 4)
                {
                    Console.WriteLine("You try to flee and are shot in the back. You die almost instantly. Cowards are not rewarded.");
                    Machiavelli.health = 0;
                    break;
                }

                if (Dog.health < 15)
                {
                    Console.WriteLine("The dog looks bloody. You see a tear form in its eye. You feel like a monster.");
                }

                Console.WriteLine();
                if (Dog.health > 0)
                {
                    Console.WriteLine("The dog snarls, then attacks you.");
                    Machiavelli.Hurt(Dog.damage);
                }
                System.Threading.Thread.Sleep(2000);
            }
            if (Machiavelli.health > 0)
            { Console.WriteLine("Congrats!"); }
            else { Console.WriteLine("Shame. We had high hopes for you.");
                System.Environment.Exit(1);
            }

            Console.WriteLine("Wow I guess you really killed that dog huh? That's kinda fucked up. Guess you should keep going on your path.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
           
            
            //End of first fight! Congrats!


            EndPara();
            System.Threading.Thread.Sleep(1000);
            EndPara();
            System.Threading.Thread.Sleep(1000);
            EndPara();


            Console.WriteLine("You walk along the beach. To your left, the sun is setting in a beautiful array of reds and pinks.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(" To your right, a jungle extends out. It seems impenetrable.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("You feel some kind of eyes on you. You spin around and...!");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("You see a sea cucumber.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("You wonder how its managed to survive this long out of the water. Wait, what's that music?");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine();
            
            
            //Fight two begins!
            

            FightStart();

            while (Machiavelli.health > 0 && Cucumber.health > 0)
            {
                Console.WriteLine();
                EndPara();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You have " + Machiavelli.health + "/" + Machiavelli.maxHealth + " health left.");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("What do you you do? Enter the number");
                Console.WriteLine("1. Fight.");
                Console.WriteLine("2. Communicate.");
                Console.WriteLine("3. Item.");
                Console.WriteLine("4. Flee.");
                int action = Convert.ToInt32(Console.ReadLine());
                System.Threading.Thread.Sleep(1000);

                if (action == 1)
                {
                    Console.WriteLine("You attack the cute litte cucumber with your " + Machiavelli.wName);
                    Cucumber.Hurt(Machiavelli.damage);
                }
                if (action == 2)
                {

                    Console.WriteLine("You make a joke about putting it on a salad.");
                    Console.WriteLine("He cries. I don't think sea cucumbers are as firm as normal cucumbers.");
                }
                if (action == 3)
                {
                    Console.WriteLine("No items doofus. You gotta pick one up first.");
                }
                if (action == 4)
                {
                    Console.WriteLine("You try to flee and are shot in the back. You die almost instantly. Cowards are not rewarded.");
                    Machiavelli.health = 0;
                }

                if (Dog.health < 15)
                {
                    Console.WriteLine("The sea cucumber looks very dried out. You don't think its too healthy.");
                }

                Console.WriteLine();
                if (Cucumber.health > 0)
                {
                    Console.WriteLine("The cucumber rolls down a little hill in the sand. It can't do much.");
                    Machiavelli.Hurt(Dog.damage);
                }
                System.Threading.Thread.Sleep(2000);
            }
            if (Machiavelli.health > 0)
            { Console.WriteLine("Maybe that one shouldn't have been a fight. Glad you made it out at least."); }
            else
            {
                Console.WriteLine("Shame. We had high hopes for you.");
                System.Environment.Exit(1);
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
           
            
            //End of second fight!


            EndPara();
            EndPara();
            EndPara();

            Console.WriteLine("It's time to delve into the woods.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("You still feel eyes on you.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("There has to be a way out.");


        }
    }
}
