using System;
using System.Collections.Generic;
using System.Text;
using MandatoryAssignmentFrameworkASC.Interfaces;

namespace MandatoryAssignmentFrameworkASC.Equipment.Base
{
    public class OffenceDecorator : IOffence
    {
        private IOffence _weapon;
        private double _procent;

        public OffenceDecorator(IOffence weapon, double procent)
        {
            _weapon = weapon;
            _procent = procent;
        }

        public int MinDamage { get{return Convert.ToInt32(_weapon.MinDamage * _procent); } set { } }
        public int MaxDamage { get { return Convert.ToInt32(_weapon.MaxDamage * _procent);} set { } }

        public string Description
        {
            get { return _weapon.Description; }
        }

        public int DamageVariance
        {
            get { return _weapon.DamageVariance; }
        }

        public override string ToString()
        {
            return $"MinDamage = {MinDamage}, MaxDamage = {MaxDamage}";
        }
    }
}
