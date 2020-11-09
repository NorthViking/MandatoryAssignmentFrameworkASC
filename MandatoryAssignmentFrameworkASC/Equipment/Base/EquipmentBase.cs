using System;
using System.Collections.Generic;
using System.Text;
using MandatoryAssignmentFrameworkASC.Interfaces;

namespace MandatoryAssignmentFrameworkASC.Equipment.Base
{
    public abstract class EquipmentBase: IPosition
    {
        public string Description { get; } 
        public int GoldValue { get; }
        public EquipmentCategory Category { get; }

        public EquipmentBase(string description, int goldValue, EquipmentCategory category)
        {
            Description = description;
            GoldValue = goldValue;
            Category = category;
        }

        public EquipmentBase() { }

        public override string ToString()
        {
            return  $"{Description} is worth {GoldValue} gold"  ;
        }

        public int PositionX { get; set; }
        public int PositionY { get; set; }
    }
}
