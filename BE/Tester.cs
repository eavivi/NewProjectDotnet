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

      {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_Schedule"></param>
        /// <param name="_Password"></param>
        /// <param name="_Email"></param>
        /// <param name="_MaxWeeklyTests"></param>
        /// <param name="_DateOfBirth"></param>
        /// <param name="_CarType"></param>
        /// <param name="_experience"></param>
        /// <param name="_address"></param>
        /// <param name="_gender"></param>
        /// <param name="_PhoneNumber"></param>
        /// <param name="_IdTester"></param>
        /// <param name="_LastName"></param>
        /// <param name="_FirstName"></param>
        public Tester(bool[,] _Schedule,string _city, string _street, Gear_Type _GearType,  string _Password, string _Email, int _MaxWeeklyTests, DateTime _DateOfBirth , Car_Type _CarType, int _experience, Gender _gender, string _PhoneNumber, string _IdTester= "",string _LastName="",string _FirstName="")
        {
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 5; j++)
                    Schedule[i, j] = _Schedule[i, j];


            GearType = _GearType;
            Password = _Password;
            Email = _Email;
            MaxWeeklyTests =_MaxWeeklyTests;
            CarType=_CarType;
            experience=_experience;
            City= _city;
            Street = _street;
            gender = _gender;
            PhoneNumber = _PhoneNumber;
            IdTester = _IdTester;
            LastName = _LastName;
            FirstName = _FirstName;
            DateOfBirth = _DateOfBirth;
        }

        /// <summary>
        /// default ctor
        /// </summary>
        public Tester()
        {

        }

        string IdTester;
        /// <summary>
        /// return/set legal id of the tester
        /// </summary>
        public string _IdTester
        {
            get { return IdTester; }
            set
            {
                //check if the string contain only numbers
                int n;
                bool IsNumeric = int.TryParse(value, out n);

                if (IsNumeric == false)
                    throw new Exception("תעודת זהות חייבת להכיל רק מספרים");


                if (value.Length != 9)
                    throw new Exception("נא להכניס תעודת זהות בעלת 9 ספרות");
                IdTester = value;
            }
        }

        string Email;
        /// <summary>
        /// Mail of the tester
        /// </summary>
        public string _Email
        {
            get { return Email; }
            set
            {
                if (!(value.Contains("@") && value.Contains(".")))
                    throw new Exception("כתובת המייל לא תקינה");
                Email = value;
            }
        }

        string LastName;
        /// <summary>
        /// return/set last name of the tester
        /// </summary>
        public string _LastName
        {
            get { return "  " + LastName; }
            set { LastName = value; }
        }

        string FirstName;
        /// <summary>
        /// return/set first name of the tester
        /// </summary>
        public string _FirstName
        {
            get { return ("  " + FirstName); }
            set { FirstName = value; }
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


        DateTime DateOfBirth;
        /// <summary>
        /// get viarable of DateTime to Date Of Birth the tester
        /// </summary>
        public DateTime _DateOfBirth
        {
            get { return DateOfBirth; } 
            set { DateOfBirth = value; }
        }


        Gender gender;
        /// <summary>
        /// gender of the tester
        /// </summary>
        public Gender _gender
        {
            get { return gender; }
            set { gender = value; }
        }


        string PhoneNumber;
        /// <summary>
        /// get/set valid phone number of the tester
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
        /// property to the address of the tester
        /// </summary>
        public string _City
        {
            get { return City; }
            set { City = value; }
        }


        string Street;
        /// <summary>
        /// property to the address of the tester
        /// </summary>
        public string _Street
        {
            get { return Street; }
            set { Street = value; }
        }


        int experience;
        /// <summary>
        /// Years of experience of the tester
        /// </summary>
        public int _experience
        {
            get { return experience; }
            set
            {
                if (value == 0)
                    throw new Exception(" לא ניתן לקבל בוחן ללא ניסיון");
                experience = value;
            }
        }


        int MaxWeeklyTests;
        /// <summary>
        /// Max Weekly Tests of the tester 
        /// </summary>
        public int Max_Weekly_Tests
        {
            get { return MaxWeeklyTests; }
            set
            {
                if (value < 1)
                    throw new Exception(" מצטערים, אנחנו צריכים בוחנים זמינים יותר");
                MaxWeeklyTests = value;
            }
        }

        Car_Type CarType;
        /// <summary>
        /// car type of the tester
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

        bool[,] Schedule=new bool[6,5];
        /// <summary>
        /// Schedule of the tester
        /// </summary>
        public bool[,] _Schedule
        {
            get { return Schedule; }
            set
            {
                //Deep copying of schedule
                for (int i = 0; i < 6; i++)
                    for (int j = 0; j < 5; j++)
                        Schedule[i, j] = value[i, j];
            }
        }


        /// <summary>
        /// return ToString of the Trainee
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str = (IdTester + " :תעודת זהות" + '\n' + FirstName + " :שם פרטי" + '\n' + LastName + " :שם משפחה" + '\n');
            if (gender == Gender.female)
                str += "אישה" + " :מין" + '\n';
            else str += "גבר" + '\n';
            str += DateOfBirth.ToString() + " :תאריך לידה" + '\n' + PhoneNumber + " :מספר טלפון" + '\n' + City + " :עיר" + '\n' + Street + " :רחוב" + '\n';
            if (CarType == Car_Type.Heavy_Truck)
                str += "משאית כבדה" + '\n';
            if (CarType == Car_Type.Medium_truck)
                str += "משאית בינונית" + " :סוג רכב" + '\n';
            if (CarType == Car_Type.private_car)
                str += "מכונית פרטית" + " :סוג רכב" + '\n';
            else str += "רכב דו-גלגלי" + " :סוג רכב" + '\n';
            str += MaxWeeklyTests + " :מספר שעות מקסימלי בשבוע" + '\n';
            str += experience + " :מספר שעות ניסיון" + '\n';

            return str;

        }
    }

}
