using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum Car_Type { Medium_truck, Heavy_Truck, private_car, Two_wheeled_vehicle };
    public enum Gear_Type { manual, automatic };
    public enum Gender { male, female };

    public struct Address
    {
        string street;
        string city;
        int num_Building;

        public override string ToString()
        {

            return (street + " :רחוב" + '\n' + city + " :עיר" + '\n' + num_Building + " :מספר בניין" + '\n');
        }
    }


}


