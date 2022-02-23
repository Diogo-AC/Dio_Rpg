using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio_Rpg.src.Entities
{
    public abstract class Hero{
        public Hero(string Name, int Level, string Herotype, int Age,string Nationality){
        this.Name = Name;
        this.Level = Level;
        this.Herotype = Herotype;
        this.Age = Age;
        this.Nationality = Nationality;
        }
        
        public string Name;
        public int Level;
        public string Herotype;
        public int Age;
        public string Nationality;

        public Hero(){
    
        }

        public override string ToString(){
            return this.Name+ " " + this.Level + " " + this.Herotype + " " + this.Age + " " + this.Nationality;
        }

        public virtual string Attack(){
            return this.Name + " Atacou com uma espada!";          
        }
        public virtual string Attack(int Bonus){
            if (Bonus > 6){
                return this.Name + " Atacou com duas espadas,com bonus de: " + Bonus;  
            }
            else{
                return this.Name + " Atacou com uma espada e um escudo, com bonus de:" + Bonus;   
            }
            
           
        }

    }
}