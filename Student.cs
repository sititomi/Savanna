using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evofeladat
{
    public class Student : People
    {
        //melyik osztály tagja
        public string WhichClass { get; set; }
       
        public int[] AllMark { get; set; }

        public void getMark()
        {
            Console.WriteLine("Melyik tárgyból kap jegyet?");
            string Subject = Console.ReadLine();
            Console.WriteLine("Érdemjegy:");
            int mark = int.Parse(Console.ReadLine());
        }

        public  Student(string Name, string Sex, int BirthYear, string WhichClass) : base(Name, Sex, BirthYear)
        {
            this.WhichClass = WhichClass;   
        }

       /* public static void addStudent()
        {
            Console.WriteLine("Hánydiák van?");
            int Snumber = int.Parse(Console.ReadLine()); //tanárok száma
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
            }*/
        }
    }


