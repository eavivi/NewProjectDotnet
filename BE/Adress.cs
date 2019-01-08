using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Data;
namespace BE
{
   public  struct Address

    {
      public  string street;
      public  int houseNumber;
      public  string city;
    
    public Address(string street, int houseNumber, string city)

    {
        this.street = street;
        this.houseNumber = houseNumber;
        this.city = city;
    }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)

        {

            if (values != null)
            {
                var houseNumber = values[0];
                var street = values[1];
                var city = values[2];
                string a = "";
                a += houseNumber + " " + street + " " + city;
                return a;
            }
            else
                return "";
        }



        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)

        {
            throw new NotImplementedException();
        }

        public override string ToString()

        {

            return "Address is:" + street + " " + houseNumber + " " + city;

        }

    }
}
