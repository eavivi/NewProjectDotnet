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

        public static List<Tester> Testers = new List<Tester>()
        {
            new Tester(new bool[6,5],"ירושלים","הועד הלאומי",Gear_Type.manual,"123","shlomichi1351@gmail.com",2,new DateTime(1970,8,29),Car_Type.private_car,50,Gender.male,"0524946887","123456789","הרסט","תרצה"),
            new Tester(new bool[6,5],"תל אביב","השלום",Gear_Type.automatic,"321","dab.",2,new DateTime(1978,2,18),Car_Type.Two_wheeled_vehicle,23,Gender.female,"0524567887","987654321","","תרצה")
        };

        public static List<Trainee> Trainees = new List<Trainee>()
        {
            new Trainee("123456789", "123", "חייט", "אלכסנדר", new DateTime(1995, 5, 5), Gender.female, "0509654785", "תל אביב", "רוטשילד", "ידיאל לוק", "דרוס את הדוס!", Gear_Type.automatic, Car_Type.Two_wheeled_vehicle, "shlomichi351@gmail.com"),
            new Trainee("987654321", "321", "דדריו", "אלכסנדרה", new DateTime(2000, 5, 12), Gender.male, "0587654559", "פתח תקווה", "הנרקיס", "דניאל בידרמן", "דדריו אצלנו", Gear_Type.automatic, Car_Type.private_car, "dab13568@hotmail.com")
        };

        public static List<Test> Tests = new List<Test>();


    }
}
