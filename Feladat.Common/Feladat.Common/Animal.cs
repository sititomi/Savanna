using System;

namespace Feladat.Common
{
    public class Animal
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    value = age;
            }
     
        }
        private int lifetime;

        public int ExpectedLifetime
        {
            get { return lifetime; }
            set
            {
                if (value > 0)
                    value = lifetime;
            }

        }

        public int Aging()
        {
            if (age > 0 && age < lifetime)
                return age++;
            return 10;
        }
        public void Aging2()
        {
            if (age > 0 && age < lifetime)
                age++;
        }
    }
}
