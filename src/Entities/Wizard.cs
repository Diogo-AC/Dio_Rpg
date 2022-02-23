using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio_Rpg.src.Entities
{
    public class Wizard : Hero
    {
    public Wizard(string Name, int Level, string Herotype, int Age,string Nationality){
        this.Name = Name;
        this.Level = Level;
        this.Herotype = Herotype;
        this.Age = Age;
        this.Nationality = Nationality;
    }
        public override string Attack(){
            return this.Name + " Lançou magia!";
        }

        public override string Attack(int Bonus){
            if (Bonus > 6){
                return this.Name + " Lançou magia super efetiva com + danos de ataque,com bonus de: " + Bonus;  
            }
            else{
                return this.Name + " Lançou magia com com pouca efetividade, com bonus de:" + Bonus;   
            }
            
            
        }

    }
    }