using System;
using System.Collections.Generic;
using System.Text;
using MandatoryAssignmentFrameworkASC.Interfaces;

namespace MandatoryAssignmentFrameworkASC.Equipment.Base
{
    public abstract class ArmorBase : EquipmentBase, IDefence
    {
        public int Health { get; set; }
        public int ArmorPoint { get; set; }
        public ArmorSlot ASlot { get; }

        public ArmorBase(int health, int armorPoint, string description, int goldValue, ArmorSlot aSlot): base(
            description,goldValue, EquipmentCategory.armor)
        {
            Health = health;
            ArmorPoint = armorPoint;
            ASlot = aSlot;
        }

        public override string ToString()
        {
            return  $" Name: {Description}  HP: {Health}, ArmorPoints: {ArmorPoint}";
        }
    }
}
