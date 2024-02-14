using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class UserDetails : PersonalDetails, IBalance
    {
        //Field
        private static double _balance;
        public static int _userId = 1000;
        //Properties
        public string UserID { get; set; }
        public int WorkStationNumber { get; set; }
        public double WalletBalance { get { return _balance; } }

        //Constructore

        public UserDetails(string name,string fatherName,Gender gender,string mobile,string email,int workStationNumber)
        :base(name,fatherName,gender,mobile,email)
        {
            _userId++;
            UserID = "SF"+_userId;
            WorkStationNumber=workStationNumber;
        }


        //Methods

        public void WalletRecharge()
        {
            throw new NotImplementedException();
        }

        public void DeductAmount()
        {
            throw new NotImplementedException();
        }

        
    }
}