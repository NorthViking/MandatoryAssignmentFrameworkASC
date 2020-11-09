using System;
using System.Collections.Generic;
using System.Text;
using MandatoryAssignmentFrameworkASC.Creatures;
using MandatoryAssignmentFrameworkASC.Creatures.Base;
using MandatoryAssignmentFrameworkASC.Equipment.Base;
using MandatoryAssignmentFrameworkASC.Interfaces;

namespace MandatoryAssignmentFrameworkASC
{
    public class World
    {
        private Random random = new Random();
        private static int _currentState;
        private static int _height;
        private static int _width;
        private static List<IPosition>[,] _playground;
        private Hero _hero;
        private ICreature _creature;

        //private List<Equipment> equipments;
        //private List<Creature> _creatures;
        //private List<Obstacle> _obstacles;

        public World(int height, int width)
        {
            _height = height;
            _width = width;
            _playground = new List<IPosition>[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    _playground[i, j] = new List<IPosition>();
                }
            }

            _hero = new Hero("Caspar");
            _hero.PositionX = height / 2;
            _hero.PositionY = width / 2;
            _playground[_height / 2, _width / 2].Add(_hero);
            _playground[_height/4,_width/4].Add(new Bear(100,15,25,"Brown Bear"));
            
            
        }

        public Hero Hero
        {
            get { return _hero; }
        }

        public static int CurrentState
        {
            get => _currentState;
            set => value = _currentState;
        }

        public ICreature Creature
        {
            get { return _creature; }
        }

        public bool Nearby()
        {
            if (_playground[_hero.PositionX,_hero.PositionY].Count>1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public void LootNearbyEquipment()
        {
            List<IPosition> position = _playground[_hero.PositionX, _hero.PositionY];
            foreach (var E in position)
            {
                if (E is EquipmentBase)
                {
                    _hero.Loot(E);
                }
            }
        }

        public ICreature GetNearbyCreature()
        {
            List<IPosition> position = _playground[_hero.PositionX, _hero.PositionY];
            foreach (var P in position)
            {
                if (P is ICreature)
                {
                    return P as ICreature;
                }
                
            }

            return null;
        }

        public void AddEquipment(EquipmentBase equipment)
        {
            _playground[equipment.PositionX,equipment.PositionY].Add(equipment);
        }

        public void AddCreature(CreatureBase creature)
        {
            _playground[creature.PositionX,creature.PositionY].Add(creature);
        }

        public void InitiateFight()
        {
            _creature = GetNearbyCreature();
            while (!Hero.Dead && !Creature.Dead)
            {

                Hero.DamageDealt();
                Creature.ReceiveDamage(Hero.DamageDealt());
                while (!Creature.Dead)
                {
                    Hero.DamageRecieved(Creature.DamageVariance);
                }
            }
        }

        public int Combat()
        {
            _creature = GetNearbyCreature();
            if (Nearby())
            {
                if (!Hero.Dead && !Creature.Dead)
                {
                    InitiateFight();
                }

                return CurrentState;
            }

            return CurrentState;
        }

    }
}
