using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evofeladat
{
    public class S_Database
    {
        static int Snumber = 0; //diákok száma
        Student[] students = new Student[Snumber];
        public void S_database()
        {

        }
        public void addStudent()
        {
            Console.WriteLine("Hánydiák van?");
            Snumber = int.Parse(Console.ReadLine()); //diákok száma
            Student[] students = new Student[Snumber];
            for (int i = 0; i < Snumber; i++)
            {
                Console.WriteLine("Adja meg a diákok adatait:");
                Console.WriteLine("{0}. diák", i + 1);
                Console.Write("Név:"); string Name = Console.ReadLine();
                Console.Write("Nem:"); string Sex = Console.ReadLine();
                Console.Write("Osztály:"); string WhichClass = Console.ReadLine();
                Console.Write("Születési év:"); int BirthYear = int.Parse(Console.ReadLine());
                students[i] = new Student(Name, Sex, BirthYear, WhichClass);
                int age = students[i].Aging();
                Console.Write(age);
            }
        }

        public void theoldest()
        {
            Console.WriteLine("\nMelyik diák kap érdemjegyet?");
            string s1 = Console.ReadLine();
            for (int i = 0; i<Snumber; i++)
            {
                if (s1==students[i].Name)
                {

                    students[i].getMark();
            Console.WriteLine(students[i].AllMark);
                }
        }
        
}

    }
}
