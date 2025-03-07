using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineXWeek1Homework2
{
    public class GooglePay : ILogger
    {
        public string Pay(string message)
        {
            return message + "paid with Google Pay";
        }
    }
}
