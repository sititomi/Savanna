using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Evofeladat
{
     public class People // egy iskolában, mindenkire vonatkozik
    {
        public string Name { get;set; }
        public int BirthYear { get; set; }
        public string Sex { get; set; }
        DateTime Today { get; }

        public int Aging()
        {
            DateTime thisDay = DateTime.Today;
            return  (Today.Year - BirthYear);

           /* DateTime now = DateTime.Now;
            int age = now.Year - BirthYear.Year;
          */
        }

        public People(string Name, string Sex, int BirthYear)
        {
            this.Name = Name;
            this.Sex = Sex;
            this.BirthYear = BirthYear;
        }

  

        
    }

}
