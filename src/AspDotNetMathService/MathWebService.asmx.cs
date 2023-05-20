using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AspDotNetMathService
{
    /// <summary>
    /// Summary description for MathWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MathWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public int Add(int a, int b)
        {
            return MathLibrary.MathClass.Add(a, b);
        }

        [WebMethod]
        public int Subtract(int a, int b)
        {
            return MathLibrary.MathClass.Subtract(a, b);
        }

        [WebMethod]
        public int Multiply(int a, int b)
        {
            return MathLibrary.MathClass.Multiply(a, b);
        }

        [WebMethod]
        public double Divide(int a, int b)
        {
            return MathLibrary.MathClass.Divide(a, b);
        }
    }
}
