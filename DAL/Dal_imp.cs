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
    class Dal_imp: Idal
    {
        #region Singleton

        private static readonly Dal_imp instance = new Dal_imp();

        public event EventHandler<EventArgs> TesterEvent;
        public event EventHandler<EventArgs> TraineeEvent;
        public event EventHandler<EventArgs> TestEvent;

        public void AddTest(Test t)
        {
            throw new NotImplementedException();
        }

        public void AddTester(Tester t)
        {
            throw new NotImplementedException();
        }

        public void AddTrainee(Trainee t)
        {
            throw new NotImplementedException();
        }

        public void DeleteTest(Test t)
        {
            throw new NotImplementedException();
        }

        public void DeleteTester(Tester t)
        {
            throw new NotImplementedException();
        }

        public void DeleteTrainee(Trainee t)
        {
            throw new NotImplementedException();
        }

        public Tester findTester(string teste_id)
        {
            throw new NotImplementedException();
        }

        public Trainee findTrainee(string traineeId)
        {
            throw new NotImplementedException();
        }

        public List<Tester> getAllTesters()
        {
            throw new NotImplementedException();
        }

        public List<Test> getAllTests()
        {
            throw new NotImplementedException();
        }

        public List<Trainee> getAllTrainees()
        {
            throw new NotImplementedException();
        }

        public List<Tester> GetTestersList(Predicate<Tester> p)
        {
            throw new NotImplementedException();
        }

        public List<Test> GetTestList(Func<Test, bool> p)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> traineeGrouping(string property)
        {
            throw new NotImplementedException();
        }

        public void UpdateTest(Test t)
        {
            throw new NotImplementedException();
        }

        public void UpdateTester(Tester t)
        {
            throw new NotImplementedException();
        }

        public void UpdateTester(Tester tester, string id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTrainee(Trainee t)
        {
            throw new NotImplementedException();
        }

        public void UpdateTrainee(Trainee student, string id)
        {
            throw new NotImplementedException();
        }
    }
}
