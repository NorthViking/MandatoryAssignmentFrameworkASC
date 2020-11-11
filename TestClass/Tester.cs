using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Channels;
using MandatoryAssignmentFrameworkASC;
using MandatoryAssignmentFrameworkASC.Creatures;
using MandatoryAssignmentFrameworkASC.Equipment;
using MandatoryAssignmentFrameworkASC.Equipment.Base;
using MandatoryAssignmentFrameworkASC.Factories;
using MandatoryAssignmentFrameworkASC.Interfaces;


namespace TestClass
{
    public class Tester
    {
        public void Start()
        {
            World world = new World(30,30);
            Hero hero = new Hero("Caspar");
            Bear bear = new Bear(150,15,23,"brown bear");
            Helmet helmet = new Helmet(20, 5, "Steel Helmet", 6);
            Chest chest = new Chest(30,7,"iron chest",9);
            Sword sword1 = new Sword(20, 30, 4, "Rougth Sword");
            hero.RecieveWeapon(sword1);
            IOffence EW = new OffenceDecorator(sword1,1.7);
            Console.WriteLine(EW);
            bear.PositionX = 15;
            bear.PositionY = 15;
            world.AddCreature(bear);
            Console.WriteLine(bear.PositionX);
            Console.WriteLine(bear.PositionY);
            Console.WriteLine(world.Hero.PositionX);
            Console.WriteLine(world.Hero.PositionY);
            Console.WriteLine("is there a bear nearby" + world.Nearby());
            IDefence defence = Factory.Create();
            Console.WriteLine(defence);
            defence = Factory.Create();
            Console.WriteLine(defence);
            hero.RecieveArmor(chest);
            hero.RecieveArmor(helmet);
            Console.WriteLine(hero);
            Console.WriteLine(bear);
            while (!hero.Dead && !bear.Dead)
            {
                int damage = hero.DamageDealt();
                bear.ReceiveDamage(damage);
                Console.WriteLine(bear);
                int beardamage = bear.DamageVariance;
                hero.DamageRecieved(beardamage);
                Console.WriteLine(hero);
            }

            if (hero.Dead)
            {
                Console.WriteLine("hero is dead");
            }
            else
            {
                Console.WriteLine("bear is dead");
            }

            //helmet.PositionX = 15;
            //helmet.PositionY = 15;
            //world.AddEquipment(helmet);
            //Console.WriteLine(helmet.PositionX);
            //Console.WriteLine(helmet.PositionY);
            //Console.WriteLine(hero);
            //world.LootNearbyEquipment();
            //Console.WriteLine(hero);
           




            //Sword s1 = new Sword(40, 60, 2, "sword");
            //Console.WriteLine(s1);
            //IOffence enchantedW = new OffenceDecorator(s1, 1.2);
            //Console.WriteLine(enchantedW);

        }
    }
}
