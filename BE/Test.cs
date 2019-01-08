using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
 public   class Test
    {
        public string test_Id { get=>tester_Id; private set=>tester_Id=value; }
        public string tester_Id { get=>tester_Id; private set=>tester_Id=value; }
        public string student_Id { get=>student_Id ; private set=> student_Id=value; }
        public DateTime date { get=> date; private set => date= value; }
        public DateTime time { get =>time ; private set=>time=value; }
        public Address address { get=>address; private set=>address=value; }
        public bool distance_keep { get=>distance_keep; private set =>distance_keep=value; }
        public bool reverse_parking { get; private set; }
        public bool mirrors { get=>mirrors; private set=>mirrors=value; }
        public bool signals { get=>signals; private set=>signals=value; } //aitutim
        public bool speed { get => speed; private set => speed = value; }
        public bool is_pass { get=>is_pass;  set=>is_pass=value; }
        public string note { get=>note;  set=> note=value; }
        public Gear_type gearBox { get => gearBox; set => gearBox = value; }
        public Vehicle car { get => car; set => car = value; }
        public double Grade
        {
        
            get
           {
                double sum = 0;
                sum += distance_keep == true ? 1 : 0;
                sum += reverse_parking == true ? 1 : 0;
                sum += mirrors == true ? 1 : 0;
                sum += signals == true ? 1 : 0;
                sum += speed == true ? 1 : 0;
                return sum / 5;//5 is the number of tests parmeters
            }
        }
        public Test(string testerId, string studentId, DateTime date, Address address, Gear_type gearBox, Vehicle car)

        {
            this.tester_Id = testerId;
            this.student_Id = studentId;
            this.date = date;
            this.address = address;
            this.gearBox = gearBox;
            this.car = car;

        }
        public Test(string testerId, string studentId, Gear_type gear, Vehicle car, 
        DateTime date, Address address, bool distance, bool parking, bool mirror, bool signal, bool spee, bool pass, string notes)

        {
            test_Id = null;
            this.tester_Id = testerId;
            this.student_Id = studentId;
            this.car = car;
            this.date = date;
            this.address = address;
            this.distance_keep = distance;
            this.reverse_parking = parking;
            this.mirrors = mirror;
            this.signals = signal;
            this.speed = spee;
            this.is_pass = pass;
            this.note = notes;
            this.gearBox = gear;
        }
        public object Clone()

        {

            Test temp = (Test)MemberwiseClone();

            temp.address = new Address(address.street, address.houseNumber, address.city);

            temp.date = new DateTime(date.Year, date.Month, date.Day);

            return temp;

        }



        public override string ToString()
        {
            string str = "";
            str += test_Id + " tester id: " + tester_Id + " treainee id: " + student_Id + " ";
            return str;
        }
    }
}