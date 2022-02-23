using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio_Rpg.src.Entities
{
    public class Villain : Hero
    {
        public Villain(string Name, int Level, string Herotype, int Age,string Nationality){
        this.Name = Name;
        this.Level = Level;
        this.Herotype = Herotype;
        this.Age = Age;
        this.Nationality = Nationality;
    }
    public override string Attack(){
            return this.Name + " Atacou com uma joia do infito";
        }

        public override string Attack(int Bonus){
            if (Bonus > 6){
                return this.Name + " Atacou com cinco joias do infinito, com um bonus de :  " + Bonus;  
            }
            else{
                return this.Name + " Atacou com duas joias do infinito, com um bonus de :  " + Bonus;   
            }
            
}
}
}