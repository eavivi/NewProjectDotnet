using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    class imp_BL:IBL
    {
        public imp_Dal myDal = new imp_Dal();

        /// <summary>
        /// add tester to the stock
        /// </summary>
        /// <param name="t"></param>
        public void AddTester(Tester t)
        {
            if (t._DateOfBirth.Year < 40)
                throw new Exception(" :) הגיל קטן מדי... נסה שוב בשנה הבאה ");

            myDal.AddTester(t);
        }

        //public void AddNumTest(Test t)
        //{
        //    List<Tester> testers = myDal.GetListTesters();
        //    List<Trainee> trainees = myDal.GetListTrainees();
        //    Tester tempTester = testers.Find(x => x._IdTester == t._IdTester);
        //    Trainee tempTrainee = trainees.Find(x => x._IdTrainee == t._IdTrainee);
        //    tempTrainee._NumLesson++;
        //    tempTester._weaklyTests++;
        //}

        /// <summary>
        /// delete tester from the stock
        /// </summary>
        /// <param name="t"></param>
        public void DeleteTester(Tester t)
        {
            myDal.DeleteTester(t);
        }



        /// <summary>
        /// update tester 
        /// </summary>
        /// <param name="t"></param>
        public void UpdateTester(Tester t)
        {
            myDal.UpdateTester(t);
        }



        /// <summary>
        /// add trainee to the stock
        /// </summary>
        /// <param name="t"></param>
        public void AddTrainee(Trainee t)
        {
            if (t._DateOfBirth.Year < 18)
                throw new Exception("התלמיד צעיר מדי");

            myDal.AddTrainee(t);
        }


        /// <summary>
        /// delete trainee from the stock
        /// </summary>
        /// <param name="t"></param>
        public void DeleteTrainee(Trainee t)
        {
            myDal.DeleteTrainee(t);
        }


        /// <summary>
        /// update trainee
        /// </summary>
        /// <param name="t"></param>
        public void UpdateTrainee(Trainee t)
        {
            myDal.UpdateTrainee(t);
        }







        ///// <summary>
        ///// add test to the stock
        ///// </summary>
        ///// <param name="t"></param>

        //List<Tester> availableTesters(Test t)
        //{
        //    List<Tester> returnedList = new List<Tester>();
        //    List<Tester> _testers = myDal.GetListTesters();
        //    List<Test> Tests = myDal.GetListTests();
        //    var testers = from item in _testers //build list with all the testers which available in the date

        //                  where (item._Schedule[t._DateTest.Hour - 9, (int)(t._DateTest.DayOfWeek)] && (item.Max_Weekly_Tests >= item._weaklyTests) && (item._CarType == t._CarType))
        //                  select item;

        //    foreach (var item in testers)
        //    {

        //        var tests1 = from item1 in Tests //build list which contains all the testers who also dont do another test at this time
        //                     where item._IdTester == item1._IdTester && t._DateTest != item1._DateTest
        //                     select item;
        //        foreach (var item1 in tests1)
        //        {
        //            returnedList.Add(item1);
        //        }

        //    }
        //    return returnedList;

        //}
        //static public bool condition(Test t)
        //{
        //    if (t._CarType == Car_Type.Heavy_Truck) //any other condition will be fit
        //        return true;
        //    return false;
        //}
        //public delegate bool conditionDelegate(Test t);
        //public List<Test> TestConditioned()
        //{
        //    List<Test> returnedList = new List<Test>();

        //    List<Test> t = myDal.GetListTests();
        //    conditionDelegate cond = condition;
        //    foreach (var item in t)
        //    {
        //        if (cond(item))
        //            returnedList.Add(item);
        //    }
        //    return returnedList;
        //}

        /// <summary>
        /// Grouping testers by experience
        /// </summary>
        /// <returns></returns>
        //public List<Tester> GroupingByExperience()
        //{
        //    var returnedList = new List<Tester>();
        //    List<Tester> t = myDal.GetListTesters();
        //    var experience = (from w in t
        //                     orderby w
        //                     group w by w._CarType).ToList();
        //    returnedList = experience;
        //    foreach (var item in experience)
        //    {
        //        returnedList.Add(item);
        //    }

        //}
        /// <summary>
        /// check if the trainne passed driving test.e
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        //public bool IsPassed(Trainee t)
        //{
        //    List<Test> testList = myDal.GetListTests();
        //    foreach()
        //}


        int NumOfTests(Trainee t)
        {
            int count = 0;
            List<Test> Tests = myDal.GetListTests();
            var tests = from item in Tests
                        where item._IdTrainee == t._IdTrainee
                        select item;
            foreach (var item in tests)
                count++;

            return count;




        }


        List<Test> TestsPerDay(DateTime dt)
        {
            List<Test> returnedList = new List<Test>();

            List<Test> Tests = myDal.GetListTests();
            var tests = from item in Tests
                        where item._DateTest.DayOfWeek == dt.DayOfWeek && item._DateTest.Month == dt.Month
                        select item;
            foreach (var item in tests)
                returnedList.Add(item);

            return returnedList;
        }



        /// <summary>
        /// add tester to the stock
        /// </summary>
        /// <param name="t"></param>



        /// <summary>
        /// delete tester from the stock
        /// </summary>
        /// <param name="t"></param>



        /// <summary>
        /// update tester 
        /// </summary>
        /// <param name="t"></param>


        /// <summary>
        /// add trainee to the stock
        /// </summary>
        /// <param name="t"></param>



        /// <summary>
        /// delete trainee from the stock
        /// </summary>
        /// <param name="t"></param>


        /// <summary>
        /// update trainee
        /// </summary>
        /// <param name="t"></param>




        public int AgeOfTrainee(Test t)
        {
            List<Trainee> Temp = new List<Trainee>();

            var specificTrainee = from item in myDal.GetListTrainees() //בודק שהתלמיד גדול מ17
                                  where item._IdTrainee == t._IdTrainee
                                  select item;
            foreach (var item in specificTrainee)
                Temp.Add(item);
            Trainee tempTrainne = Temp.Last();
            return tempTrainne._DateOfBirth.Year;
        }


        public int AgeOfTester(Test t)
        {
            List<Tester> Temp = new List<Tester>();

            var specificTester = from item in myDal.GetListTesters() //בודק שהבוחן גדול מ39
                                 where item._IdTester == t._IdTester
                                 select item;
            foreach (var item in specificTester)
                Temp.Add(item);
            Tester tempTester = Temp.Last();
            return tempTester._DateOfBirth.Year;
        }


        //public bool IsPassed(Test t)
        //{
        //    List<Test> Tests = myDal.GetListTests();
        //    //IEnumerable<Test> traineeTests = new List<Test>();
        //    var traineeTests = from item in Tests
        //                       where item._IdTrainee == t._IdTrainee
        //                       select item;
        //    //IEnumerable<Test> passedTests = new List<Test>();
        //    var passedTests = from item in traineeTests
        //                      where item._PassedTest
        //                      select item;
        //    bool sameCarType = passedTests.Any(n => n._CarType == t._CarType);
        //    if (sameCarType)
        //        return true;
        //    return false;
        //}


        /// <summary>
        /// add test to the stock
        /// </summary>
        /// <param name="t"></param>
        //public void AddTest(Test t)
        //{

        //    if (AgeOfTrainee(t) < 18)
        //        throw new Exception("התלמיד צעיר מדי");
        //    if (AgeOfTester(t) < 40)
        //        throw new Exception("הבוחן צעיר מדי");




        //    /*Test time between test and test*/

        //    //get the tests list into the Tests
        //    List<Test> Tests = new List<Test>();
        //    Tests = myDal.GetListTests();

        //    //Goes through the whole list of tests and puts all the tests of the specific student into the new list
        //    IEnumerable<Test> traineeTests = new List<Test>();
        //    traineeTests = (from item in Tests
        //                   where item._IdTrainee == t._IdTrainee
        //                   select item).ToList<Test>();

        //    //צריך למיין את הרשימה על פי התאריכים
        //    //the last date test of the trainee
        //    DateTime LastTimeTest = traineeTests.Last<Test>()._DateTest;

        //    //Check if 7 days have elapsed since the last test
        //    DateTime MinDateToTest = t._DateTest.AddDays(7);
        //    if (MinDateToTest < LastTimeTest)
        //        throw new Exception("התלמיד לא יכול לגשת למבחן לפני שעברו 7 ימים מהמבחן האחרון");




        //    /*Check the amount of the lessons of the trainne*/

        //    List<Trainee> trainees = new List<Trainee>();
        //    trainees = myDal.GetListTrainees();

        //    //Finds the student being tested
        //    Trainee TraineeTested = trainees.Find(x => x._IdTrainee.Contains(t._IdTrainee));

        //    //Check if the student has done less than 20 lessons
        //    if (TraineeTested._NumLesson < 20)
        //        throw new Exception("התלמיד עשה פחות מ20 שיעורים");

        //    if (IsPassed(t))                                                    //check if the trainee has already passed a test on the specific car type
        //        throw new Exception("התלמיד עבר כבר טסט על סוג רכב זה ");
        //    //make a list of the testers who haven't passed their maximum weakly tests number.
        //    //IEnumerable<Tester> testers = new List<Tester>();

        //    //List<Tester> testersList = new List<Tester>();
        //    //testersList = myDal.GetListTesters();
        //    //var testers = from item in testersList   //build testers list which contains testers who have less weakly tests than the max, and his car type is matching and his schedule is matching, 
        //    //          where ( item.Max_Weekly_Tests >= item._weaklyTests) && (item._CarType == t._carType) && item._Schedule[t._DateTest.Hour - 9, (int)(t._DateTest.DayOfWeek-1)]
        //    //               select item;
        //    //List<Tester> suggestedTesters= new List<Tester>();
        //    //foreach (var item in testers)
        //    //{
        //    //    suggestedTesters.Add(item);
        //    //}
        //    //int i = 1, j = 1;
        //    //while (suggestedTesters.Count() == 0)
        //    //{
        //    //    //IEnumerable<Tester> suggestedList = new List<Tester>();

        //    //    testers = from item1 in testersList

        //    //              where (item1.Max_Weekly_Tests >= item1._weaklyTests) && (item1._CarType == t._carType) && item1._Schedule[t._DateTest.Hour - 9 + i, (int)(t._DateTest.DayOfWeek - 1) + j] 
        //    //              select item1;
        //    //    foreach (var item1 in testers)
        //    //    {
        //    //        suggestedTesters.Add(item1);
        //    //    }



        //    //    j++;
        //    //    if(j==6)
        //    //    {
        //    //        j = 0;i++;
        //    //    }
        //    //    if(i==5)
        //    //    {
        //    //        i = 0;
        //    //    }
        //    //}
        //    //bool flag = false;
        //    //List<Test> finalList = new List<Test>();
        //    //while (!flag)
        //    //{
        //    //    foreach(var item1 in suggestedTesters)
        //    //    {
        //    //        var tests1 = from item in Tests
        //    //                     where item._IdTester == item1._IdTester && item._DateTest != t._DateTest
        //    //                     select item;
        //    //        foreach(var item2 in tests1)
        //    //        {
        //    //            finalList.Add(item2);
        //    //        }
        //    //        if (finalList.Count != 0)
        //    //        {
        //    //            flag = true;
        //    //            break;
        //    //        }


        //    //    }
        //    //    throw new Exception("no tester is available");

        //    //}

        //    //Tester suggestedTester = finalList.First();

        //    List<Tester> testers1 = availableTesters(t);
        //    bool flag = false;
        //    while (testers1.Count == 0)
        //    {
        //        flag = true;
        //        t._DateTest.AddHours(1);
        //        if (t._DateTest.Hour == 15)
        //        {
        //            t._DateTest.AddDays(1);
        //            t._DateTest.AddHours(-9);
        //        }
        //        if (t._DateTest.DayOfWeek == DayOfWeek.Friday)
        //            throw new Exception("אין תאריך זמין כלל"); // ONLY In the perspective of a week!

        //        testers1 = availableTesters(t);
        //    }
        //    string message = (t._DateTest.Hour) + "בשעה" + (t._DateTest.DayOfWeek) + "האם אתה מעוניין בתאריך הבא: ביום";
        //    if (flag) throw new Exception(message);
        //    myDal.AddTest(t);
        //}







        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        void UpdateTest(Test t)
        {

        }











        /// <summary>
        /// return all tests of the trainee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Test> TraineeTestList(string id)
        {
            List<Test> traineeTests = new List<Test>();
            var reasult = from item in myDal.GetListTests()
                          where item._IdTrainee == id
                          select item;

            foreach (var item in reasult)
                traineeTests.Add(item as Test);

            return traineeTests;
        }



        /// <summary>
        /// return all tests of the tester
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Test> TesterTestList(string id)
        {
            List<Test> testerTests = new List<Test>();
            var reasult = from item in myDal.GetListTests()
                          where item._IdTester == id
                          select item;

            foreach (var item in reasult)
                testerTests.Add(item as Test);

            return testerTests;
        }


        /// <summary>
        /// check if the trianee exist in the list
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckTraineeExist(string id)
        {
            foreach (Trainee value in myDal.GetListTrainees())
                if (value._IdTrainee == id)
                    return true;
            return false;
        }


        /// <summary>
        /// return trainee by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Trainee TraineeById(string id)
        {
            foreach (Trainee value in myDal.GetListTrainees())
                if (value._IdTrainee == id)
                    return value;

            throw new Exception("תעודת הזהות לא נמצאת במאגר");
        }


        /// <summary>
        /// return tester by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Tester TesterById(string id)
        {
            foreach (Tester value in myDal.GetListTesters())
                if (value._IdTester == id)
                    return value;

            throw new Exception("תעודת הזהות לא נמצאת במאגר");
        }

        /// <summary>
        ///  check if the tester exist in the list
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckTesterExist(string id)
        {
            foreach (Tester value in myDal.GetListTesters())
                if (value._IdTester == id)
                    return true;
            return false;
        }



        /// <summary>
        ///  check if the test exist in the list
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckTestExist(int id)
        {
            foreach (Test value in myDal.GetListTests())
                if (value._UniqCode == id)
                    return true;
            return false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>



        /// <summary>
        /// return the Testers list
        /// </summary>
        /// <returns></returns>
        public List<Tester> GetListTesters()
        {
            return myDal.GetListTesters();
        }


        /// <summary>
        /// return Trainees list
        /// </summary>
        /// <returns></returns>
        public List<Trainee> GetListTrainees()
        {
            return myDal.GetListTrainees();
        }


        /// <summary>
        /// return tests list
        /// </summary>
        /// <returns></returns>
        public List<Test> GetListTests()
        {
            return myDal.GetListTests();
        }
    }
}

