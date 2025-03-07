using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DefineXWeek1Homework2
{
    public class CreditCard : ILogger
    {
        public string Pay(string message)
        {
            return message + "paid with credit card";
        }
    }
}
