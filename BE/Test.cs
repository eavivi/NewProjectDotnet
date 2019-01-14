using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
 public class Test
    {
        /// <summary>
        /// default ctor
        /// </summary>
        public Test() { }

       /// <summary>
       /// ctor
       /// </summary>
       /// <param name="UniqCode_"></param>
       /// <param name="IdTester_"></param>
       /// <param name="IdTrainee_"></param>
       /// <param name="DateTest_"></param>
       /// <param name="AddressTest_"></param>
       /// <param name="Parking_Reverse_"></param>
       /// <param name="Notes_"></param>
       /// <param name="PassedTest_"></param>
       /// <param name="KeepDistance_"></param>
       /// <param name="Signaling_"></param>
       /// <param name="Mirrors_"></param>
        public Test(int UniqCode_,string IdTester_, string IdTrainee_, DateTime DateTest_, Address AddressTest_, bool Parking_Reverse_, string Notes_, bool PassedTest_, bool KeepDistance_, bool Signaling_, bool Mirrors_)
        {
            UniqCode = Configuration.counterTest + 1;
            IdTester = IdTester_;
            IdTrainee = IdTrainee_;
            DateTest = DateTest_;
            AddressTest = AddressTest_;
            Parking_Reverse = Parking_Reverse_;
            Notes = Notes_;
            PassedTest = PassedTest_;
            KeepDistance = KeepDistance_;
            Signaling = Signaling_;
            Mirrors = Mirrors_;
        }



        int UniqCode;
        /// <summary>
        /// uniq code of the test
        /// </summary>
        public int _UniqCode
        {
            get { return UniqCode; }
            set { UniqCode = value; }
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
                if (value.Length != 9)
                    throw new Exception("נא להכניס תעודת זהות בעלת 9 ספרות");
                IdTester = value;
            }
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
                if (value.Length != 9)
                    throw new Exception("נא להכניס תעודת זהות בעלת 9 ספרות");
                IdTrainee = value;
            }
        }

        DateTime DateTest;
        /// <summary>
        /// date and hour of the test
        /// </summary>
        public DateTime _DateTest
        {
            get { return DateTest; }
            set { DateTest = value; }
        }

        Address AddressTest;
        /// <summary>
        /// Address of the test
        /// </summary>
        public Address _Address_Test
        {
            get { return AddressTest; }
            set { AddressTest = value; }
        }


        bool Parking_Reverse;
        /// <summary>
        /// check if the trainee Succeeded the  the test- Parking_Reverse
        /// </summary>
        public bool _Parking_Reverse
        {
            get { return Parking_Reverse; }
            set { Parking_Reverse = value; }
        }


        bool Mirrors;
        /// <summary>
        /// check if the trainee Succeeded the the test- mirrors
        /// </summary>
        public bool _Mirrors
        {
            get { return Mirrors; }
            set { Mirrors = value; }
        }


        bool Signaling;
        /// <summary>
        /// check if the trainee Succeeded the the test- Signaling
        /// </summary>
        public bool _Signaling
        {
            get { return Signaling; }
            set { Signaling = value; }
        }


        bool KeepDistance;
        /// <summary>
        /// check if the trainee Succeeded the the test- Keep Distance
        /// </summary>
        public bool _KeepDistance
        {
            get { return KeepDistance; }
            set { KeepDistance = value; }
        }


        bool PassedTest;
        /// <summary>
        /// check if the trainee Succeeded the the test- Passed the Test
        /// </summary>
        public bool _PassedTest
        {
            get { return PassedTest; }
            set { PassedTest = value; }
        }

        string Notes;
        /// <summary>
        /// Notes of the tester on the test
        /// </summary>
        public string _Notes
        {
            get { return Notes; }
            set { Notes = value; }
        }
    }

}