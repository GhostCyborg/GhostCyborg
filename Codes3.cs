using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Collections;

namespace mirta
{
    class Codes3
    {
        static void Main(string[] args)
        {

           string res= MorseCodeConvert("···−−−··· ! .... . -.--   .--- ..- -.. .");
           
            Console.Write(res);
            Console.ReadKey();
        }
        public static string MorseCodeConvert(string MorseCode)
        {
            MorseCode = MorseCode.TrimStart();
            MorseCode = MorseCode.TrimEnd();
            MorseCode= MorseCode.Replace("", "SOS");
            string res = "";

            var MorseAndAlph = new List<MorseAndAlphabet>

            {
                new MorseAndAlphabet

                {

                    MorseName="...---...",

                    Alphabet="SOS"

                },
                new MorseAndAlphabet

                {

                    MorseName=".-.-.-",

                    Alphabet="."

                },
                new MorseAndAlphabet

                {

                    MorseName="-.-.--",

                    Alphabet="!"

                },
                new MorseAndAlphabet

                {

                    MorseName=".-",

                    Alphabet="A"

                },

            new MorseAndAlphabet

                {

                    MorseName="-...",

                    Alphabet="B"

                },

            new MorseAndAlphabet

                {

                    MorseName="-.-.",

                    Alphabet="C"

                },

            new MorseAndAlphabet

                {

                    MorseName="-..",

                    Alphabet="D"

                },

            new MorseAndAlphabet

                {

                    MorseName=".",

                    Alphabet="E"

                },

            new MorseAndAlphabet

                {

                    MorseName="..-.",

                    Alphabet="F"

                },

            new MorseAndAlphabet

                {

                    MorseName="--.",

                    Alphabet="G"

                },

            new MorseAndAlphabet

                {

                    MorseName="....",

                    Alphabet="H"

                },

            new MorseAndAlphabet

                {

                    MorseName="..",

                    Alphabet="I"

                },

            new MorseAndAlphabet

                {

                    MorseName=".---",

                    Alphabet="J"

                },new MorseAndAlphabet

                {

                    MorseName="-.-",

                    Alphabet="K"

                },new MorseAndAlphabet

                {

                    MorseName=".-..",

                    Alphabet="L"

                },

            new MorseAndAlphabet

                {

                    MorseName="--",

                    Alphabet="M"

                },

            new MorseAndAlphabet

                {

                    MorseName="-.",

                    Alphabet="N"

                },

            new MorseAndAlphabet

                {

                    MorseName="---",

                    Alphabet="O"

                },

            new MorseAndAlphabet

                {

                    MorseName=".--.",

                    Alphabet="P"

                },

            new MorseAndAlphabet

                {

                    MorseName="--.-",

                    Alphabet="Q"

                },

            new MorseAndAlphabet

                {

                    MorseName=".-.",

                    Alphabet="R"

                },

            new MorseAndAlphabet

                {

                    MorseName="...",

                    Alphabet="S"

                },

            new MorseAndAlphabet

                {

                    MorseName="-",

                    Alphabet="T"

                },

            new MorseAndAlphabet

                {

                    MorseName="..-",

                    Alphabet="U"

                },

            new MorseAndAlphabet

                {

                    MorseName="...-",

                    Alphabet="V"

                },

            new MorseAndAlphabet

                {

                    MorseName=".--",

                    Alphabet="W"

                },

            new MorseAndAlphabet

                {

                    MorseName="-..-",

                    Alphabet="X"

                },

            new MorseAndAlphabet

                {

                    MorseName="-.--",

                    Alphabet="Y"

                },

            new MorseAndAlphabet

                {
      
                    MorseName="--..",

                    Alphabet="Z"

                },
            new MorseAndAlphabet
            {
                MorseName="-----",
                Alphabet="0"
            },
            new MorseAndAlphabet
            {
                MorseName=".----",
                Alphabet="1"
            },
            new MorseAndAlphabet
            {
                MorseName="..---",
                Alphabet="2"
            },
            new MorseAndAlphabet
            {
                MorseName="...--",
                Alphabet="3"
            },
            new MorseAndAlphabet
            {
                MorseName="....-",
                Alphabet="4"
            },
             new MorseAndAlphabet
            {
                MorseName=".....",
                Alphabet="5"
            },
            new MorseAndAlphabet
            {
                MorseName="----.",
                Alphabet="6"
            }
            ,new MorseAndAlphabet
            {
                MorseName="--...",
                Alphabet="7"
            },
            new MorseAndAlphabet
            {
                MorseName="---..",
                Alphabet="8"
            },
            new MorseAndAlphabet
            {
                MorseName="----.",
                Alphabet="9"
            }

            };



            List<String> LMorseCode = new List<string>();

            MorseCode = MorseCode.Replace("   ", ",");
            
            LMorseCode.AddRange(MorseCode.Split(','));
            if (LMorseCode != null)
            {
                for (int i = 0; i < LMorseCode.Count; i++)
                {
                    List<string> strMorses = new List<string>();
                    strMorses.AddRange(LMorseCode[i].ToString().Split(' '));
                    for (int j = 0; j < strMorses.Count; j++)
                    {
                        if (MorseAndAlph.Find(x => x.MorseName.Equals(strMorses[j])) != null)
                            res += MorseAndAlph.Find(x => x.MorseName.Equals(strMorses[j])).Alphabet.ToString();
                        else res += strMorses[j].ToString();
                    }
                    if (i != LMorseCode.Count - 1)
                        res += " ";

                }
            }
            return res;


        }

