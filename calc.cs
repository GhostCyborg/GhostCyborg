using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mirta
{
    class calc
    {
        public static int number1 { get; set; }
        public static int number2 { get; set; }
        public virtual int add(int n1,int n2)
        {
            number1 = n1;
            number2 = n2;
            return n1 + n2;
        }
        public virtual int difference(int n1,int n2)
        {
            number1 = n1;
            number2 = n2;
            return n1 - n2;
        }
        public virtual int devide(int n1, int n2)
        {
            number1 = n1;
            number2 = n2;
            return n1 / n2;
        }
        public virtual int multiply(int n1, int n2)
        {
            number1 = n1;
            number2 = n2;
            return n1 * n2;
        }
        
    }
}
