using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryAssignmentFrameworkASC.Interfaces
{
    public interface ICreature
    {
        int Health { get; set; }
        int MinDamage { get; set; }
        int MaxDamage { get; set; }
        string Name { get; set; }
        void ReceiveDamage(int damage);
        int DamageVariance { get; }
        bool Dead { get; }
    }
}
