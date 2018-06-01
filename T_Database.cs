using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evofeladat;

namespace Evofeladat
{
    public class T_Database
    {
        
        static int Tnumber = 0; //tanárok száma
        Teacher[] teachers = new Teacher[Tnumber];

        public  T_Database () 
        {
            
        }
       
        public void addTeacher()
        {
            Console.WriteLine("Hány tanár van?");
            Tnumber = int.Parse(Console.ReadLine()); //tanárok száma
            Teacher[] teachers = new Teacher[Tnumber];
            for (int i = 0; i < Tnumber; i++)
            {
                Console.WriteLine("Adja meg a tanárok adatait:");
                Console.WriteLine("{0}. tanár", i + 1);
                Console.Write("Név:"); string Name = Console.ReadLine();
                Console.Write("Tanított árgy:"); string subject = Console.ReadLine();
                Console.Write("Nem:"); string Sex = Console.ReadLine();
                Console.Write("Születési év:"); int BirthYear = int.Parse(Console.ReadLine());
                teachers[i] = new Teacher(Name, Sex, BirthYear, subject);
                int age = teachers[i].Aging();
                Console.Write(age);
            }
        }

        public void theoldest()
        {
            int max = 0;
            //int max = teachers[0].Aging();
            for (int i = 0; i < Tnumber; i++)
            {
                
                //Radaleczki+Laucica+Anyatigris=szétszopatnak mint a kurva élet
                if (teachers[i].Aging() > max)
                {
                    max = teachers[i].Aging();
                }
                Console.WriteLine("\nA legidősebb tanár: {0} éves\n\n", max);
            }
           
        }

       


    }
}


