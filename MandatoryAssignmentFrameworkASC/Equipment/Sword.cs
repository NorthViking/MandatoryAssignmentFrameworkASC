using System;
using System.Collections.Generic;
using System.Text;
using MandatoryAssignmentFrameworkASC.Equipment.Base;
using MandatoryAssignmentFrameworkASC.Interfaces;

namespace MandatoryAssignmentFrameworkASC.Equipment
{
    public class Sword : WeaponBase
    {
        public Sword(int minDamage, int maxDamage, int goldValue, string description):base(
            minDamage,maxDamage,description,goldValue,WeaponSlot.Sword)
        {


        }


    }
}
