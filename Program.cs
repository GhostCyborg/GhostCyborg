using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
namespace mirta
{
    class Program
    {
        public static long Digpow(int n, int p)
        {
            int len1 = n.ToString().Length;
            double res = 0; int k = -1, c = n;
            int[] arr = new int[len1];
            for (int i = 0; i < len1; i++)
            {
                if (n > 0)
                {
                    arr[i] = n % 10;
                    n = n / 10;
                }

            }
            for (int j = len1 - 1; j >= 0; j--)
            {
                res += Math.Pow(Convert.ToDouble(arr[j]), Convert.ToDouble(p));
                p++;

            }
            if (Convert.ToDouble(res / c) - Convert.ToInt32(res / c) == 0)
            {
                k = Convert.ToInt32(res / c);
            }

            return k;
        }
        public static long Nextnumsquare(long m)
        {
            double n = -1; double test;
            test = Math.Pow(m, 0.5);
            if (test - (int)test == 0)
            {
                n = Math.Pow(test + 1, 2);
            }
            return (long)n;
        }
        public static string Firstnonerepating(string s)
        {
            string b = ""; int index;
            string low = s.ToLower();
            for (int i = 0; i < low.Length; i++)
            {
                int repeat = 0;
                b = low[i].ToString();
                for (int j = 0; j < low.Length; j++)
                {
                    if (b == low[j].ToString())
                    {
                        repeat++;

                    }
                }
                if (repeat == 1)
                {
                    index = i;
                    b = s[i].ToString();
                    break;
                }
                else
                {
                    b = "";
                }

            }


            return b;
        }
        public static string Getreadabletime(int seconds)
        {
            string time = "00:00:00";
            int timesec1 = 0, timesec2 = 0;
            int timemin1 = 0, timemin2 = 0;
            int timehour1 = 0, timehour2 = 0;
            for (int i = 0; i < seconds; i++)
            {
                timesec2++;

                if (timesec2 == 10)
                {
                    timesec2 = 0;
                    timesec1++;
                    if (timesec1 == 6)
                    {
                        timesec1 = 0;
                        timemin2++;
                        if (timemin2 == 10)
                        {

                            timemin2 = 0;
                            timemin1++;
                            if (timemin1 == 6)
                            {
                                timemin1 = 0;
                                timehour2++;

                                if (timehour2 == 10)
                                {
                                    timehour2 = 0;
                                    timehour1++;
                                    if (timehour1 == 10)
                                    {
                                        break;
                                    }

                                }
                            }
                        }
                    }
                }
                if (seconds == 0)
                {
                    break;
                }
            }
            time = timehour1.ToString() + timehour2.ToString() + ":" + timemin1.ToString() +
                timemin2.ToString() + ":" + timesec1.ToString() + timesec2.ToString();
            return time;
        }
        public static bool Polindrome(object line)
        {
            bool stat = false; string line2 = "";
            ArrayList list = new ArrayList();
            foreach (var item in line.ToString())
            {
                list.Add(item);
            }
            list.Reverse();
            foreach (var item in list)
            {
                line2 += item.ToString();
            }
            if (line2 == line.ToString())
            {
                stat = true;
            }

            return stat;
        }
        public static string Johnsnowparents(string dad, string mom)
        {
            return dad == "Rhaegar Targeryan" && mom == "Lenny Stark" ? "Jon Snow you deserve the throne" : "You know nothing, Jon Snow";
        }
        public static string Calcfizzbuzz(int n)
        {
            string res;
            if (n == 0)
                res = String.Empty;
            else if (n == 3)
                res = "Fizz";
            else if (n == 5)
                res = "Buzz";
            else res = n.ToString();
            return res;
        }

