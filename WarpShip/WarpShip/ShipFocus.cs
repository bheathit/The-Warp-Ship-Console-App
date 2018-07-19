using System;



namespace WarpShip

/*********************************************************************************************
   * ****************************************************************************************
   * 
   * 
   * ShipFocus Class handles the users information entered in the application
   * 
   * 
   * ********************************************************************************************
   * ***************************************************************************/
{
    public class ShipFocus
    {
        //Member variables

        public int engine { get; set; }
        public int crewComp { get; set; }
        public int weapons { get; set; }
        public int shipHullSize { get; set; }
        public int shields { get; set; }
        public int armor { get; set; }


        private int baseDamage;
        private const double damageInterval = 999.99;
/*
        public double getDamageLevel()
        {
            return (double)baseDamage * damageInterval;
        }

        public void setBaseDamage(double damageTaken)
        {
            var dmg = getDamageLevel();
            dmg += damageTaken;
            baseDamage = (int)(dmg / damageInterval);
        }
        */

       
        /// Default constructor       
     
        public ShipFocus()
        {
            engine = 0;
            crewComp = 0;
            weapons = 0;
            shipHullSize = 0;
            shields = 0;
            armor = 0;
            baseDamage = 0;
        }

        //Custom constructor
        public ShipFocus(int en, int cc, int w, int sf, int sh, int ar, int bD)
        {
            engine = en;
            crewComp = cc;
            weapons = w;
            shipHullSize = sf;
            shields = sh;
            armor = ar;
            baseDamage = bD;
        }

        //Method to generate outputs based on entered ship information
       
        public void wasShipDestroyed()
        {
            if (baseDamage <= 500 & shipHullSize >= 1)
            {
                Console.WriteLine("Ship survived");
            }
            else
                Console.WriteLine("Your ship was destroyed...");

        }
        public string GetEngineInfo()
        {
            string en = "default_val GetEngineInfo()";
            switch (engine)
            {
                case 0:
                    en = "Default Value";
                    break;
                case 1:
                    en = "Level 1 Engine";
                    break;
                case 2:
                    en = "Level 2 Engine";
                    break;
                case 3:
                    en = "Level 3 Engine";
                    break;
                case 4:
                    en = "Level 4 Engine";
                    break;
                case 5:
                    en = "Level 5 Engine";
                    break;
                default:
                    en = "Something else entirely";
                    break;
            }
            return en;
        }
        /*
            This method takes the value for the crew compliment and returns a string describing 
            what level of the crew compliment is.
            */
            public string GetCrew()
        {
            string crewC = "Value not entered yet";
            if (crewComp <= 25 & crewComp > 0)
            {
                crewC = $"Crew Members: {crewComp} - Skeleton crew...";
            }
            else if (crewComp >= 50 & crewComp < 100)
            {
                crewC = $"Crew Members: {crewComp} - Keep recruiting";
            }
            else if (crewComp >= 100 & crewComp < 300)
            {
                crewC = $"Crew Members: {crewComp} - That's enough to start";
            }
            else if (crewComp > 300)
            {
                crewC = $"Crew Members: {crewComp} - Hopefully you have a decent size ship for this crew!";
            }
            else
            {
                crewC = $"Crew members: {crewComp} - You call this a crew?";
            }
            return crewC;
        }

        /*
         weapon method
             */
            
         public string GetWeapons()
        {
            string w = "default_val_GetWeapons()";
            if (weapons > 0 & weapons < 10)
            {
                w = $"Weapon Turrets: {weapons} - That's all the weapons you're taking?!";
            }
            else if (weapons >= 10 & weapons < 40)
            {
                w = $"Weapons Turrets: {weapons} - That's a little better...be carful";
            }
            else if (weapons >= 40 & weapons < 60)
            {
                w = $"Weapon Turrets: {weapons} - Planning to go to war?";
            }
            else if (weapons > 60)
            {
                w = $"Weapon Turrets: {weapons} - Ummm, may I leave?";
            }
            else
                w = "default_val";
            return w;
        }

        /*
         
            Wanna know the ships hull size?
             
             */
        public string GetHullSize()
        {
            string sHS = "default_val GetHullSize()";
            switch (shipHullSize)
            {
                case 1:
                    sHS = "Corvette Class";
                    break;
                case 2:
                    sHS = "Destroyer Class";
                    break;
                case 3:
                    sHS = "Cruiser Class";
                    break;
                case 4:
                    sHS = "Battleship Class";
                    break;
                case 5:
                    sHS = "Dreadnought Class";
                    break;
                default:
                    sHS = "default_val";
                    break;
            }
            return sHS;
        }

        /*
         You're going to want some shields..
             */
        public string GetShields()
        {
            string sH = "default_val GetShield()";
            if (shields > 0 & shields <= 5)
            {
                sH = $"Sheild Emitters: {shields} - Light Shielding";
            }
            else if (shields > 5 & shields <= 10)
            {
                sH = $"Shield Emitters: {shields} - Medium Shielding";
            }
            else if (shields > 10 & shields <= 15)
            {
                sH = $"Shield Emitters: {shields} - Heavy Shielding";
            }
            else
                sH = "default_val";
            return sH;
        }
             /*
              
             armor clad
             */
        public string GetArmor()
        {
            string a = "default_val GetArmor()";
            if (armor > 0 & armor <= 5)
            {
                
                a = $"Armor Sections: {armor} - Light Armor";
            }
            else if (armor > 5 & armor <= 10)
            {
                a = $"Armor Sections: {armor} - Medium Armor";
            }
            else if (armor > 10 & armor <= 15)
            {
                a = $"Armor Sections: {armor} - Heavy Armor";
            }
            else
                a = "default_val";
            return a;
        }
             
    public void shipInfo()
        {
            string en = "Value not entered yet", crewC = "Value not entered yet", w = "Value not entered yet",
                sHS = "Value not entered yet", sH = "Value not entered yet", a = "Value not entered yet";

            en = GetEngineInfo();
            crewC = GetCrew();
            w = GetWeapons();
            sHS = GetHullSize();
            sH = GetShields();
            a = GetArmor();


            var output = $"The currently entered ship info \n Engines: {en}";
            output += $"\n Crew Members: {crewC}\n Weapons: {w}";
            output += $"\n Ship Classification: {sHS}\n Shields: {sH} \n Armor: {a}";
            //output += $"\n Ship Damage: {getDamageLevel()}";

            Console.WriteLine(output);
        }



        public void setValuesToDefault()
        {
            engine = 0;
            crewComp = 0;
            weapons = 0;
            shields = 0;
            shipHullSize = 0;
            armor = 0;
           // setBaseDamage(0);
        }
    }
}
