using System;
using static System.Console;
using Dio_Rpg.src.Entities;

namespace Dio_Rpg
{
    class Program
    {
        static void Main(string[] args)
        {
           Knight hero = new Knight("Arus", 23, "knight", 32, "Brazilian");
           Villain oponnet = new Villain("Thanos", 98, "Devil", 118, "Titã");
           Wizard wizard = new Wizard("Jennica", 75, "White Wizard", 85, "Italian"); 
            
            WriteLine(hero);
            WriteLine(hero.Attack());
            WriteLine(hero.Attack(7));
            WriteLine(oponnet);
            WriteLine(oponnet.Attack());
            WriteLine(oponnet.Attack(6));
            WriteLine(wizard);
            WriteLine(wizard.Attack());
            WriteLine(wizard.Attack(8));
        }
    }
}