        public static string Camelcase(string str)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '-' && str[i] != '_')
                {
                    list.Add(str[i].ToString());
                }
            }
            str = "";
            foreach (var item in list)
            {
                str += item;
            }
            return str;

        }

        public static int Different(params int[] integers)
        {
            int res = -1, t = 0, c = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 0)
                    c++;
                else
                    t++;

                if (t != 1 && c != 1 && (t > c || c > t))
                {
                    res = integers[i];
                    break;
                }
            }
            return res;
        }

        public static string PigItAy(string str)
        {
            string[] arr = str.Split(' ');
            ArrayList listay = new ArrayList();
            str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                string str2 = arr[i]; int len = arr[i].Length;
                foreach (var item in arr[i])
                {
                    listay.Add(item);
                }
                arr[i] = "";
                listay.RemoveAt(0);
                listay.Add(str2[0]);
                foreach (var item in listay)
                {
                    arr[i] += item.ToString();
                }
                listay.RemoveRange(0, len);
                if (i == arr.Length - 1)
                {
                    str += arr[i] + "ay";
                    break;
                }
                str += arr[i] + "ay" + " ";

            }

            return str;
        }

        public static long Total(long n)
        {
            long res = 0;

            for (int i = 1; i <= n; i++)
            {
                res += i;
            }

            return res;
        }

        public static long Divisiblecount(long x, long y, long k)
        {
            long res = 0;
            if (x <= y)
            {
                for (long i = x; i < y; i++)
                {
                    if (i % k == 0)
                    {
                        res++;
                    }
                }
            }
            return res;
        }

        public static string Highandlow(string numbers)
        {

            string[] arr = numbers.Split(' ');
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = Convert.ToInt32(arr[i]);
                
            }
            return arr2.Max().ToString()+" "+arr2.Min().ToString();
        }

        public static string Duplicate(string s)
        {
            int l = 0;
            s =s.ToLower();
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                string temp = s[i].ToString();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        l++;
                    }
                    if (l > 1 && j == s.Length - 1)
                    {
                        temp = ")";
                    }
                    else
                    {
                        temp = "(";
                    }

                }
                l = 0;
                res += temp;
                temp = "";

            }


            return res;
        }

        public static bool Squared(int n)
        {
            bool status = false;
            for (int i = 0; i < n; i++)
            {
                if (Math.Pow(i, 2) == n)
                {
                    status = true;
                    break;
                }
            }

            return n < 0 ? false : status;
        }

        public static bool Logicalcalc(bool[] array ,string op)
        {
            bool res = false;
            if (op == "AND")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array.Length == 1)
                    {
                        res = array[0];
                        break;
                    }
                    bool temp = array[i + 1];
                    if (array[i]==temp)
                    {
                        res = true;
                    }
                    else
                    {
                        res = false;
                    }
                    if (i==array.Length-2)
                    {
                        break;
                    }
                }
                
            }
            else if (op == "OR")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (res!=array[i])
                    {
                        res = true;
                    }
                }
                if (array.Length==1)
                {
                    res = array[0];
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (res==array[i])
                    {
                        res = false;
                    }
                    else
                    {
                        res = true;
                    }
                    if (array.Length==1)
                    {
                        res = array[0];
                    }

                }
            }
            return res;
        }

        public static int[] delete_arr_element(ref int[] arr,int i)
        {

            return arr.Where((source, index) => index != i).ToArray();
        }

        public static string Doublechar(string s)
        {
            string res = "";
            foreach (var item in s)
            {
                res += item.ToString() + item.ToString();
            }

            return res;
        }

        public static bool IsMerge(string s, string part1, string part2)
        {
            ArrayList list=new ArrayList();
            bool st = false;
            foreach (char item in s)
            {
                list.Add(item);
            }
            foreach (char item1 in list)
            {
                foreach (char item2 in part1)

                {
                    if (item1==item2)
                    {

                        list.Remove(item1);
                        st = true;
                        goto Label;
                    }
                    else
                    {
                        st = false;
                        break;
                        
                    }
                }
                foreach (var item3 in part2)
                {
                    if (item3==item1)
                    {
                        list.Remove(item1);
                        st = true;
                        goto Label;
                    }
                    else
                    {
                        st = false;
                        break;
                    }
                }
                Label:
                st = true;


            }
            return st;
        }

        

        public static List<int> Pascaltrangle(int n)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j==0&&j==i)
                    {
                        list.Add(1);
                    }
                    else
                    {
                        list.Add(i);
                    }
                    
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                   
                }
            }
            return new List<int>();
            
        }

        public static string Summastringasnumbers(string a, string b)
        {
            ulong num1, num2;
            if (a.Length > 19 && b.Length > 19 && a.Length!=b.Length)
            {
                ulong num3, num4;
                string[] arr1 = new string[2];
                string[] arr2 = new string[2];
                for (int j = 0; j < a.Length - b.Length; j++)
                {
                    arr2[0] += 0;
                }
                arr1[0] = "";
                foreach (var item in a)
                {
                    if (arr1[0].Length <= 15)
                    {
                        arr1[0] += item.ToString();
                    }
                    else
                    {
                        arr1[1] += item.ToString();
                    }

                }
                foreach (var item in b)
                {
                    if (arr2[0].Length <= 15)
                    {
                        arr2[0] += item.ToString();
                    }
                    else
                    {
                        arr2[1] += item.ToString();
                    }

                }
                bool res1 = ulong.TryParse(arr1[0], out num1);
                bool res2 = ulong.TryParse(arr2[0], out num2);
                bool res3 = ulong.TryParse(arr1[1], out num3);
                bool res4 = ulong.TryParse(arr2[1], out num4);
                if (res1 || res2 || res3 || res4)
                {
                    return (num1 + num2).ToString() + (num3 + num4).ToString();
                }
            }
            else if (a.Length > 19 && b.Length>19)
            {
                int i = 0;
                ulong num3, num4;
                string[] arr1 = new string[2];
                string[] arr2 = new string[2];
                foreach (var item in a)
                {
                    i++;
                    if (i <= 17)
                    {
                        arr1[0] += item.ToString();
                    }
                    else
                    {
                        arr1[1] += item.ToString();
                    }

                }
                i = 0;
                foreach (var item in b)
                {
                    i++;
                    if (i <= 17)
                    {
                        arr2[0] += item.ToString();
                    }
                    else
                    {
                        arr2[1] += item.ToString();
                    }

                }
                bool res1 = ulong.TryParse(arr1[0], out num1);
                bool res2 = ulong.TryParse(arr2[0], out num2);
                bool res3 = ulong.TryParse(arr1[1], out num3);
                bool res4 = ulong.TryParse(arr2[1], out num4);
                if (res1 || res2 || res3 || res4)
                {
                    return (num1 + num2).ToString() + (num3 + num4).ToString();
                }
            }
            else  if (a.Length>19)
            {
                int i = 0;

                string[] arr = new string[2];
                foreach (var item in a)
                {
                    i++;
                    if (i<=15)
                    {
                        arr[0] += item.ToString();
                    }
                    else
                    {
                        arr[1] += item.ToString();
                    }

                }
                bool res1 = ulong.TryParse(arr[1], out num1);
                bool res2 = ulong.TryParse(b, out num2);
                if (res1||res2)
                {
                    return arr[0] + (num1 + num2).ToString();
                }
            }
            else  if (b.Length > 19)
            {
                int i = 0;

                string[] arr = new string[2];
                foreach (var item in b)
                {
                    i++;
                    if (i <= 15)
                    {
                        arr[0] += item.ToString();
                    }
                    else
                    {
                        arr[1] += item.ToString();
                    }

                }
                bool res1 = ulong.TryParse(arr[1], out num1);
                bool res2 = ulong.TryParse(a, out num2);
                if (res1 || res2)
                {
                    return arr[0] + (num1 + num2).ToString();
                }
            }
            else
            {
                bool res1 = ulong.TryParse(a, out num1);
                bool res2 = ulong.TryParse(b, out num2);
                if (res1||res2)
                {
                    return (num1 + num2).ToString();
                }
            }

            return "";
        }

        public static string Combinepath(params string[] pathParts)
        {
            string res = "";
            
            for (int i = 0; i < pathParts.Length; i++)
            {
                pathParts[i] = pathParts[i].Replace("'\'", "").Replace(" ","");
                string s = pathParts[i];
                if (s[0]=='/')
                {
                   s= s.Remove(0);
                }
                if (s[s.Length-1]=='/')
                {
                    s.Remove(s.Length - 1);
                }
                res +="/"+ pathParts[i];
            }
            //string[] str = res.Split(' ');
            //res = "";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    res += "/"+str[i];
            //}
            return res;
        }

        public static int Reversenum(int num)
        {
            ArrayList listnum = new ArrayList();
            string num1 = num.ToString();
            if (num<0)
            {
                for (int i = 1; i < num1.Length; i++)
                {
                    listnum.Add((-num) % 10);
                    num /= 10;
                }
                num1 = "-";
            }
            else
            {
                for (int i = 0; i < num1.Length; i++)
                {
                    listnum.Add(num % 10);
                    num /= 10;
                }
                num1 = "";
            }
            foreach (var item in listnum)
            {
                num1 += item;

            }

            num = Convert.ToInt32(num1);
            return num;
        }            

        public static string Vowel2Index(string str)
        {
            
            int index;
            string res = "";
            char[] vowel = { 'a', 'e', 'i', 'o', 'u','A','E','I','O','U' };
            for (int i = 0; i < str.Length; i++)
            {
                string b = str[i].ToString();
                for (int j = 0; j < vowel.Length; j++)
                {
                    if (b==vowel[j].ToString())
                    {
                        index = i;
                        index++;
                        b = index.ToString();
                    }
                    
                }
                res += b;
            }

                return res;
        }

        public static string Pattern(int n)
        {
            string res = "";
            for (int i = 1; i < n+1; i++)
            {
                for (int j = 1; j < n+1; j++)
                {
                    res += i;
                    if (j==n)
                    {
                        res += "\n";
                    }
                }
            }


            return res;
        }
       
        public static long Cube(long m)
        {
            // verilen long ededin 1den bashlayaraq her hansisa edede qeder kub cemi olub olmamasinin testi
            long t = 0, f = -1;
            for (long n = 0; t < m; n++)
            {
                t += n * n * n;
                if (t==m)
                {
                    f = n;
                    break;
                }
            }
            return f;
        }

        public static string Tickets(params int[] m)
        {
            string res = "No";
            int test = 0,t=0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                test = m[i];
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    if (test==m[j])
                    {
                        t++;

                    }
                    if (t != 0)
                    {
                        res = "YES";
                    }


                }
            }
           

            return res;
        }

        public static bool Status(int[] a,int[] b)
        {
            bool st = false;
            int i = 0,j;
            while(i<a.Length)
            {
                
                int num1 = a[i];
                for (j = 0; j < b.Length; j++)
                {
                    if (b[j]==num1*num1)
                    {
                        b = b.Where((source, index) => index != j).ToArray();
                        st = true;
                        break;
                    }
                    else
                    {
                        st = false;
                    }
                    if (num1==0 && b[j]==0)
                    {
                        st = false;
                    }
                }
                if (st==false)
                {
                    break;
                }
                i++;
            }



            return st;
        }

        public static int MxdiffLength(string[]a ,string[] b)
        {
            int max = 0;
            string strA = "", strB = "";
            for (int i = 0; i < a.Length; i++)
            {
                strA = a[i];
                for (int j = 0; j < b.Length; j++)
                {
                    strB = b[j];
                    if (Math.Abs(strA.Length-strB.Length)>max)
                    {
                        max = Math.Abs(strA.Length - strB.Length);
                    }

                }
            }


            return max;
        }

        public static bool Stat(int a, int b, int c)
        {
            bool st = false;
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c || a + c > b || b + c > a)
                {

                    st = true;
                }

            }


            return st;
        }

        public static void Test2()
        {
            string[] a = { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
           //onsole.WriteLine(whoisnext(a, 5));

        }
    }
    class A
    {
        public int I = 0;
    }
    class B : A
    {
        new int _i;
        public B(int a,int b)
        {
            base.I = a;
            _i = b;
        }
        public void Show()
        {
            Console.WriteLine("base i in class is i in A class:" + base.I);
            Console.WriteLine("i in derived class:" + _i);
        }

    }
    class UnCoverName
    {
        //static void Main(string[] args)
        //{
        //    B ob = new B(4, 6);
        //    ob.Show();
        //    Console.ReadKey();
        //}
    }
    class TwoDShape
    {
        private double _priWidth;
        double _priHeight;

        public double Width
        {
            get { return _priWidth; }
            set { _priWidth = value < 0 ? -value : value; }
        }
        public double Height
        {
            get { return _priHeight; }
            set { _priHeight = value < 0 ? -value : value; }
        }
        //Default Constructor
        public TwoDShape()
        {
            Width = Height = 0.0;
        }
        //Constructor for TwoDShape
        public TwoDShape(double w,double h)
        {
            Width = w;
            Height = h;
        }
        //Constructor object with equal width and height
        public TwoDShape(double x)
        {
            Width = Height = x;
        }
        public void Show()
        {
            Console.WriteLine("Width and Height are " + Width + " and " + Height);
        }
    }
    class Triangle:TwoDShape
    {
        string _style;//private
       //default constructor
       public Triangle()
        {
            _style = "null";
        }
        //Constructor for Triangle
        public Triangle(string s,double w,double h)
        {
            base.Width = w;
            base.Height = h;
            _style = s;
        }
        //Constructor object for style when with equal height and width 
        public Triangle(double x)
        {
            base.Height = base.Width = x;
            _style = "isosceles";
        }
        //Area of triangle
        public double Area()
        {
            return Width * Height / 2;
        }
        //Display triangle's style
        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + _style);
        }
    }
    class ColorTriangle : Triangle
    {
        string _color;
        public ColorTriangle(string c,string style,double w,double h)
        {
            _color = c;
        }
        //Display the color
        public void ShowColor()
        {
            Console.WriteLine("Color is " + _color);
        }
    }
   
}

