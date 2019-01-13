using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface Idal

    {
        #region Tester
        void AddTester(Tester t);
        void DeleteTester(Tester t);
        void UpdateTester(Tester t);
        void UpdateTester(Tester tester, string id);
        Tester FindTester(string teste_id);
        List<Tester> GetAllTesters();
        event EventHandler<EventArgs> TesterEvent;
        List<Tester> GetTestersList(Predicate<Tester> p);

        #endregion

        #region Trainee
        void AddTrainee(Trainee t);
        void DeleteTrainee(Trainee t);
        void UpdateTrainee(Trainee t);
        List<Trainee> getAllTrainees();
        Trainee findTrainee(string traineeId);
        void UpdateTrainee(Trainee student, string id);
        event EventHandler<EventArgs> TraineeEvent;
        IEnumerable<object> traineeGrouping(string property);

        #endregion

        #region Test
        void AddTest(Test t);
        void DeleteTest(Test t);
        void UpdateTest(Test t);
        List<Test> getAllTests();
        List<Test> GetTestList(Func<Test, bool> p);
        event EventHandler<EventArgs> TestEvent;
 
        #endregion
    }
}
