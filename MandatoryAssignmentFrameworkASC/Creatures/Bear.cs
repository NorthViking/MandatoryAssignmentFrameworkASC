﻿using System;
using System.Collections.Generic;
using System.Text;
using MandatoryAssignmentFrameworkASC.Creatures.Base;
using MandatoryAssignmentFrameworkASC.Equipment;

namespace MandatoryAssignmentFrameworkASC.Creatures
{
    public class Bear : CreatureBase
    {
        public Bear(int health, int minDamage, int maxDamage, string name) : base(
            health, minDamage, maxDamage, name)
        {
            ArmorDrop = new Boots(15,5,"steal boots",8);

        }


        public override void ReceiveDamage(int damage)
        {
            Health = Health - damage;
        }
    }
}
