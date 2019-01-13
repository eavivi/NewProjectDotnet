using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Trainee //student
    {
        
  
        public string Id { get;  set; }
        public string First_name { get => First_name;  set => First_name = value; }
        public string Last_name { get => Last_name;  set => Last_name = value; }
        public DateTime Date_birth { get => Date_birth;  set => Date_birth = value; }
        public Gender Gender { get=>Gender;  set=>Gender=value; }
        public string Phone { get => Phone;  set => Phone = value; }
        public Address Address { get => Address;  set => Address = value; }
        public Vehicle Vehicle { get => Vehicle;  set => Vehicle = value; }
        public Gear_type G_t { get => G_t;  set => G_t = value; }
        public string School { get => School;  set => School = value; }
        public string Teacher { get => Teacher;  set => Teacher = value; }
        public int Lesson_Num { get => Lesson_Num;  set => Lesson_Num = value; }
        public DateTime Registration_date { get => Registration_date; set => Registration_date = value; }

        public int Age
        {
            get
            {
                // Save today's date
              var today = DateTime.Today;
                // Calculate the age.
                var age = today.Year - Date_birth.Year;
                // Go back to the year the person was born in case of a leap year
                if (Date_birth > today.AddYears(-age)) age--;
                return age;
            }
            set => Date_birth = new DateTime(DateTime.Now.Year - value, 1, 1);//default month and day if enter only age
        }

        public Trainee(string id, string first, string last, DateTime birth, Gender gen, string phone, Address address, Vehicle v, Gear_type gt, string nameSchool, string nameTeacher, int numLess)
        {
            this.Id = id;
            First_name = first;
            Last_name = last;
            Date_birth = birth;
            Gender = gen;
            this.Phone = phone;
            this.Address = address;
            Vehicle = v;
            G_t = gt;
            School = nameSchool;
            Teacher = nameTeacher;
            Lesson_Num = numLess;
            Registration_date = DateTime.Now;
        }


            public override string ToString()
        {
            return "Trainee name:" + First_name + Last_name + "id:" + Id;
        }
    }
}
