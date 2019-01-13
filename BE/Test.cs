using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
 public   class Test
    {
        public string Test_Id { get=>Tester_Id;  set=>Tester_Id=value; }
        public string Tester_Id { get=>Tester_Id;  set=>Tester_Id=value; }
        public string Student_Id { get=>Student_Id ;  set=> Student_Id=value; }
        public DateTime Date { get=> Date;  set => Date= value; }
        public DateTime Time { get =>Time ;  set=>Time=value; }
        public Address Address { get=>Address;  set=>Address=value; }
        public bool Distance_keep { get=>Distance_keep;  set =>Distance_keep=value; }
        public bool Reverse_parking { get=>Reverse_parking;  set =>Reverse_parking=value; }
        public bool Mirrors { get=>Mirrors; set=>Mirrors=value; }
        public bool Signals { get=>Signals;  set=>Signals=value; } //aitutim
        public bool Speed { get => Speed;  set => Speed = value; }
        public bool Is_pass { get=>Is_pass;  set=>Is_pass=value; }
        public string Note { get=>Note;  set=> Note=value; }
        public Gear_type GearBox { get => GearBox; set => GearBox = value; }
        public Vehicle Car { get => Car; set => Car = value; }
        public double Grade
        {
        
            get
           {
                double sum = 0;
                sum += Distance_keep == true ? 1 : 0;
                sum += Reverse_parking == true ? 1 : 0;
                sum += Mirrors == true ? 1 : 0;
                sum += Signals == true ? 1 : 0;
                sum += Speed == true ? 1 : 0;
                return sum / 5;//5 is the number of tests parmeters
            }
        }
        public Test(string testerId, string studentId, DateTime date, Address address, Gear_type gearBox, Vehicle car)

        {
            this.Tester_Id = testerId;
            this.Student_Id = studentId;
            this.Date = date;
            this.Address = address;
            this.GearBox = gearBox;
            this.Car = car;

        }
        public Test(string testerId, string studentId, Gear_type gear, Vehicle car, 
        DateTime date, Address address, bool distance, bool parking, bool mirror, bool signal, bool spee, bool pass, string notes)

        {
            Test_Id = null;
            this.Tester_Id = testerId;
            this.Student_Id = studentId;
            this.Car = car;
            this.Date = date;
            this.Address = address;
            this.Distance_keep = distance;
            this.Reverse_parking = parking;
            this.Mirrors = mirror;
            this.Signals = signal;
            this.Speed = spee;
            this.Is_pass = pass;
            this.Note = notes;
            this.GearBox = gear;
        }
        public object Clone()

        {

            Test temp = (Test)MemberwiseClone();

            temp.Address = new Address(Address.street, Address.houseNumber, Address.city);

            temp.Date = new DateTime(Date.Year, Date.Month, Date.Day);

            return temp;

        }



        public override string ToString()
        {
            string str = "";
            str += Test_Id + " tester id: " + Tester_Id + " treainee id: " + Student_Id + " ";
            return str;
        }
    }
}