using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evofeladat;

namespace Evofeladat
{
    class Program 
    {
        public static DateTime Today { get; }

        static void Main(string[] args)
        {
            DateTime thisDay = DateTime.Today;
            #region Try
           /* Console.WriteLine(thisDay.Tostring());
            DateTime biday = new DateTime(1999, 1, 5, 12, 46, 0);
            Console.WriteLine(biday.Tostring());
            
          age = Aging(thisDay, biday);
             Console.WriteLine(Aging());
           
        People person1 = new People();
            Console.WriteLine("Adja meg az embocke nevét");
            person1.Name = Console.ReadLine();
            Console.WriteLine(person1.Name);
            int BirthYear = 2000;
            int age = person1.Aging(thisDay, BirthYear);
            Console.WriteLine(age);
            Teacher t1 = new Teacher();
            t1.Name = Console.ReadLine();
            Console.WriteLine(t1.Name);
            Student s1 = new Student();
            s1.getMark();
            Console.WriteLine("Adja meg az osztályt");
            s1.WhichClass = Console.ReadLine();
            Console.WriteLine(s1.WhichClass);*/
            #endregion
            Console.WriteLine(thisDay);

            T_Database d = new T_Database();
            d.addTeacher();
            d.theoldest();

            S_Database s = new S_Database();
            s.addStudent();
            s.theoldest();



            
            
            

            



            Console.ReadKey();
        }
       
    }
}


