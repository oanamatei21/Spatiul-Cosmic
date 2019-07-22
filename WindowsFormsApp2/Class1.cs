using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Class1
    {
        private static string var1 = "";
        public static string constring
        {
            get { return var1; }
            set { var1 = value; }
        }
        private static string var2 = "";
        public static string nume
        {
            get { return var2; }
            set { var2 = value; }
        }
    }
}
