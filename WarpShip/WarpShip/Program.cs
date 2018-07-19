using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*********************************************************************************************
       * ****************************************************************************************
       * 
       * 
       * Main program 
       * 
       * Description - This console application allows you to enter information about your dream
       * warp vessel. What will you choose for your ship?
       * 
       * Author - Benjamin Heath
       * Last Update - 2/10/2018
       * 
       * 
       * ********************************************************************************************
       * ***************************************************************************/

namespace WarpShip
{
    class Program
    {
       
        static void Main(string[] args)

        {
           ShipFocus someShip = new ShipFocus();
           Menu.MainMenu(someShip);
           
        }
        
        
    }
}