        class MorseAndAlphabet

        {

            public string MorseName { get; set; }

            public string Alphabet { get; set; }

        }

        public static void stack()
        {
            Stack yigin = new Stack(1);
            yigin.Push("dasdasd");
            yigin.Push(4);

        }

        public static long NextBiggerNumber(long n)
        {
            long res = 0, sayg = 0;
            List<string> arr = new List<string>();
            foreach (char item in n.ToString())
            {
                arr.Add(item.ToString());
            }
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (Convert.ToInt64(arr[i]) > Convert.ToInt64(arr[j]))
                    {
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        for (int l = arr.Count - 1; l > j; l--)
                        {
                            for (int s = j + 1; s < l; s++)
                            {
                                if (Convert.ToInt64(arr[l]) < Convert.ToInt64(arr[s]))
                                {
                                    string temp2 = arr[l];
                                    arr[l] = arr[s];
                                    arr[s] = temp2;
                                }
                            }
                        }
                        string tempstr = "";
                        for (int p = 0; p < arr.Count; p++)
                        {
                            tempstr += arr[p];
                        }
                        if (tempstr!="")
                        {
                            long tempnum = Convert.ToInt64(tempstr);
                            if (tempnum > n && sayg == 0)
                            {
                                sayg++;
                                res = tempnum;
                            }
                            else if (tempnum > n && res > tempnum)
                            {
                                res = tempnum;
                            }
                        }
                        

                    }
                    arr.Clear();
                    foreach (char item in n.ToString())
                    {
                        arr.Add(item.ToString());
                    }

                }
            }
            return res == 0 ? -1 : res;
        }


        public static int binaryconvert(string num1, string num2)
        {
            int numb1 = 0, numb2 = 0;
            int len = num1.Length - 1;
            int len2 = num2.Length - 1;
            foreach (char item in num1)
            {
                if (item == '0')
                {
                    len--;
                    continue;
                }
                numb1 += (int)Math.Pow(2, len);
                len--;
            }
            foreach (var item in num2)
            {
                if (item == '0')
                {
                    len2--;
                    continue;
                }
                numb2 += (int)Math.Pow(2, len2);
                len2--;
            }
            return numb1 + numb2;
        }


        static public int[] deletenthelem(int[] arr, int x)
        {
            //int h = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            h++;
            //            if (h == x)
            //            {
            //                arr = arr.Where((source, index) => index != j).ToArray();
            //                return arr;
            //            }
            //        }
            //    }
            //    h = 0;
            //}
            arr = arr.Where((source, index) => index != x).ToArray();

            return arr;
        }

        static public string summastringasnumbers(string a, string b)
        {
            //Cox cox uzun reqemleri toplayir , hetta o qeder uzun ki kalkulyatora sigmayacaq reqemleri misalcun 
            //3
            ulong num1, num2;
            if (a.Length > 19 && b.Length > 19 && a.Length != b.Length)
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
            else if (a.Length > 19 && b.Length > 19)
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
            else if (a.Length > 19)
            {
                int i = 0;

                string[] arr = new string[2];
                foreach (var item in a)
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
                bool res2 = ulong.TryParse(b, out num2);
                if (res1 || res2)
                {
                    return arr[0] + (num1 + num2).ToString();
                }
            }
            else if (b.Length > 19)
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
                if (res1 || res2)
                {
                    return (num1 + num2).ToString();
                }
            }

            return "";
        }
        static public int reversenum(int num)
        {
            ArrayList listnum = new ArrayList();
            string num1 = num.ToString();
            if (num < 0)
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

        static public long cube(long m)
        {
            // verilen long ededin 1den bashlayaraq her hansisa edede qeder kub cemi olub olmamasinin testi
            long t = 0, f = -1;
            for (long n = 0; t < m; n++)
            {
                t += n * n * n;
                if (t == m)
                {
                    f = n;
                    break;
                }
            }
            return f;
        }

        public static double[] Averages(int[] numbers)
        {
            double[] res = new double[numbers.Length - 1];
            for(int i = 0; i < numbers.Length - 1;i++)
            {
                res[i] = numbers[i] + numbers[i + 1];
            }


            return res;
        }

        public static string Adlar(string[] names)
        {

            Random rnd = new Random();
            int say = 2;
            int[] indexler = new int[say];
            indexler[0] = 7; indexler[1] = 7;
            for (int i = 0; i < indexler.Length; i++)
            {
                int index = rnd.Next(0, 6);
                if (!indexler.Contains(index))
                {
                    indexler[i] = index;
                }
                else
                {
                    i--;
                }
            }
            string res = "";
            for (int i = 0; i < indexler.Length; i++)
            {
                res += names[indexler[i]] +" ";
                
            }
            return res;

        }

        public static string ToCamelCase(string str)
        {
            bool st = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (st == true)
                {
                    str = str.Replace(str[i].ToString()+str[i+1], str[i].ToString().ToUpper()+str[i+1]);
                }
                if (!((str[i] > 64 && str[i] < 91)||(str[i]>96 && str[i] < 123)))
                {
                    str = str.Substring(0, i) + str.Substring(i+1, str.Length - i-1);
                    i--;
                    st = true;
                }
                else
                {
                   st= false;
                }
            }


            return str;

        }


        public static int calcccc(long a)
        {
            int res = 0;
            for (int i = 2; i <= a/2; i++)
            {
                if (a%i==0)
                {
                    res = i;
                    break;
                }
             
            }
            return res;
        }

        public static long[] GapPrime(int g, long m, int n)
        {
            List<long> listPrime = new List<long>();
            long[] res = new long[2];
            ArrayList list = new ArrayList() { 2, 3, 5, 7, 11, 13, 17, 19,
                23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83,
                89, 97};
            for (long i = m; i < n; i++)
            {
                bool st = false;
                for (int j = 0; j < list.Count; j++)
                {
                    if (i%Convert.ToInt32(list[j])!=0)
                    {
                        st = true;
                    }
                    else
                    {
                        st=false;
                        break;
                    }
                }
                if (st == true) listPrime.Add(i);
            }
            for (int i = 0; i < listPrime.Count-2; i++)
            {
                if (listPrime[i+1]-listPrime[i]==g)
                {
                    res[0] = listPrime[i];
                    res[1] = listPrime[i + 1];
                    break;
                }
            }
            return res.Length==0?null:res;
        }


        public static string SumString(string a, string b)
        {
            string res = "";
            if (a.Length > b.Length)
            {
                for (int i = 0; i < a.Length - b.Length; i++)
                {
                    b = "0" + b;
                }
            }
            else if (b.Length > a.Length)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    a = "0" + a;
                }
            }
            int len = a.Length;
            var temp2 = 0;
            for (int i = len - 1; i >= 0; i--)
            {
                var temp = Convert.ToInt32(((char)a[i]).ToString()) + Convert.ToInt32(((char)b[i]).ToString()) + temp2;
                if (temp >= 10 && i == 0)
                {
                    res = temp.ToString() + res;
                }
                else if (temp >= 10)
                {
                    temp2 = 1;
                    res = temp.ToString()[1] + res;
                }
                else
                {
                    res = temp.ToString() + res;
                    temp2 = 0;
                }
            }
            return res;
        }


        public static long factString2Dec(string str)
        {
            long res = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                long temp = 1;
                for (int j = 1; j <= i; j++)
                {
                    temp *= j;
                }

                res += temp * Convert.ToInt64((char)str[str.Length-i-1]);
            }
            

            return res;
        }

        public static BigInteger PerimetrOfRectangles(BigInteger n)
        {

            List<BigInteger> list = new List<BigInteger>();
            BigInteger res = 0;
            list.Add(1); list.Add(1);
            BigInteger i = 2;
            while (i <= n)
            {
                list.Add(list[(int)i - 2] + list[(int)i - 1]);
                i++;

            }
            for (BigInteger l = 0; l <= n; l++)
            {
                res += list[(int)l];
            }

            return res *= 4;
        }

        public static long SplitOddandEven(long n)
        {
            string str_n = n.ToString();
            string str2 = str_n[0].ToString();
            for (int i = 1; i < str_n.Length; i++)
            {
                if ((int)str_n[i] % 2 == 0 && (int)str_n[i - 1] % 2 == 0)
                    str2 = String.Join("", str_n[i]);
                else if ((int)str_n[i] % 2 != 0 && str_n[i - 1] % 2 != 0)
                    String.Join(str2, str_n[i]);
                else str2 = String.Join(str2 + ",", str_n[i]);
            }
            return 5;
        }

        public static string clockinmirror(string timeInMirror)
        {
            string res = "";
            ArrayList list = new ArrayList();
            string min = ""; int hour = 0;
            list.AddRange(timeInMirror.Split(':'));
            int temphour = Convert.ToInt32(list[0]), tempmin = Convert.ToInt32(list[1]);
            if (temphour == 0 && tempmin == 0) return res = "00:00";

            else if (temphour == 12 && tempmin == 0) hour = 12;
            else if (temphour == 6 && tempmin == 0) hour = 6;

            else if (tempmin == 0 && temphour < 11) hour = 12 - temphour;

            else if (temphour < 11) hour = 12 - temphour - 1;

            else if (temphour < 13) hour = 24 - temphour - 1;


            else hour = 36 - temphour;

            if (tempmin == 0) min = "00";

            else min = (60 - tempmin).ToString();

            if (hour.ToString().Length == 1 && min.Length == 1) res = "0" + hour.ToString() + ":" + "0" + min;
            else if (hour.ToString().Length == 1) res = "0" + hour.ToString() + ":" + min;
            else if (min.Length == 1) res = hour.ToString() + ":" + "0" + min;
            else res = hour.ToString() + ":" + min;
            return res;
        }

        public static bool Scramble(string str1, string str2)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        str2 = str2.Remove(j, 1);
                        break;
                    }
                }
            }

            return str2.Length == 0 ? true : false;
        }

        public static int RomanNumeralsEncoder(string roman)
        {
            string[] rums_str = new string[7] { "I", "V", "X", "L", "C", "D", "M" };
            int[] rums_int = new int[7] { 1, 5, 10, 50, 100, 500, 1000 };
            if (roman.Length == 1) return rums_int[Array.IndexOf(rums_str, roman)];
            ArrayList list = new ArrayList();
            foreach (var item in roman)
            {
                list.Add(item);
            }
            int result = 0;

            for (int i = list.Count - 1; i > 0;)
            {
                string temp1 = ((char)list[i]).ToString();
                string temp2 = ((char)list[i - 1]).ToString();

                if (Array.IndexOf(rums_str, temp1) <= Array.IndexOf(rums_str, temp2))
                {
                    if (list.Count % 2 != 0) {
                        result += rums_int[Array.IndexOf(rums_str, temp1)];

                    }
                    else
                    {
                        result += rums_int[Array.IndexOf(rums_str, temp1)];
                    }
                    i--;

                }
                else
                {
                    result += rums_int[Array.IndexOf(rums_str, temp1)] - rums_int[Array.IndexOf(rums_str, temp2)];
                    i -= 2;
                }

                if (i == 0) result += rums_int[Array.IndexOf(rums_str, ((char)list[i]).ToString())];

            }

            return result;
        }


        public static string RomanNumeralsDecoder(int n)
        {

            return "";
        }

        public static int GetNumber(string s)
        {
            string res = "";
            foreach (char item in s)
            {
                if (Char.IsDigit(item)) res += item;
            }
            return int.Parse(res);

        }

        public static int GetAvarage(int[] marks)
        {
            double dvd = 0;
            return Convert.ToInt32(Math.Truncate(dvd = marks.Average()));
        }

        public static ulong factorial(ulong n)
        {
            if (n == 0) return 1;
            while (n < 0)
            {
                n *= n;
            }
            n--;
            return n * factorial(n - 1);
        }

        public static int GetLengthofArray(object[][] arrayOfArrays)
        {
            int temp1 = 0, temp2 = 0, res = 0;
            List<string> index = new List<string>();
            for (int i = 0; i < arrayOfArrays.GetLength(0); i++)
            {

                if (temp2 > arrayOfArrays[i].GetLength(0)) temp2 = arrayOfArrays[i].GetLength(0);
                if (temp1 < arrayOfArrays[i].GetLength(0)) temp1 = arrayOfArrays[i].GetLength(0);
                index.Add(arrayOfArrays[i].GetLength(0).ToString());
                if (i == 0) temp2 = Convert.ToInt32(index[0]);
            }

            for (int i = temp2; i < temp1; i++)
            {
                if (!index.Contains(i.ToString()))
                {
                    res = i;
                    break;
                }
            }
            return res;
        }

        public static string ToJadenCase(string phrase)
        {
            string temp = "";
            for (int i = 0; i < phrase.Length; i++)
            {
                if (i == 0 || phrase[i - 1] == ' ')
                    temp += phrase[i].ToString().ToUpper();
                else
                    temp += phrase[i].ToString();
            }
            return temp;
        }

        public static int Score(int[] dice)
        {
            string[] numbs = new string[8] { "1", "5", "222", "333", "444", "555", "666", "111" };
            int[] values = new int[8] { 100, 50, 200, 300, 400, 500, 600, 1000 };
            int res = 0;
            if (values.Contains(50))
            foreach (int item in dice) {
                int sayg = 0;
                string tempstr = "";
                for (int j = 0; j < dice.Length; j++)
                {
                    if (sayg == 3) break;
                    if (item == dice[j])
                    {
                        sayg++;
                        tempstr += item.ToString();
                        dice = dice.Where((source, index) => index != j).ToArray();
                        j--;
                    }
                }

                if (numbs.Contains(tempstr))
                {
                    res += values[Array.IndexOf(numbs, tempstr)];

                }


            }
            return res;
        }

        public static int GiveTriang(int per)
        {
            int sayg = 0;
            double len1 = Math.Round((double)per / 3);
            double len2 = Math.Round((double)per / 2);
            for (int i = 1; i < 20; i++)
            {
                bool st = true;
                for (int j = 1; j <= 50; j++)
                {
                    for (int l = 1; l <= 50; l++)
                    {
                        if (i == l || l == j || i == j) break;
                        if (i + l + j <= per)
                        {
                            if (i + l > j && i + j > l && j + l > i)
                            {
                                sayg++;
                            }
                        }
                        else
                        {
                            st = false;
                            break;
                        }
                    }
                    if (st == false) break;
                }
                if (st == false) break;
            }
            return sayg;
        }

        public static List<int> Tekrarlar(int[] arr)
        {
            List<int> netice = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                int sayg = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (temp == arr[j] && !netice.Contains(temp)) sayg++;
                }
                if (sayg > 1) netice.Add(temp);
            }
            return netice;
        }
        
        public static int Say(int[] arr)
        {
            int sayg = 0;
            int a;
            for (int i=0; ; i++)
            {
                try
                {
                    if (int.TryParse(arr[i].ToString(),out a))
                    {
                        sayg++;
                        continue;
                    }
                }
                catch(Exception)
                {
                    break;
                }
                
                
            }
            return sayg;

        }

        public static int[] sirala(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                for (int j = 0; j < i; j++)
                {
                    int temp2 = arr[j];
                    if (temp<arr[j])
                    {
                        arr[j] = arr[i];
                        arr[i] = temp2;
                        
                    }
                }
                

            }
            return arr;
        }

        public static string[] inArray(string[] array1, string[] array2)
        {
            // your code
            for (int i = 0; i < array1.Length; i++)
            {
                bool st = false;
                for (int j = 0; j < array2.Length; j++)
                {
                    string temp = array2[j];
                    for (int k = 0; k <= temp.Length- array1[i].Length; k++)
                    {
                        if (temp.Substring(k,array1[i].Length)==array1[i])
                        {
                            st = true;
                            break;
                        }
                    }
                    if(st == true) break;

                }
                if (st == false)
                {
                    array1 = array1.Where((source, index) => index != i).ToArray();
                    i--;
                }

            }
            Array.Sort(array1);
            return array1;
        }

        public static int[,] GarbleSort(int[] values)
        {
            int[,] arr = new int[4, 5];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        arr[i, j] = 1;
                    }
                }
            }
            
            return arr;
        }

        public static List<int> SumConsecutives(List<int> s)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < s.Count; )
            {
                int sayg = 0;
                int temp = 0;
                for (int j = i; j < s.Count; j++)
                {
                    if (s[i] == s[j])
                    {
                        temp += s[j];
                        sayg++;
                    }
                    else
                    {
                        break;
                    }
                }
                i += sayg;
                res.Add(temp);
            }
            return res;
        }

        public static int Persistence(long n)
        {
            // your code
            int sayg = 0;
            label:
            int temp = 1;
            int len = n.ToString().Length;
            if (len > 1)
            {
                for (int i = 0; i < len; i++)
                {
                    char b = (char)n.ToString()[i];
                    temp *= Convert.ToInt32(b.ToString());
                }
                n = temp;
                sayg++;
            }
            if (n.ToString().Length>1)
            {
                goto label;
            }
            else
            {
                return sayg;
            }
           
        }

        public static string MESELEN(string metn)
        {
            /* eger metodla isteyirsizse 
             * .Replace metodu hell edir hershey , 
             * yox metodsuz indekleyerek olsa forun icinde metnin 
             * indeksini editlemek olmur error verir ona gore de bu yolla
             *  dogru netice alinir her bir hal uchun*/
            string text1 = "Codess",text2="CodeSS";
            string res = "";
            for (int i = 0; i < metn.Length;)
            {
                if (metn.Substring(i, text1.Length) == text2)
                {
                    res += text1;
                    i += text1.Length;
                }
                else
                {
                    res += metn[i];
                    i++;
                }
            }
            return res;
        }

        public static string[] Solution(string str)
        {
            
            if (str.Length % 2 != 0) str += "+";
            string[] arr = new string[str.Length / 2];
            int j = 0;
            for(int i = 0; i < str.Length; i+=2)
            {
                arr[j] = str.Substring(i, 2);
                j++;
            }
           arr[arr.Length-1]=arr[arr.Length - 1].Replace("+", "_");
            
            return arr;
        }


        public static string Factorial(int n)
        {
            ulong res = 1;
            for (int i = n; i >= 1; i--) 
            {
                res *= (ulong)i;
            }
            return res.ToString();

        }

        public static void Sudoku(List<int> arr )
        {
            
        }
    }
}
