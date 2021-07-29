using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace mirta
{
    class Codes4
    {


        static void toASCII64Encoder(byte[] data)
        {
            string result = "<~";
            string bit = String.Empty;
            for (byte i = 0; i < data.Length; i++)
            {
                bit += Convert.ToString(data[i], 2);
            }
            List<int> ASCII64 = new List<int>();
            for (int i = 0; i <= 12; i += 6)
            {
                ASCII64.Add(Convert.ToInt32(bit.Substring(i, 6), 2));
                result += ((char)Convert.ToInt32(bit.Substring(i, 6), 2)).ToString();
            }
            result += "~>";
        }

        static bool Sudoku(int[,] board)
        {
            int[,] temp = new int[9, 9];
            List<int> tempList = new List<int>();
            List<int> xTempList = new List<int>();
            List<int> yTempList = new List<int>();
            int m, n;
            for (m = 0; m < 9; m += 3)
            {
                for (n = 0; n < 9; n += 3)
                {

                    tempList.Clear();
                    for (int i = m; i < m + 3; i++)
                    {
                        for (int j = n; j < n + 3; j++)
                        {
                            tempList.Add(board[i, j]);

                        }
                    }
                    if (tempList.Sum() != 45)
                        return false;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    xTempList.Add(board[i, j]);
                    yTempList.Add(board[j, i]);
                }
                if (xTempList.Sum() != 45 || yTempList.Sum() != 45)
                {
                    return false;
                }
                xTempList.Clear();
                yTempList.Clear();
            }



            return true;
        }


        public static string AddingBigNumbers(string a, string b)
        {
            string res = "";
            int lena = a.Length, lenb = b.Length;
            if (lena > lenb)
            {
                for (int i = 0; i < lena - lenb; i++)
                {
                    b = "0" + b;
                }
            }
            else if (lenb > lena)
            {
                for (int i = 0; i < lenb - lena; i++)
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

        public static string DevideBigNumbers(string a, string b)
        {
            string res = "";

            return "";
        }

        //    #region Drawing_Console

        //    static Graphics graphics;
        //    static BufferedGraphics bufferedGraphics;
        //    static Player player;
        //    static void Main()
        //    {

        //        AddingBigNumbers("1584818714848464849494949194494949979", "98984994949799497979191914949849");
        //        //player = new Player();
        //        //Console.CursorVisible = false;
        //        //Process process = Process.GetCurrentProcess();
        //        //graphics = Graphics.FromHdc(GetDC(process.MainWindowHandle));
        //        //BufferedGraphicsContext context = BufferedGraphicsManager.Current;
        //        //context.MaximumBuffer = new Size(Console.WindowWidth, Console.WindowHeight);
        //        //bufferedGraphics = context.Allocate(graphics, new Rectangle(0, 0, 320, 200));
        //        //while (true)
        //        //{
        //        //    bufferedGraphics.Graphics.Clear(Color.Red);
        //        //    player.Draw(bufferedGraphics.Graphics);
        //        //    bufferedGraphics.Render(graphics);
        //        //    player.DoMove();
        //        //}
        //    }
        //    [DllImport("user32.dll", CharSet = CharSet.Auto)]
        //    public static extern IntPtr GetDC(IntPtr hWnd);
        //}

        //#endregion
    }
}
