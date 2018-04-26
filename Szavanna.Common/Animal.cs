using System;
using System.Collections.Generic;
using System.Text;

namespace Szavanna.Common
{
    class Animal:Organism
    {   
        private int Damage;

        public void Attack(Animal animal) /*ESZIK*/ //wtf
        {
            Vitality -=Damage;
            Vitality -=Damage;
            Vitality += 20; //wtf
        }

       /* public void dmg(){
            if(ExpectedLifetime*0.6 > Age)
            dmg=strength+Vitality*0.2
            else(ExpectedLifetime*0.6<Age)
            dmg=strength+((ExpectedLifetime*0.6-Age)*7)+Vitality*0.2
}*/
        char char_wanted= 'space';
            switch(char_wanted)
                {
                    case 'space':
                    animal.Attack;          /*EZT RAKNÁNK A MAINBE*/
                    break;
                    default:
                    ;
                    break;
                  }
        

        public int Drink(Animal.water)
        {
                char char_wanted= 'q';
            switch(char_wanted)
                {
                    case 'q':
                    animal.Drink;          /*EZT IS RAKNÁNK A MAINBE*/
                    break;
                    default:
                    ;
                    break;
                  }
                
                 Vitality += 15;

        }
        private double Strength;
        public void Strength()
        {
        Strength=baseStrength*Age*0.1
        }

        public string Food()
        {

        }

        public int Hunger()
        {
        
        }
        

    }
}
