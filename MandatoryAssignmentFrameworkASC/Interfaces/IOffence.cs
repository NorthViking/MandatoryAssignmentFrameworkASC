using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryAssignmentFrameworkASC.Interfaces
{
    public interface IOffence
    {
        int MinDamage { get; set; }
        int MaxDamage { get; set; }
        string Description { get; }
        int DamageVariance { get; }
    }
}
