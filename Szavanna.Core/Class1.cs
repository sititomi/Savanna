using System;

namespace ClassLibrary1
{
    public class Organisms
    {
        //változó
        private int age;

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

        public int ExpectedLifeTiem { get; set; }

        // metódus
        public int GetAge()
        {
            return 0;
        }

        public int ExpectedLifetime()
        {

        }

        public int Vitality()
        {

        }

        public int Hydratation()
        {

        }

        public int Reproduction()
        {

        }


        public class Animals
        {
            public String Gender()
            {

            }

            public int Movement_Speed()
            {

            }

            public int Strength()
            {

            }

            public int Stealth()
            {

            }

            public int Vision()
            {

            }

            public String Food()
            {

            }

            public int Hunger()
            {

            }

            public class Carnivores
            {
                public class Lion
                {
                    public fight()
                    {

                    }
                    public dontkillAlpacas()
                    {

                    }
                }
                public class Cheetah
                {
                    public climbTree()
                    {

                    }
                }
                public class Leopard
                {

                }
                public class Crocodile
                {
                    public Swim()
                    {

                    }
                }
            }

            public class Herbivores
            {
                public class Alpaca
                {
                    public Immortal()
                    {

                    }
                }
                public class Timon
                {
                    public Dig()
                    {

                    }
                }

                public class Pumba
                {
                    public Fart()
                    {

                    }
                }

                public class Elephant
                {
                    public Heavy()
                    {

                    }
                }

                public class Hyppo
                {
                    public Swim()
                    {

                    }
                }

                public class Koala
                {
                    public climbTree()
                    {

                    }
                }

                public class Giraffe
                {
                    public eatTree()
                    {

                    }
                }

                public class Monkey
                {
                    public climbTree()
                    {

                    }
                    public throwRock()
                    {

                    }
                }
            }
        }

        public class Plants
        {
            public int Size()
            {

            }

            public int Max_Size()
            {

            }

            public int Growth()
            {

            }

            public class Tree
            {

            }

            public class Grass
            {

            }
        }
    }

    public class Cells
    {
        public class Land
        {
            public class Plain
            {

            }

            public class Hill
            {

            }

            public class Mountain
            {

            }
        }

        public class Water
        {
            public class Shallow
            {

            }
            public class Deep
            {

            }
        }
    }
}
