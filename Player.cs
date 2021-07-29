using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace mirta
{
    public  class Player
    {
        const int LEFT = 0x25;
        const int UP = 0x26;
        const int RIGHT = 0x27;
        const int DOWN = 0x28;
        float x;
        float y;

        public Player()
        {
            this.x = 0;
            this.y = 0;
        }

        public void DoMove()
        {
            if ((GetKeyState(LEFT) | 0x8000) > 0 && this.x < 320)
            {
                this.x += 0.1f;
            }
            if ((GetKeyState(RIGHT) | 0x8000) > 0 && this.x > 0)
            {
                this.x -= 0.1f;
            }
            if ((GetKeyState(UP) | 0x8000) > 0 && this.y < 200)
            {
                this.y += 0.1f;
            }
            if ((GetKeyState(DOWN) | 0x8000) > 0 && this.y > 0)
            {
                this.y -= 0.1f;
            }
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Blue, this.x - 10, this.y - 10, 20, 20);
        }

        [DllImport("user32.dll")]
        static extern short GetKeyState(int nVirtKey);
    }
}
