using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mirta
{
    class calc2:calc
    {
        public string operation_name { get; set; }
        public char opeartionCharacter { get; set; }
        public int number3 { get; set; }
        public string calc(string name)
        {
            operation_name = name;
            return name;
        }
        public string calc(string name,char charact)
        {
            operation_name = name;
            opeartionCharacter = charact;

            return name + " " + charact;

        }

        public override int add(int n1, int n2)
        {
            return n1 + n2 + number3;
        }
        public override int devide(int n1, int n2)
        {
            return n1 / n2 / number3;
        }
        public override int difference(int n1, int n2)
        {
            return n1 - n2 - number3;
        }
        public override int multiply(int n1, int n2)
        {
            return n1 * n2 * number3;
        }

    }
}
