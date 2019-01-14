using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS;
using BE;
using System.Collections.Specialized;

namespace DAL
{
    public class imp_Dal : IDAL
    {

        /// <summary>
        /// add tester to the testers list
        /// </summary>
        /// <param name="t"></param>
        public void AddTester(Tester t)
        {
            //check if the tester already exist
            for (int i = 0; i < DataSource.Testers.Count; i++)
                if (DataSource.Testers.ElementAt(i)._IdTester == t._IdTester)
                    throw new Exception(" קיים כבר טסטר עם אותו תעודת זהות");

            for (int i = 0; i < DataSource.Trainees.Count; i++)
                if (DataSource.Trainees.ElementAt(i)._IdTrainee == t._IdTester)
                    throw new Exception(" התלמיד לא יכול להיות גם מורה... עם כל הכבוד");


            //case the tester doesnt exist
            DataSource.Testers.Add(t);
        }


        /// <summary>
        /// delete tester from the testers list
        /// </summary>
        /// <param name="t"></param>
        public void DeleteTester(Tester t)
        {
            //check if the tester exist
            int i = 0;
            int j = DataSource.Testers.Count;
            for (; i < j; i++)
                if (DataSource.Testers.ElementAt(i)._IdTester == t._IdTester)
                {
                    DataSource.Testers.RemoveAt(i);
                    break;
                }

            //case the tester doesnt exist
            if (j == DataSource.Testers.Count)
                throw new Exception("הטסטר לא קיים במאגר");
        }


        /// <summary>
        /// update tester
        /// </summary>
        /// <param name="t"></param>
        public void UpdateTester(Tester t)
        {
            //check if the tester exist
            int i = 0;
            for (; i < DataSource.Testers.Count; i++)
                if (DataSource.Testers.ElementAt(i)._IdTester == t._IdTester)
                    DataSource.Testers[i] = t;

            //case the tester doesnt exist
            if (i == DataSource.Testers.Count)
                throw new Exception("הטסטר לא קיים במאגר");
        }






        /// <summary>
        /// Add Trainee to the list
        /// </summary>
        /// <param name="t"></param>
        public void AddTrainee(Trainee t)
        {
            //check if the trainee already exist
            for (int i = 0; i < DataSource.Trainees.Count; i++)
                if (DataSource.Trainees.ElementAt(i)._IdTrainee == t._IdTrainee)
                    throw new Exception(" קיים כבר תלמיד עם אותו תעודת זהות");

            //case the tester doesnt exist
            DataSource.Trainees.Add(t);
        }



        /// <summary>
        /// delete trainee from the list
        /// </summary>
        /// <param name="t"></param>
        public void DeleteTrainee(Trainee t)
        {
            //check if the trainee exist
            int i = 0;
            int j = DataSource.Trainees.Count;

            for (; i < j; i++)
                if (DataSource.Trainees.ElementAt(i)._IdTrainee == t._IdTrainee)
                {
                    DataSource.Trainees.RemoveAt(i);
                    break;
                }

            //case the trainee doesnt exist
            if (j == DataSource.Trainees.Count)
                throw new Exception(" התלמיד לא קיים במאגר");
        }




        /// <summary>
        /// update trainee
        /// </summary>
        /// <param name="t"></param>
        public void UpdateTrainee(Trainee t)
        {
            //check if the tester exist
            int i = 0;
            for (; i < DataSource.Trainees.Count; i++)
                if (DataSource.Trainees.ElementAt(i)._IdTrainee == t._IdTrainee)
                    DataSource.Trainees[i] = t;

            //case the tester doesnt exist
            if (i == DataSource.Trainees.Count)
                throw new Exception("התלמיד לא קיים במאגר");
        }



        /// <summary>
        /// Add test to the test list
        /// </summary>
        /// <param name="t"></param>
        public void AddTest(Test t)
        {
            t._UniqCode = Configuration.counterTest++;
            DataSource.Tests.Add(t);
        }



        /// <summary>
        /// update test
        /// </summary>
        /// <param name="t"></param> 
        public void UpdateTest(Test t)
        {
            int i = 0;
            for (; i < DataSource.Tests.Count; i++)
                if (DataSource.Tests.ElementAt(i)._UniqCode == t._UniqCode)
                    DataSource.Tests[i] = t;
            if (i == DataSource.Tests.Count)
                throw new Exception("הטסט לא קיים במאגר");
        }


        /// <summary>
        /// return list of the testers
        /// </summary>
        /// <returns></returns>
        public List<Tester> GetListTesters()
        {
            List<Tester> temp = new List<Tester>();

            //deep copying
            for (int i = 0; i < DataSource.Testers.Count; i++)
                temp.Add(DataSource.Testers[i]);

            return temp;
        }



        /// <summary>
        /// return list of the Trainees
        /// </summary>
        /// <returns></returns>
        public List<Trainee> GetListTrainees()
        {
            List<Trainee> temp = new List<Trainee>();

            //deep copying
            for (int i = 0; i < DataSource.Trainees.Count; i++)
                temp.Add(DataSource.Trainees[i]);

            return temp;
        }



        /// <summary>
        /// return list of the Tests
        /// </summary>
        public List<Test> GetListTests()
        {
            List<Test> temp = new List<Test>();

            //deep copying
            for (int i = 0; i < DataSource.Tests.Count; i++)
                temp.Add(DataSource.Tests[i]);

            return temp;
        }
    }
}
