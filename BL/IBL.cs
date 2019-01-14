using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    interface IBL
    {
        void AddTester(Tester t);
        void DeleteTester(Tester t);
        void UpdateTester(Tester t);

        void AddTrainee(Trainee t);
        void DeleteTrainee(Trainee t);
        void UpdateTrainee(Trainee t);

        // void AddTest(Test t);
        //void UpdateTest(Test t);

        List<Tester> GetListTesters();
        List<Trainee> GetListTrainees();
        List<Test> GetListTests();
    }
}
