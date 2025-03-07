using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DefineXWeek1Homework2
{
    public class PayTypeFactory
    {
        public ILogger GetInstance(string classname)
        {
            var formattedClassName = classname.Replace(" ", ""); // Boşlukları kaldır
            var newClass = Assembly.GetAssembly(typeof(ILogger)).CreateInstance("DefineXWeek1Homework2." + formattedClassName);
            return (ILogger)newClass;
        }

    }
}
