using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinBox2D
{
    public class WinBox2D
    {
        public static bool CheckCollision(Panel a, Panel b)
        {
            return a.Bounds.IntersectsWith(b.Bounds);
        }
    }
}
