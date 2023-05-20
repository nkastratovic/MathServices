using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMathService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WcfMathService" in both code and config file together.
    public class WcfMathService : IWcfMathService
    {
        public int Add(int a, int b)
        {
            return MathLibrary.MathClass.Add(a, b);
        }

        public double Divide(int a, int b)
        {
            return MathLibrary.MathClass.Divide(a, b);
        }

        public int Multiply(int a, int b)
        {
            return MathLibrary.MathClass.Multiply(a, b);
        }

        public int Subtract(int a, int b)
        {
            return MathLibrary.MathClass.Subtract(a, b);
        }
    }
}
