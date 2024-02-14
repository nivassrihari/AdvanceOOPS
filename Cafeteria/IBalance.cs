using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public interface IBalance
    {

        //properties
        double WalletBalance { get;}
        //Method
        void WalletRecharge();


        void DeductAmount();
    }



}
