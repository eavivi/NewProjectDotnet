using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//note from yacov
namespace BE
{
   public class Tester
    {

       public string Id { get; set; }
       public string First_name { get=>First_name;  set=>First_name=value; }
       public string Last_name { get=>Last_name;  set=>Last_name=value; }
       public DateTime Date_birth { get=>Date_birth;  set=>Date_birth=value; }
       public Gender Gender { get=>Gender;  set=>Gender=value; }
       public string Phone { get=>Phone;  set=>Phone=value; }
       public Address Address { get=>Address;  set=>Address=value; }
       public int Experience { get=>Experience;  set=>Experience=value; }
       public int Tests_max { get=>Tests_max;  set=>Tests_max=value; }
       public Gear_type G_t { get => G_t;  set => G_t = value; }
       public Vehicle Vehicle { get=>Vehicle;  set=>Vehicle=value; }
       public bool[,] Work_range = new bool[5, 6] ;
       public double Max_distance { get=>Max_distance; set=>Max_distance=value; }
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
            this.Id = id;
            First_name = first;
            Last_name = last;
            Date_birth = birth;
            Gender = gen;
            this.Phone = phone;
            this.Address = Address;
            Vehicle = v;
            G_t = gt;
            Experience = experi;
            Tests_max = maxTests;
            Max_distance = maxDistance;
        }
             

        public override string ToString()
        {
            return "tester name: " + First_name + Last_name + "id: " + Id;
        }

        public object Clone()

        {
            Tester temp = (Tester)MemberwiseClone();
            temp.Address = new Address(Address.street, Address.houseNumber, Address.city);
            temp.Date_birth = new DateTime(Date_birth.Year, Date_birth.Month, Date_birth.Day);
            return temp;

        }
    }
}
