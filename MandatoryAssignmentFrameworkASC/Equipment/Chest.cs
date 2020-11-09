using System;
using System.Collections.Generic;
using System.Text;
using MandatoryAssignmentFrameworkASC.Equipment.Base;
using MandatoryAssignmentFrameworkASC.Interfaces;

namespace MandatoryAssignmentFrameworkASC.Equipment
{
    public class Chest :ArmorBase
    {
        public Chest(int health, int armorPoint, string description, int goldValue) : base(
            health, armorPoint, description, goldValue, ArmorSlot.chest)
        { }
        //public int Health { get; set; }
        //public int Block { get; set; }
        //public int ArmorPoint { get; set; }


        //public Chest(int health, int armorPoint, int goldValue) :base("Chest",goldValue,EquipmentCategory.armor)
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
