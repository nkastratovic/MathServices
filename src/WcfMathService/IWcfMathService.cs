using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMathService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWcfMathService" in both code and config file together.
    [ServiceContract]
    public interface IWcfMathService
    {
        [OperationContract]
        int Add(int a, int b);

        [OperationContract]
        int Subtract(int a, int b);

        [OperationContract]
        int Multiply(int a, int b);

        [OperationContract]
        double Divide(int a, int b);
    }
}
