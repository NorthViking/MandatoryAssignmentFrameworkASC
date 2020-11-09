using System;
using System.Collections.Generic;
using System.Text;
using MandatoryAssignmentFrameworkASC.Interfaces;

namespace MandatoryAssignmentFrameworkASC.Equipment.Base
{
    public abstract class WeaponBase : EquipmentBase, IOffence
    {
        private Random rng = new Random();
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }


        public WeaponSlot WSlot { get; }
        public int DamageVariance
        {
            get { return rng.Next(MinDamage, MaxDamage); }
        }

        public WeaponBase(int minDamage, int maxDamage, string description, int goldValue, WeaponSlot wSlot) : base(
            description, goldValue, EquipmentCategory.weapon)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            WSlot = wSlot;

        }

        public override string ToString()
        {
            return  $"MinDamage: {MinDamage}, MaxDamage: {MaxDamage}";
        }
    }
}
