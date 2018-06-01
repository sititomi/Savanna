using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evofeladat
{
    public class Teacher:People  
    {
        //amit tanit
        public string subject { get; set; }


        public void giveMark()
        {
            Console.WriteLine("Melyik diák?");
            string StudentName = Console.ReadLine();
            Console.WriteLine("Érdemjegy:");
            int mark = int.Parse(Console.ReadLine());
        }

        public Teacher(string Name, string Sex, int BirthYear, string subject) : base(Name,Sex,BirthYear)
        {
            this.subject = subject;  
        }


       /* public static void addTeacher()
        {
            Console.WriteLine("Hány tanár van?");
            int Tnumber = int.Parse(Console.ReadLine()); //tanárok száma
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
            }*/
        }

    }
