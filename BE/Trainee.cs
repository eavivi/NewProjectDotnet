using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Trainee //student for test
    {

        public string id { get;  set; }
        public string first_name { get => first_name; private set => first_name = value; }
        public string last_name { get => last_name; private set => last_name = value; }
        public DateTime date_birth { get => date_birth; private set => date_birth = value; }
        public Gender gender { get=>gender; private set=>gender=value; }
        public string phone { get => phone; private set => phone = value; }
        public Address address { get => address; private set => address = value; }
        public Vehicle vehicle { get => vehicle; private set => vehicle = value; }
        public Gear_type g_t { get => g_t; private set => g_t = value; }
        public string school { get => school; private set => school = value; }
        public string teacher { get => teacher; private set => teacher = value; }
        public int lesson_Num { get => lesson_Num; private set => lesson_Num = value; }
        public DateTime Registration_date { get => Registration_date; set => Registration_date = value; }

        public int Age
        {
            get
            {
                // Save today's date
              var today = DateTime.Today;
                // Calculate the age.
                var age = today.Year - date_birth.Year;
                // Go back to the year the person was born in case of a leap year
                if (date_birth > today.AddYears(-age)) age--;
                return age;
            }
            set => date_birth = new DateTime(DateTime.Now.Year - value, 1, 1);//default month and day if enter only age
        }

        public Trainee(string id, string first, string last, DateTime birth, Gender gen, string phone, Address address, Vehicle v, Gear_type gt, string nameSchool, string nameTeacher, int numLess)
        {
            this.id = id;
            first_name = first;
            last_name = last;
            date_birth = birth;
            gender = gen;
            this.phone = phone;
            this.address = address;
            vehicle = v;
            g_t = gt;
            school = nameSchool;
            teacher = nameTeacher;
            lesson_Num = numLess;
            Registration_date = DateTime.Now;
        }


            public override string ToString()
        {
            return "Trainee name:" + first_name + last_name + "id:" + id;
        }
    }
}
