using System;
using System.Collections.Generic;
using System.Text;
using MandatoryAssignmentFrameworkASC.Interfaces;

namespace MandatoryAssignmentFrameworkASC.Creatures.Base
{
    public abstract class CreatureBase: ICreature, IPosition
    {
        private Random rng = new Random();
        public IDefence ArmorDrop { get; set; }
        public IOffence WeaponDrop { get; set; }
        public int Health { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public bool Dead
        {
            get { return Health <= 0; }
        }

        

        public int DamageVariance
        {
            get { return rng.Next(MinDamage, MaxDamage); }
        }

        public CreatureBase(int health, int minDamage, int maxDamage, string name)
        {
            Health = health;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Name = name;
        }

        public abstract void ReceiveDamage(int damage);

        
        public override string ToString()
        {
            return $"Creature: {Name}, Health:{Health} Damage: {DamageVariance}";
        }

        public int PositionX { get; set; }
        public int PositionY { get; set; }
    }
}
