using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using MandatoryAssignmentFrameworkASC.Equipment;
using MandatoryAssignmentFrameworkASC.Interfaces;

namespace MandatoryAssignmentFrameworkASC.Factories
{
    public class Factory
    {
        static Random rng = new Random();
        public static IDefence Create()
        {

            int defenceItem = rng.Next(1, 5);
            switch (defenceItem)
            {
                case 0:
                    return new Helmet(25,4,"iron helmet",2);
                case 1:
                    return new Chest(50,7,"iron chest",4);
                case 2:
                    return new Legs(35,5,"iron legs",3);
                case 3:
                    return new Boots(20,3,"iron boots",2);
                case 4:
                    return new Shield(60,8,"iron shield",2);
                
                

            }
            return null;
        }
    }
}
