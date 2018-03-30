using System;

namespace Szavanna.Common
{
    public class Organism
    {
        //változó
        private int age;
        private int lifetime;
        private int vitality;
        private int hydratation;
        private int reproduction;

        //tulajdonság
        public int Age
        {
            get { return age; }
            internal set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

        // metódus
        public int GetAge()
        {
            return 0;
        }

        

        public int ExpectedLifetime
        {
            get { return lifetime; }
            internal set
  
        }

        public int Vitality()
        {
            get { return vitality; }
            internal set
}

    }

        public int Hydratation()
        {
            get { return hydratation; }
            internal set
        }

        public int Reproduction()
        {
            get { return reproduction; }
            internal set

        }

    }

    
}
