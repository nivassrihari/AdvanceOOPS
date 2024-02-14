using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class FoodDetails
    {
        //Field
        public static int _foodID=100;

        //Properties
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public double FoodPrice { get; set; }
        public int AvailableQuantity { get; set; }

        public PersonalDetails(string name,string fatherName,Gender gender,string mobile,string email)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            MailID=email;
        }
        
    }
}