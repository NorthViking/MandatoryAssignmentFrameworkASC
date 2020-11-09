using System;
using System.Collections.Generic;
using System.Text;
using MandatoryAssignmentFrameworkASC.Creatures;
using MandatoryAssignmentFrameworkASC.Equipment.Base;
using MandatoryAssignmentFrameworkASC.Interfaces;

namespace MandatoryAssignmentFrameworkASC.Equipment
{
    public class Shield : ArmorBase
    {
        private Random rng = new Random();
        public Shield(int health, int armorPoint, string description, int goldValue) :base(
            health, armorPoint, description, goldValue,ArmorSlot.shield)
        { }


        //public int Health { get; set; }
        //public int Block { get; set; }
        //public int ArmorPoint { get; set; }


        //public Shield(int health, int armorPoint, int goldValue) :base("Shield",goldValue,EquipmentCategory.armor)
        //{
        //    Health = health;
        //    Block = block;
        //    ArmorPoint = armorPoint;

        //}

        //public override string ToString()
        //{
        //    return base.ToString() + $", HP: {Health},Block: {Block}, AP: {ArmorPoint}";
        //}
    }
}
