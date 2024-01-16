using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg_csharp
{
    public class Character
    {
        
        public Character(){}
        public Character(string name, int life, int shield, int damage, int level){

        }

        public string Name { get; set; }
        public int Life { get; set; }
        public int Damage { get; set; }
        public int Shield { get; set; }
        public int BaseLife { get; set; }
        public int BaseDamage { get; set; }
        public int BaseShield { get; set; }
        public int Power { get; set; }
        public int Level { get; set; }

        public void CalculatePower(){

            double power = (this.BaseLife * 0.4) + (this.BaseDamage * 0.4) + (this.BaseShield * 0.2);
            this.Power = Convert.ToInt32(power);
        }

        public void Attack(Character character){

            character.Life -= this.Damage - character.Shield;

        }
    }
}