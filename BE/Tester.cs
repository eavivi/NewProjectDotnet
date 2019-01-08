using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Tester
    {

       public string Id { get; set; }
       public string First_name { get=>First_name; private set=>First_name=value; }
       public string Last_name { get=>Last_name; private set=>Last_name=value; }
       public DateTime Date_birth { get=>Date_birth; private set=>Date_birth=value; }
       public Gender gender { get=>gender; private set=>gender=value; }
       public string phone { get=>phone; private set=>phone=value; }
       public Address address { get=>address; private set=>address=value; }
       public int experience { get=>experience; private set=>experience=value; }
       public int tests_max { get=>tests_max; private set=>tests_max=value; }
       public Gear_type g_t { get => g_t; private set => g_t = value; }
       public Vehicle vehicle { get=>vehicle; private set=>vehicle=value; }
       public bool[,] work_range = new bool[5, 6] ;
       public double max_distance { get=>max_distance; private set=>max_distance=value; }
       public int Age

        {
            get
            {
                // Save today's date.
                var today = DateTime.Today;
                // Calculate the age.
                var age = today.Year - Date_birth.Year;
                // Go back to the year the person was born in case of a leap year
                if (Date_birth > today.AddYears(-age)) age--;
                return age;
            }
            set => Date_birth = new DateTime(DateTime.Now.Year - value, 1, 1);//default month and day if enter only age
        }

        public Tester(string id, string first, string last, DateTime birth, Gender gen, string phone,
            Address addre,  int experi ,int maxTests, Vehicle v,  Gear_type gt, double maxDistance )
        {
            this.id = id;
            First_name = first;
            Last_name = last;
            Date_birth = birth;
            gender = gen;
            this.phone = phone;
            this.address = address;
            vehicle = v;
            g_t = gt;
            experience = experi;
            tests_max = maxTests;
            max_distance = maxDistance;
        }
             

        public override string ToString()
        {
            return "tester name: " + First_name + Last_name + "id: " + id;
        }

        public object Clone()

        {
            Tester temp = (Tester)MemberwiseClone();
            temp.address = new Address(address.street, address.houseNumber, address.city);
            temp.Date_birth = new DateTime(Date_birth.Year, Date_birth.Month, Date_birth.Day);
            return temp;

        }
    }
}
