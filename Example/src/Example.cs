using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinBox2D.Examples
{
    public class Example
    {
        static Form form;

        static Panel player;

        public static void Main()
        {
            form = new Form()
            {
                Text = "Example"
            };

            Panel box1 = new Panel()
            {
                Size = new Size(50, 50),
                BackColor = Color.Green
            };

            player = new Panel()
            {
                Size = new Size(50, 50),
                Location = new Point(50, 50),
                BackColor = Color.Blue
            };

            if (WinBox2D.CheckCollision(box1, player))
            {
                player.BackColor = Color.Red;
            }

            form.Controls.Add(box1);
            form.Controls.Add(player);

            Application.Run(form);
        }
    }
}
