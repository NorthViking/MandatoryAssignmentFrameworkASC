using System;
using System.Collections.Generic;
using System.Text;
using MandatoryAssignmentFrameworkASC.Equipment.Base;
using MandatoryAssignmentFrameworkASC.Interfaces;

namespace MandatoryAssignmentFrameworkASC.Equipment
{
    public class Boots : ArmorBase
    {
        public Boots(int health, int armorPoint, string description, int goldValue) : base(
            health, armorPoint, description, goldValue, ArmorSlot.boots)
        { }
        //public int Health { get; set; }
        //public int Block { get; set; }
        //public int ArmorPoint { get; set; }


        //public Boots(int health, int armorPoint, int goldValue) :base("boots",goldValue,EquipmentCategory.armor)
        //{
        //    Health = health;
        //    Block = 0;
        //    ArmorPoint = armorPoint;

        //}

        //public override string ToString()
        //{
        //    return base.ToString() + $", HP: {Health}, AP: {ArmorPoint}";
        //}
    }
}
