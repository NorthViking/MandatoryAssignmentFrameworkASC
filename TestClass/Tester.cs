using System;
using System.Collections.Generic;
using System.Text;
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
            Bear bear = new Bear(150,20,30,"brown bear");
            Helmet helmet = new Helmet(20, 5, "Steel Helmet", 6);
            Sword sword = new Sword(15, 25, 4, "Rougth Sword");
            hero.RecieveArmor(helmet);
            hero.RecieveWeapon(sword);
            IOffence EW = new OffenceDecorator(sword,1.7);
            Console.WriteLine(EW);
            bear.PositionX = 15;
            bear.PositionY = 15;
            world.AddCreature(bear);
            Console.WriteLine(bear.PositionX);
            Console.WriteLine(bear.PositionY);
            Console.WriteLine(world.Hero.PositionX);
            Console.WriteLine(world.Hero.PositionY);
            Console.WriteLine("is there a bear nearby"+ world.Nearby());
            IDefence defence = Factory.Create();
            Console.WriteLine(defence);
            defence = Factory.Create();
            Console.WriteLine(defence);
            
            //world.Combat();
            //helmet.PositionX = 15;
            //helmet.PositionY = 15;
            //world.AddEquipment(helmet);
            //Console.WriteLine(helmet.PositionX);
            //Console.WriteLine(helmet.PositionY);
            //Console.WriteLine(hero);
            //world.LootNearbyEquipment();
            //Console.WriteLine(hero);

            //Console.WriteLine(hero);
            //while (!hero.Dead && !bear.Dead)
            //{
            //    int damage = hero.DamageDealt();
            //    bear.ReceiveDamage(damage);
            //    Console.WriteLine(bear);
            //    int beardamage = bear.DamageVariance;
            //    hero.DamageRecieved(beardamage);
            //    Console.WriteLine(hero);
            //}


            //if (hero.Dead)
            //{
            //    Console.WriteLine("hero is dead");
            //}
            //else
            //{
            //    Console.WriteLine("bear is dead");
            //}




            Sword s1 = new Sword(40, 60, 2, "sword");
            Console.WriteLine(s1);
            //IOffence enchantedW = new OffenceDecorator(s1, 1.2);
            //Console.WriteLine(enchantedW);
            
        }
    }
}
