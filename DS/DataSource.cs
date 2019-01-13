using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DS
{
    public class DataSource

    {
        public static List<Tester> testers;
        public static List<Trainee> trainees;
        public static List<Test> tests;


        static DataSource()

        {

            testers = new List<Tester>();
            trainees = new List<Trainee>();
            tests = new List<Test>();
            Test test = new Test("12345666", "12345670", new DateTime(2019, 2, 3), new Address("hacotel", 5, "jerusalem"), Gear_type.manual, Vehicle.private_car);
            Test test2 = new Test("00005666", "12345670", new DateTime(2019, 2, 3), new Address("hacotel", 5, "jerusalem"), Gear_type.manual, Vehicle.private_car);
            test.Is_pass = true;
            test2.Is_pass = true;
            test.Note = "this is an exemple, the code is in DS";
            tests.Add(test);
            tests.Add(test2);
            var x = (Test)(test.Clone());
            x.Is_pass = false;
            tests.Add(x);
            tests.Add((Test)(test2.Clone()));
            tests.Add(x);
            tests.Add((Test)(test2.Clone()));
            tests.Add(x);
            tests.Add((Test)(test2.Clone()));

        }
    }
}