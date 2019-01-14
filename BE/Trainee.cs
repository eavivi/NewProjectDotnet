using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Trainee //student
    {
        
  
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_IdTrainee"></param>
        /// <param name="_LastName"></param>
        /// <param name="_FirstName"></param>
        /// <param name="_DateOfBirth"></param>
        /// <param name="_gender"></param>
        /// <param name="_PhoneNumber"></param>
        /// <param name="_City"></param>
        /// <param name="_Steet"></param>
        /// <param name="_TeacherName"></param>
        /// <param name="_Driving_school"></param>
        /// <param name="_GearType"></param>
        /// <param name="_CarType"></param>
        /// <param name="_Email"></param>
        public Trainee(string _IdTrainee,string _Password, string _LastName, string _FirstName, DateTime _DateOfBirth, Gender _gender, string _PhoneNumber, string _City, string _Steet, string _TeacherName, string _Driving_school, Gear_Type _GearType, Car_Type _CarType, string _Email)
        {
            Password = _Password;
            IdTrainee = _IdTrainee;
            LastName = _LastName;
            FirstName = _FirstName;
            DateOfBirth = _DateOfBirth;
            gender = _gender;
            PhoneNumber = _PhoneNumber;
            City = _City;
            Street = _Street;
            TeacherName = _TeacherName;
            Driving_school = _Driving_school;
            GearType = _GearType;
            CarType = _CarType;
            Email = _Email;

            NumLesson = 0;

        }

        /// <summary>
        /// default ctor
        /// </summary>
        public Trainee()
        {
            _NumLesson = 0;
        }


        string Password;
        /// <summary>
        /// Password to login
        /// </summary>
        public string _Password
        {
            get { return Password; }
            set { Password = value; }
        }

        string IdTrainee;
        /// <summary>
        /// return/set legal id of the Trainee
        /// </summary>
        public string _IdTrainee
        {
            get { return IdTrainee; }
            set
            {
                //check if the string contain only numbers
                int n;
                bool IsNumeric = int.TryParse(value, out n);

                if (IsNumeric == false)
                    throw new Exception("תעודת זהות חייבת להכיל רק מספרים");
                

                if (value.Length != 9)
                    throw new Exception("נא להכניס תעודת זהות בעלת 9 ספרות");
                IdTrainee = value;

            }
        }


        string LastName;
        /// <summary>
        /// return/set last name of the Trainee
        /// </summary>
        public string _LastName
        {
            get { return "  " + LastName ; }
            set { LastName = value; }
        }


        string FirstName;
        /// <summary>
        /// return/set first name of the Trainee
        /// </summary>
        public string _FirstName
        {
            get { return ("  "+FirstName); }
            set { FirstName = value; }
        }


        public string Fname_Lname()
        {
            return ( FirstName + " " + LastName );
        } 

        DateTime DateOfBirth;
        /// <summary>
        /// get viarable of DateTime to Date Of Birth the Trainee
        /// </summary>
        public DateTime _DateOfBirth
        {
            get { return DateOfBirth; }
            set { DateOfBirth = value; }
        }


        Gender gender;
        /// <summary>
        /// gender of the Trainee
        /// </summary>
        public Gender _gender
        {
            get { return gender; }
            set { gender = value; }
        }


        string PhoneNumber;
        /// <summary>
        /// get/set valid phone number of the Trainee
        /// </summary>
        public string _PhoneNumber
        {
            get { return PhoneNumber; }
            set
            {
                int n;
                bool IsNumeric = int.TryParse(value, out n);
                if (value.Length != 10 || IsNumeric == false)
                    throw new Exception(" נא להכניס מספר פלאפון תקין");
                PhoneNumber = value;

            }
        }


        string City;
        /// <summary>
        /// property to the address of the Trainee
        /// </summary>
        public string _City
        {  
            get { return City; }
            set { City = value; }
        }


        string Street;
        /// <summary>
        /// property to the address of the Trainee
        /// </summary>
        public string _Street
        {
            get { return Street; }
            set { Street = value; }
        }


        string Email;
        /// <summary>
        /// Mail of the trainee
        /// </summary>
        public string _Email
        {
            get {  return Email; }
            set
            {
                if (!(value.Contains("@") && value.Contains(".")))
                    throw new Exception("כתובת המייל לא תקינה");
                Email = value;
            }
        }  

        Car_Type CarType;
        /// <summary>
        /// car type of the Trainee
        /// </summary>
        public Car_Type _CarType
        {
            get { return CarType; }
            set { CarType = value; }
        }


        Gear_Type GearType;
        /// <summary>
        /// gear type that trainee
        /// </summary>
        public Gear_Type _GearType
        {
            get { return GearType; }
            set { GearType = value; }
        }

        string Driving_school;
        /// <summary>
        /// name of the Driving school
        /// </summary>
        public string _Driving_school
        {
            get { return Driving_school; }
            set { Driving_school = value; }
        }


        string TeacherName;
        /// <summary>
        /// the name of the teacher
        /// </summary>
        public string _TeacherName
        {
            get { return TeacherName; }
            set { TeacherName = value; }
        }

        int NumLesson;
        /// <summary>
        /// number of the lessons the student did
        /// </summary>
        public int _NumLesson
        {
            get { return NumLesson; }
            set { NumLesson = value; }
        }


        /// <summary>
        /// return ToString of the Trainee
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str = (IdTrainee+ " :תעודת זהות"  + '\n' + FirstName + " :שם פרטי" +  '\n' + LastName + " :שם משפחה"  + '\n');
            if (gender == Gender.female)
                str += "אישה" + " :מין" + '\n';
            else str += "גבר" + '\n';
            str += DateOfBirth.ToString() + " :תאריך לידה" + '\n' + PhoneNumber + " :מספר טלפון" +  '\n' + City + " :עיר" + '\n' + Street + " :רחוב" + '\n';
            if (CarType == Car_Type.Heavy_Truck)
                str += "משאית כבדה"  + '\n';
            if (CarType == Car_Type.Medium_truck)
                str += "משאית בינונית" + " :סוג רכב" + '\n';
            if (CarType == Car_Type.private_car)
                str += "מכונית פרטית"+" :סוג רכב" +'\n';
            else str += "רכב דו-גלגלי" + " :סוג רכב" + '\n';
            if (GearType == Gear_Type.automatic)
                str += "סוג תיבת הילוכים: אוטומטי" + '\n';
            else str += "סוג תיבת הילוכים: ידני" + '\n';
            str += Driving_school + " :בית ספר לנהיגה" +  '\n' + TeacherName + " :שם של מורה" + '\n' + NumLesson + " :מספר שיעור" +  '\n';
            return str;

        }
    }
    
}
