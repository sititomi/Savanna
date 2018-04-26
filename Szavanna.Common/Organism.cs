using System;

namespace Szavanna.Common
{
    public class Organism
    {
        struct Position
            {
               public int posX; //a pozicio x koordinátája
               public int posY; //y koordináta

            internal Point(){ // kezdő érték, kiindulási pont
                this.posX = posX;
                this.posY = posY;
            }

            }
        //változó
        private int Age;
        private int Lifetime;
        private int Vitality;
        private int Hydratation;
        private int Reproduction; 
        private bool Exist; //létezés
        //tulajdonság
        public int Age
        {
            get { return Age; }
            internal set
            {
                if (value > 0)
                {
                    Age = value;
                }
            }
        }

        // metódus

        public int ExpectedLifetime
        {
            get { return ExpectedLifetime; }
            internal set{Age=value} 
        }

        public int Vitality()
        {
            get { return Vitality; }
            internal set{
            if(Vitality<=0)
            {
             Exist=0; //DEAD-mindenképp
            }
          
            }
}

    }

        public int Hydratation()
        {
            get {return Hydratation;}

            //internal set
        }

        public int Reproduction()
        {
            get {return Reproduction;}
            //internal set

        }
    }
    public void Movement();
    {
        switch(char)
                {
                    case 'w':  /*MOZGÁS, ELŐRE STB.*/
                    break;
                    case 'a':
                    break;
                    case 's':
                    break;
                    case 'd':
                    break;
                    default:
                    break;
                  }
    }
}
