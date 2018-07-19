using System;



namespace WarpShip
{
    /*********************************************************************************************
         * ****************************************************************************************
         * 
         * 
         * Menu Class handles the user interaction with the application
         * 
         * 
         * ********************************************************************************************
         * ***************************************************************************/
    class Menu
    {

        static int mCount = 0;
        static int menuCounter = 0;
        public static void menuTest()
        {
            Console.WriteLine(" The new menu");
        }
        public static void MainMenu(ShipFocus ship)
        {
            string userChoice;
            if (mCount == 0)
            {
                Console.WriteLine("Welcome to the Warp Ship Designer Application\nWhile using the application and if does not seem to continue\nPress Enter to continue:");
                Console.WriteLine("Thank you for trying the app. I hope you enjoy!");
                mCount = 1;
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("Please pick a menu option");
            Console.WriteLine("View current ship information(1)");
            Console.WriteLine("Select ship engine(2)");
            Console.WriteLine("Select Crew Compliment(3)");
            Console.WriteLine("Select Weapon Compliment(4)");
            Console.WriteLine("Ship Hull Size(5)");
            Console.WriteLine("Shielding(6)");
            Console.WriteLine("Armor Thickness(7)");
            Console.WriteLine("Reset Ship Values(8)");
            Console.WriteLine("Exit App(9)");

            userChoice = Console.ReadLine();
            //Make sure the user enters an integer
            try
            {
                menuCounter = Int32.Parse(userChoice);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Returning to main menu");
                Console.ReadLine();
                Console.Clear();
                MainMenu(ship);
            }
            //take the user to the selected menu option
            switch (menuCounter)
            {
                
                case 1:
                    menuOne(ship);
                    Console.Clear();
                    break;
                case 2:
                    menuTwo(ship);
                    Console.Clear();
                    break;
                case 3:
                    menuThree(ship);
                    Console.Clear();
                    break;
                case 4:
                    menuFour(ship);
                    Console.Clear();
                    break;
                case 5:
                    menuFive(ship);
                    Console.Clear();
                    break;
                case 6:
                    menuSix(ship);
                    Console.Clear();
                    break;
                case 7:
                    menuSeven(ship);
                    Console.Clear();
                    break;
                case 8:
                    menuEight(ship);
                    Console.Clear();
                    break;
                case 9:
                    Console.WriteLine("Thanks for trying the app! Now exiting");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("The value you have entered is not a menu option");
                    Console.ReadLine();
                    menuCounter = 0;
                    Console.Clear();
                    MainMenu(ship);
                   // MainMenu();
                    break;
            }
        }


        /**********************
         * Menu method definitions
         * 
         * 
       
         * */
       /*
        static void menuZero(ShipFocus tS)
        {
            Console.WriteLine("You punched your ship, and not only damaged your hand," +
                " but you also damaged your ship!");
            Console.WriteLine("On a scale of 1 to 10, how bad does your hand hurt?");

            Random rand = new Random();
            var input = Console.ReadLine();
            var pain = 0;
            var r = rand.Next(1, 10);
          
            try
            {
                int.TryParse(input, out pain);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Returning to main menu");
                Console.ReadLine();
                Console.Clear();
                MainMenu(tS);
            }
           // I have narrowed it down to this line right here
            // I am still debugging but this is where baseDamage is not being set. 
            // I will be back for it
             
            tS.setBaseDamage((pain * r));


            Console.WriteLine($"Base damage should have been set {tS.getDamageLevel()}");
            Console.ReadLine();
            tS.shipInfo();
           

            Console.ReadLine();
            Console.Clear();
            MainMenu(tS);
            
        }
        */

        static void menuOne(ShipFocus tS)
        {
            Console.WriteLine("Ship Information menu");
            tS.shipInfo();
            //tS.wasShipDestroyed();
            Console.ReadLine();
            Console.Clear();
            MainMenu(tS);
          //  MainMenu();
        }
        static void menuTwo(ShipFocus tS)
        {
            
            int userENchoice = 0;
            Console.WriteLine("Engine selection menu");
            try
            {
                Console.WriteLine("Please enter an engine level 1-5");
                userENchoice = Int32.Parse(Console.ReadLine());
                switch(userENchoice)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        tS.engine = userENchoice;
                        Console.WriteLine("Engine choice acceptable");
                        Console.ReadLine();
                        Console.Clear();
                        MainMenu(tS);
                    break;
                    default:
                        Console.WriteLine("Sorry we don't offer engines with that level");
                        Console.WriteLine("Please enter a new value");
                        Console.ReadLine();
                        Console.Clear();
                        menuTwo(tS);
                    break;
                }

            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter an integer value");
                Console.ReadLine();
                Console.Clear();
                menuTwo(tS);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a valid integer value");
                Console.ReadLine();
                Console.Clear();
                menuTwo(tS);
            }

        }
        static void menuThree(ShipFocus tS)
        {
            int userCrewComp = 0;
          
            try
            {
                Console.WriteLine("Enter how many crew members you need, 1-1000:");
                userCrewComp = Int32.Parse(Console.ReadLine());
                if (userCrewComp <= 0 || userCrewComp > 1000)
                {
                    Console.WriteLine("{0} - this is not a valid input", userCrewComp);
                    MainMenu(tS);
                    Console.Clear();
                }
                else
                {
                    tS.crewComp = userCrewComp;
                    Console.WriteLine("Crew compliment acceptable");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu(tS);
                }
               
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Console.Clear();
                menuThree(tS);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a valid integer value");
                Console.ReadLine();
                Console.Clear();
                menuThree(tS);
            }

        }
        static void menuFour(ShipFocus tS)
        {
            int userWeapons = 0;
            Console.WriteLine("Welcome to the weapon menu!");
            Console.WriteLine("Enter how many weapon banks are needed, 1-100:");
            try
            {
                userWeapons = Int32.Parse(Console.ReadLine());
                if (userWeapons <= 0)
                {
                    Console.WriteLine("You need at least one weapon!");
                    Console.ReadLine();
                    Console.Clear();
                    menuFour(tS);
                }
                else if (userWeapons > 100)
                {
                    Console.WriteLine("Whoa, you expect us to pay for that many weapons?? Think again...");
                    Console.ReadLine();
                    Console.Clear();
                    menuFour(tS);
                }
                else
                {
                    tS.weapons = userWeapons;
                    Console.WriteLine("Weapon Choice Acceptable");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu(tS);
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Console.Clear();
                menuFour(tS);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a valid integer value");
                Console.ReadLine();
                Console.Clear();
                menuFour(tS);
            }
        }
        static void menuFive(ShipFocus tS)
        {
            int userHullSize = 0;
            
            Console.WriteLine("Welcome to the Ship Hull selection menu");
           
            try
            {
                Console.WriteLine("Enter ship hull size: \nCorvette(1)\nDestroyer(2)\nCruiser(3)\nBattleship(4)\nDreadnought(5)");

                userHullSize = Int32.Parse(Console.ReadLine());
                switch (userHullSize)
                {
                    case 0 :
                        Console.WriteLine("0 does not correspond to a hull size");
                        Console.ReadLine();
                        Console.Clear();
                        menuSix(tS);
                        break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        if(tS.crewComp == 0)
                        {
                            Console.WriteLine("Please enter number of needed crew members first");
                            Console.ReadLine();
                            Console.Clear();
                            menuThree(tS);

                        }
                        else if (tS.crewComp > 300 & userHullSize < 3)
                        {
                            Console.WriteLine("Your going to need a larger hull");
                            Console.ReadLine();
                            Console.Clear();
                            menuFive(tS);
                        }
                        else if (tS.crewComp > 500 & userHullSize < 4)
                        {
                            Console.WriteLine("Your going to need a larger hull");
                            Console.ReadLine();
                            Console.Clear();
                            menuFive(tS);
                        }
                        else
                        {
                            tS.shipHullSize = userHullSize;
                            Console.WriteLine("Hull size selected");
                            Console.ReadLine();
                            Console.Clear();
                            MainMenu(tS);
                        }
                        break;
                    default:
                        Console.WriteLine("Not a valid entry");
                        Console.ReadLine();
                        Console.Clear();
                        menuSix(tS);
                        break;

                }
               
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Console.Clear();
                MainMenu(tS);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a valid integer value");
                Console.ReadLine();
                Console.Clear();
                menuFive(tS);
            }
        }


        static void menuSix(ShipFocus tS)
        {
            
            Console.WriteLine("Welcome to the Shield selection menu");
            int userShields = 0;
            try
            {
                Console.WriteLine("Enter number of Shield Emitters, 1-15: ");
                userShields = Int32.Parse(Console.ReadLine());
                if (userShields <= 0)
                {
                    Console.WriteLine("You need atleast one shield emitter");
                    Console.ReadLine();
                    Console.Clear();
                    menuSix(tS);
                }
                else if(userShields > 15)
                {
                    Console.WriteLine("We can't afford that many shield emitters on one ship!");
                    Console.ReadLine();
                    Console.Clear();
                    menuSix(tS);
                }
                else
                {
                    Console.WriteLine("Yayy!! Shields equipped.");
                    tS.shields = userShields;
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu(tS);
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Console.Clear();
                MainMenu(tS);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a valid integer value");
                Console.ReadLine();
                Console.Clear();
                menuSix(tS);
            }

        }
        static void menuSeven(ShipFocus tS)
        {
            
            Console.WriteLine("Welcome to the Armor selection menu");
            //Console.ReadLine();
            int userArmor = 0;

            try
            {
                Console.WriteLine("Enter number of Armor Layers, 1-15: ");
                userArmor = Int32.Parse(Console.ReadLine());
                if (userArmor <= 0)
                {
                    Console.WriteLine("You really need at least some armor. You are going into space after all.");
                    Console.ReadLine();
                    Console.Clear();
                    menuSeven(tS);
                }
                else if (userArmor > 15)
                {
                    Console.WriteLine("We can't afford that much armor on one ship!");
                    Console.ReadLine();
                    Console.Clear();
                    menuSeven(tS);
                }
                else
                {
                    Console.WriteLine("Yayy!! Armor added to ship.");
                    tS.armor = userArmor;
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu(tS);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Console.Clear();
                MainMenu(tS);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a valid integer value");
                Console.ReadLine();
                Console.Clear();
                menuSeven(tS);
            }
        }

        static void menuEight(ShipFocus tS)
        {
            int userReset = 0;
            
            Console.WriteLine("Would you like to reset ship values to default?\n Yes(1) or No(0)");
            try
            {
                userReset = Int32.Parse(Console.ReadLine());
                if (userReset > 1 || userReset < 0)
                {
                    Console.WriteLine("Not a valid entry");
                    Console.ReadLine();
                    Console.Clear();
                    menuEight(tS);

                }
                else if (userReset == 1)
                {
                    tS.setValuesToDefault();
                    Console.WriteLine("Ship values reset to default");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu(tS);
                   
                }
                else
                {
                    Console.WriteLine("Ship values not reset to default");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu(tS);
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Console.Clear();
                MainMenu(tS);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a valid integer value");
                Console.ReadLine();
                Console.Clear();
                menuEight(tS);
            }

        }
    }
}
