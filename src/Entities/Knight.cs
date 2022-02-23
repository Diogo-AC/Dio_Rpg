using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio_Rpg.src.Entities
{
    public class Knight : Hero
    {
         public Knight(string Name, int Level, string Herotype, int Age,string Nationality){
        this.Name = Name;
        this.Level = Level;
        this.Herotype = Herotype;
        this.Age = Age;
        this.Nationality = Nationality;
        
    }
}
}