using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MandatoryAssignmentFrameworkASC.Equipment;
using MandatoryAssignmentFrameworkASC.Equipment.Base;
using MandatoryAssignmentFrameworkASC.Interfaces;

namespace MandatoryAssignmentFrameworkASC.Creatures
{
    public class Hero : IPosition
    {
        private string _name;
        private int _health;
        private int _armorPoint;
        private int _baseDamage;
        private int _goldOwned;
        private List<IDefence> _armorList = new List<IDefence>();
        private List<IOffence> _weaponList = new List<IOffence>();
        private Helmet _helmetOwned;
        private Chest _chestOwned;
        private Legs _legsOwned;
        private Boots _bootsOwned;
        private IOffence _swordOwned;
        private Shield _shieldOwned;

        public Hero(string name)
        {
            _name = name;
            _health = 100;
            _armorPoint = 0;
            _baseDamage = 5;
            _goldOwned = 0;
            _helmetOwned = null;
            _chestOwned = null;
            _legsOwned = null;
            _bootsOwned = null;
            _swordOwned = new Sword(15, 20, 5, "Plain Sword");
            _shieldOwned = null;
        }

        public int DamageDealt()
        {
            return _swordOwned.DamageVariance;
        }

        public int CombinedHealthItems()
        {
            int sum = _health;
            IEnumerable<IDefence> items = 
                from ab in _armorList
                where ab.Health > 0 
                select ab;
            foreach (var item in items)
            {
                sum += item.Health;
            }
            return sum;
        }

        public int CombinedArmorItems()
        {
            int sum = 0;
            IEnumerable<IDefence> items =
                from ab in _armorList
                where ab.ArmorPoint > 0
                select ab;
            foreach (var item in items)
            {
                sum += item.ArmorPoint;
            }
            return sum;
        }

        public int DamageRecieved(int damage)
        {

            int RealDamage = Convert.ToInt32(damage * (1 - _armorList.Sum(d => d.ArmorPoint) / 100.0));
            return _health = _health - RealDamage;

        }

        public void RecieveArmor(IDefence armor)
        {

            _armorList.Add(armor);
        }

        public void RecieveWeapon(IOffence weapon)
        {
            _swordOwned = weapon;
            _baseDamage = _baseDamage + weapon.DamageVariance;
            _weaponList.Add(weapon);
        }

        public bool Dead
        {
            get { return _health <= 0; }
        }

        //public override string ToString()
        //{
        //    return $"{nameof(_helmetOwned)}: {_helmetOwned}, {nameof(_chestOwned)}: {_chestOwned}, {nameof(_legsOwned)}: {_legsOwned}, {nameof(_bootsOwned)}: {_bootsOwned}, {nameof(_swordOwned)}: {_swordOwned}, {nameof(_shieldOwned)}: {_shieldOwned}";
        //}


        public int PositionX { get; set; }
        public int PositionY { get; set; }

        #region LootMethod
        public void Loot(IPosition position)
        {
            EquipmentBase equipment = position as EquipmentBase;
            if (equipment.Category == EquipmentCategory.weapon)
            {
                IOffence weapon = equipment as IOffence;
                if (_swordOwned.MaxDamage < weapon.MaxDamage)
                {
                    _swordOwned = weapon;
                    RecieveWeapon(weapon);
                }

            }
            else if (equipment.Category == EquipmentCategory.armor)
            {
                IDefence armor = equipment as IDefence;
                if (armor is Helmet)
                {
                    if (_helmetOwned != null && _helmetOwned.Health < armor.Health)
                    {
                        _helmetOwned = armor as Helmet;
                        RecieveArmor(_helmetOwned);
                    }
                    else if (_helmetOwned == null)
                    {
                        _helmetOwned = armor as Helmet;
                        RecieveArmor(_helmetOwned);

                    }
                }
                if (armor is Chest)
                {
                    if (_chestOwned != null && _chestOwned.Health < armor.Health)
                    {
                        _chestOwned = armor as Chest;
                        RecieveArmor(_chestOwned);
                    }
                    else if (_chestOwned == null)
                    {
                        _chestOwned = armor as Chest;
                        RecieveArmor(_chestOwned);

                    }
                }
                if (armor is Legs)
                {
                    if (_legsOwned != null && _legsOwned.Health < armor.Health)
                    {
                        _legsOwned = armor as Legs;
                        RecieveArmor(_legsOwned);
                    }
                    else if (_helmetOwned == null)
                    {
                        _legsOwned = armor as Legs;
                        RecieveArmor(_legsOwned);

                    }
                }
                if (armor is Boots)
                {
                    if (_bootsOwned != null && _bootsOwned.Health < armor.Health)
                    {
                        _bootsOwned = armor as Boots;
                        RecieveArmor(_bootsOwned);
                    }
                    else if (_helmetOwned == null)
                    {
                        _bootsOwned = armor as Boots;
                        RecieveArmor(_bootsOwned);
                    }
                }
                if (armor is Shield)
                {
                    if (_shieldOwned != null && _shieldOwned.Health < armor.Health)
                    {
                        _shieldOwned = armor as Shield;
                        RecieveArmor(_shieldOwned);
                    }
                    else if (_helmetOwned == null)
                    {
                        _shieldOwned = armor as Shield;
                        RecieveArmor(_shieldOwned);

                    }
                }
            }
        }

        #endregion


        public override string ToString()
        {
            return $"Name: {_name} Health: {CombinedHealthItems()},ArmorPoint: {CombinedArmorItems()}, MinDamage: {_swordOwned.MinDamage} MaxDamage: {_swordOwned.MaxDamage} Description: {_swordOwned.Description}";
        }
    }
}
