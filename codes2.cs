using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mirta
{
    class codes2
    {
        public static int TekrarlananlarArasindakiMaxIndex(List<int> data)
        {
            int index = 0, index1;
            int saygac = 0;
            int numb = 0;
            for (int i = 0; i < data.Count; i++)
            {
                numb = data[i];
                for (int j = 0; j < data.Count; j++)
                {
                    if (numb == data[j])
                    {
                        saygac++;
                        if (saygac != 1)
                        {
                            index1 = data.LastIndexOf(data[j]) - data.IndexOf(data[j]);
                            if (index < index1)
                            {
                                index = index1;
                                saygac = 0;
                            }
                        }
                    }
                }
            }

            return index;
        }

        public static long[] PrimeAftprBefpr(long num)
        {
            //Surrounding Primes for a value
            ArrayList listPrime = new ArrayList();
            for (int i = 2; i < 500000; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i % 11 != 0 && i % 13 != 0) listPrime.Add(i);

            }
            long[] arr = new long[2]; long aft = num, bef = num; int saygac = 0;
            for (;;)
            {
                bef--;
                double kokalti = Math.Sqrt(bef) - Convert.ToInt32(Math.Sqrt(bef));
                if (bef % 2 != 0 && bef % 3 != 0 && bef % 5 != 0 && bef % 7 != 0
                    && kokalti != 0)
                {
                    foreach (int item in listPrime)
                    {
                        double res1 = Convert.ToDouble(bef) / Convert.ToDouble(item);
                        if (res1 - bef / item != 0 || bef == item)
                        {
                            saygac++;
                            if (saygac == listPrime.Count) arr[0] = bef;
                        }
                    }
                    saygac = 0;
                }
                else if (arr[0] != 0) break;
            }
            for (;;)
            {
                aft++;
                double kokalti = Math.Sqrt(aft) - Convert.ToInt64(Math.Sqrt(aft));
                if (aft % 2 != 0 && aft % 3 != 0 && aft % 5 != 0 && aft % 7 != 0
                    && kokalti != 0)
                {
                    foreach (int item in listPrime)
                    {
                        double res1 = Convert.ToDouble(aft) / Convert.ToDouble(item);
                        if (res1 - aft / item != 0 || aft == item)
                        {
                            saygac++;
                            if (saygac == listPrime.Count) arr[1] = aft;

                        }

                    }
                    saygac = 0;
                }
                else if (arr[1] != 0) break;

            }

            return arr;
        }

        public static ulong[] ProdFibonacci(ulong n)
        {
            ArrayList list = new ArrayList();
            ulong[] arr = new ulong[3];
            list.Add(1);
            list.Add(1);
            for (int i = 2; i < 49; i++)
            {
                ulong temp1 = Convert.ToUInt32(list[i - 2]);
                ulong temp2 = Convert.ToUInt32(list[i - 1]);
                list.Add(temp1 + temp2);
            }
            for (int j = 1; j < list.Count; j++)
            {
                ulong temp1 = Convert.ToUInt32(list[j - 1]);
                ulong temp2 = Convert.ToUInt32(list[j]);
                if (temp1 * temp2 == n)
                {
                    arr[0] = temp1;
                    arr[1] = temp2;
                    arr[2] = 1;
                    break;
                }
                else if (temp1 * temp2 < n)
                {
                    continue;
                }
                else
                {
                    arr[0] = temp1;
                    arr[1] = temp2;
                    arr[2] = 0;
                    break;
                }
            }

            return arr;
        }

        public static int numbcutadd(double a)
        {
            double tempnumb = 0; int result = 0;
            string len = a.ToString();
            for (int i = 0; i < len.Length; i++)
            {
                a = a / 10;
                tempnumb = (a - (int)a) * 10;
                tempnumb = Math.Round(tempnumb);
                result += (int)tempnumb;
                a = Math.Truncate(a);
            }
            return result;
        }

        public static int DuplicateCount(string word)
        {
            int res = 0;
            word = word.ToLower();
            char[] c = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                c[i] = word[i];
            }
            HashSet<char> str = new HashSet<char>(c);
            char[] result = new char[str.Count];
            str.CopyTo(result);
            for (int i = 0; i < result.Length; i++)
            {
                int sayg = 0;
                char temp = result[i];
                for (int j = 0; j < word.Length; j++)
                {
                    if (temp == word[j])
                    {
                        sayg++;
                    }
                    if (j == word.Length - 1 && sayg > 1)
                    {
                        res++;
                    }

                }

            }

            return res;
        }

        public static int FindElement(int[] arr)
        {
            int sayg1 = 0, sayg2 = 0, res = -1, res1 = 0, res2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                if (temp % 2 == 0)
                {
                    sayg1++;
                    res1 = temp;

                }
                else
                {
                    sayg2++;
                    res2 = temp;
                }
            }
            if (sayg1 == 1) res = res1;
            else if (sayg2 == 1) res = res2;

            return res;
        }

        public static long PadovanNthNumbers(int n)
        {
            ArrayList list = new ArrayList();
            list.Add(1); list.Add(1); list.Add(1);
            for (int i = 3; i < 100; i++)
            {
                list.Add(Convert.ToInt64(list[i - 2]) + Convert.ToInt64(list[n - 3]));

            }

            return (long)list[n];
        }


        public static double[] xbonacci(double[] signature, int n)
        {
            double[] xbonres = new double[n];
            for (int i = 0; i < signature.Length; i++)
            {
                xbonres[i] = signature[i];

            }

            for (int i = signature.Length; i < n; i++)
            {
                double numb = 0;
                for (int j = signature.Length; j > 0; j--)
                {
                    numb += xbonres[i - j];
                }

                xbonres[i] = numb;
            }

            return signature.Length == 0 ? null : xbonres;

        }

        public static double[] xbonacci2(double[] signature, int n)
        {
            ArrayList list = new ArrayList();
            list.AddRange(signature);
            int index = list.Count;
            double[] arr = new double[n];
            for (int i = index - 1; i < n; i++)
            {


            }
            return signature;
        }

       

        public static bool isMerge(string s, string part1, string part2)
        {
            string s2 = part1 + part2;
            int ascii1 = 0, ascii2 = 0;
            for (int i = 0; i < s.Length; i++)
            {
                ascii1 += s[i];
            }
            for (int i = 0; i < s2.Length; i++)
            {
                ascii2 += s2[i];
            }
            return ascii1 == ascii2 ? true : false;
        }

        public static int DescendingOrder(int num)
        {
            string numb = num.ToString();
            ArrayList list = new ArrayList();
            for (int i = 0; i < numb.Length; i++)
            {
                string a = Char.ConvertFromUtf32(numb[i]);
                list.Add(Convert.ToInt32(a));
            }
            list.Sort(); list.Reverse();
            numb = "";
            foreach (var item in list)
            {
                numb += item;
            }
            num = Convert.ToInt32(numb);
            return num;
        }

        public static bool AreTheySame(int[] a, int[] b)
        {
            bool st = false;
            for (int i = 0; i < a.Length; i++)
            {
                int temp = a[i];
                for (int j = 0; j < b.Length; j++)
                {
                    if (temp * temp == b[j] || temp == b[j] || temp == b[j] * b[j])
                    {
                        st = true;
                        b = b.Where((source, index) => index != j).ToArray();
                        break;
                    }
                    else
                    {
                        st = false;
                    }
                }
                if (st == false)
                {
                    break;
                }
            }
            return st;

        }

        public static bool IsBalanced(string s, string caps)
        {
            string cont = "";
            for (int i = 0; i < caps.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (caps[i] == s[j])
                    {
                        cont += caps[i];
                        s = s.Remove(j, 1);
                        break;
                    }

                }
            }
            return cont == caps ? true : false;
        }

        public static int LastFibDigit(long n)
        {
            ArrayList list = new ArrayList();
            long numb = 0;
            list.Add(1); list.Add(1);
            for (int i = 2; i < 200; i++)
            {
                list.Add(Convert.ToInt32(list[i - 2]) + Convert.ToInt32(list[i - 1]));
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (n - 1 == i)
                {
                    numb = Convert.ToInt32(list[i]);
                }
            }
            char c = (char)numb.ToString()[numb.ToString().Length - 1];
            string numbtext = c.ToString();
            return Convert.ToInt32(numbtext);

        }

        public static double[] Tribonacci(double[] signature, int n)
        {
            double[] xbonres = new double[n];
            for (int i = 0; i < signature.Length; i++)
            {
                xbonres[i] = signature[i];
            }
            for (int i = 3; i < n; i++)
            {
                xbonres[i] = xbonres[i - 3] + xbonres[i - 2] + xbonres[i - 1];
            }
            return xbonres;

        }

        public static long NextBiggerNumber2(long n)
        {
            string[] arr = new string[n.ToString().Length];
            for (int i = 0; i < n.ToString().Length; i++)
            {
                arr[i] = n.ToString()[i].ToString();
            }
            long n2 = 0;
            HashSet<string> set = new HashSet<string>(arr);
            string[] basicarr = new string[set.Count];
            set.CopyTo(basicarr);
            for (int i = 0; i < 10000; i++)
            {
                n++;
                n2 = n;
                string[] arr2 = new string[n2.ToString().Length];
                for (int j = 0; j < n2.ToString().Length; j++)
                {
                    arr2[j] = n2.ToString()[j].ToString();
                }
                HashSet<string> set2 = new HashSet<string>(arr2);
                string[] basicarr2 = new string[set2.Count];
                set2.CopyTo(basicarr2);
                int saygac = 0;
                for (int m = 0; m < basicarr.Length; m++)
                {

                    string temp = basicarr[m];
                    for (int l = 0; l < basicarr2.Length; l++)
                    {
                        if (temp == basicarr2[l])
                        {
                            saygac++;
                        }
                    }

                }
                if (saygac == basicarr2.Length)
                {

                    break;
                }
            }
            return n2;
        }

        public static long NextBiggerNumber3(long n)
        {
            string nstr = n.ToString();
            long n2 = 0;
            for (;;)
            {
                n++;
                n2 = n;
                string nstr2 = n2.ToString();
                for (int i = 0; i < nstr.Length; i++)
                {
                    char temp = nstr[i];
                    for (int j = 0; j < nstr2.Length; j++)
                    {
                        if (temp == nstr2[j])
                        {
                            nstr2 = nstr2.Remove(j, 1);
                            break;
                        }
                    }

                }
                if (String.IsNullOrEmpty(nstr2))
                {
                    break;
                }


            }
            return n2;
        }


        public static int IQTest(string numbers)
        {
            ArrayList list = new ArrayList();
            list.AddRange(numbers.Split(' '));
            int temp1=0, temp2=0;
            int indexodd = 0, indexeven = 0;
            for (int i = 0; i < list.Count; i++)
            {
                
                if (Convert.ToInt32(list[i])%2==0)
                {
                    indexeven++;
                    temp1 = i;

                }
                else
                {
                    indexodd++;
                    temp2 = i;
                }
            }
            if (indexeven==1)
            {
                return temp1 + 1;
            }
            else
            {
                return temp2 + 1;
            }
        }

        public static string everynthreplace(string text,int n,char oldChar,char newChar)
        {
            int index = 0;
            string newtext = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]==oldChar)
                {
                    index++;
                    if (index==n)
                    {
                        newtext += newChar.ToString();
                        index = 0;
                    }
                    else newtext += text[i].ToString();


                }
                else
                    newtext += text[i].ToString();
            }
            return newtext;
        }

        public static List<int> PascalTriangle(int n)
        {
            int label = n;
            int n2 = 0; 
            for (int i = n; i >=1 ; i--)
            {
                n2 += i;
            }
            int j = 1;
            int index = 0;
            List<int> list = new List<int>(n2);
            for (int i = 0; i < label; i++)
            {
                for (int l = 0; l < j; l++)
                {
                    if (l==0 || l==j-1)
                    {
                        list.Add(1);
                        index++;
                    }
                    else
                    {
                        list.Add(list[index - j] + list[index - j + 1]);
                        index++;
                    }

                }
                j++;
            }
            return list;

        }


        public static string Converter(string input,string source,string target)
        {
            if (target == "Alphabet.BINARY")
            {
                return Convert.ToString(Convert.ToInt32(input), 2);
            }
            else if (target == "Alphabet.OCTAL")
            {
                return Convert.ToInt32(input, 2).ToString();
            }
            else if (target == "Alphabet.DECIMAL")
            {
                Convert.ToInt32(input, 2).ToString();
            }
            else if (target == "Alphabet.HEXA_DECIMAL")
            {
                byte[] bytes = Encoding.ASCII.GetBytes(input);
                return Convert.ToInt32(BitConverter.ToInt32(bytes,0).ToString(), 16).ToString();
            }
            else if (target == "Alphabet.ALPHA_LOWER")
            {
                if (source == "Alphabet.DECIMAL") return input[Convert.ToInt32(input)].ToString();


            }
            else if (target == "Alphabet.ALPHA_UPPER")
            {
                input.ToUpper();
            }
            else if (target == "Alphabet.APLPHA")
            {
                return Convert.ToString(Convert.ToChar(input));
            }
            else if(source == "Alphabet.ALPHA_NUMERIC")
            {
                return " ";
            }
            return "   ";

        } // buna baxmaq yaddan chixmasin

        public static int[] getpascaltrrow(int rowNumber)
        {
            int label = rowNumber;
            int n2 = 0;
            for (int i = rowNumber; i >= 1; i--)
            {
                n2 += i;
            }
            int j = 1;
            int index = 0;
            int[] list = new int[n2];
            int[] resarr = new int[label];
            for (int i = 0; i < label; i++)
            {
                for (int l = 0; l < j; l++)
                {
                    if (l == 0 || l == j - 1)
                    {
                        list[index] = 1;
                        index++;
                        if (i==label-1)
                        {
                            resarr[l] = 1;
                        }
                    }
                    else
                    {
                        if (i==label-1)
                        {
                            resarr[l]= (list[index - j] + list[index - j + 1]);
                        }
                        list[index]=(list[index - j] + list[index - j + 1]);
                        index++;
                    }

                }
                j++;
            }
            
           
            return resarr;
        }

 
        

        public static int TripleTrouble(long num1,long num2)
        {
            string str_num1 =num1.ToString();
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            string str_num2 = num2.ToString();
            for (int i = 0; i < str_num1.Length; i++)
            {
                int count = str_num1.ToCharArray().Count(c => c == str_num1[i]);
                if (count >= 3 && !list1.Contains(str_num1[i]))
                {
                    list1.Add(str_num1[i]);
                }
            }
            for (int i = 0; i < str_num2.Length; i++)
            {
                int count = str_num2.ToCharArray().Count(c => c == str_num2[i]);
                if (count==2 && !list2.Contains(str_num2[i]))
                {
                    list2.Add(str_num2[i]);
                }
            }
            int res = 0;
            if (list1.Count>list2.Count)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    res += list1.ToArray().Count(c => c == list2[i]);
                }
            }
            else
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    res += list2.ToArray().Count(c => c == list1[i]);
                }
            }



            return res;
        }

        public static string Consective(string[] strarr,int k)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < strarr.Length; i++)
            {
                list.Add(strarr[i]);
            }
            list.Sort();
            string res = "";
            ArrayList basiclist = new ArrayList();
            for (int i = 0; i < k; i++)
            {
                if (!basiclist.Contains(list[i]))
                {
                    basiclist.Add(list[i]);
                    res += list[i];
                }
                else
                {
                    k++;
                }
            }
            return res;
        }



       
    }
}