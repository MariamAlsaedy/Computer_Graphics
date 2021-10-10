using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Graphics_Project
{
    public partial class Form3 : Form
    {
        public Point MouseLocation;
        public Form3()
        {
            InitializeComponent();
        }
        public void DDA(int xa, int ya, int xb, int yb)
        {
            Bitmap DL = new Bitmap(picBox2.Width, picBox2.Height);
            int dx = xb - xa;
            int dy = yb - ya;
            int s = Math.Max(Math.Abs(dx), Math.Abs(dy));
            float xi = dx / (float)s;
            float yi = dy / (float)s;
            float x = xa;
            float y = yb;
            int k = 0;
            while(k < s)
            {
                DL.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.DarkOliveGreen);
                x = x + xi;
                y = y + yi;
                k++;
            }
            picBox.Image = DL;
        }
        public void Circle(int Xc, int Yc, int Rc)
        {
            Bitmap c = new Bitmap(picBox2.Width, picBox2.Height);
            int x = Rc;
            int y = 0;
            int p0 = 1 - Rc;
            while (x >= y)
            {
                c.SetPixel(x + Xc, y + Yc, Color.Chocolate);
                c.SetPixel(y + Xc, x + Yc, Color.Chocolate);
                c.SetPixel(-x + Xc, y + Yc, Color.Chocolate);
                c.SetPixel(-y + Xc, x + Yc, Color.Chocolate);
                c.SetPixel(-x + Xc, -y + Yc, Color.Chocolate);
                c.SetPixel(-y + Xc, -x + Yc, Color.Chocolate);
                c.SetPixel(x + Xc, -y + Yc, Color.Chocolate);
                c.SetPixel(y + Xc, -x + Yc, Color.Chocolate);
                if (p0 <= 0)
                {
                    p0 = p0 + 2 * (y + 1) + 1;
                    y++;
                }
                else
                {
                    p0 = p0 + 2 * (y + 1) - 2 * (x - 1) + 1;
                    y++;
                    x--;
                }
            }
            picBox.Image = c;
        }
        void Ellipse(int Xc, int Yc, int Rx, int Ry)
        {
            Bitmap E = new Bitmap(picBox2.Width, picBox2.Height);
            int x = 0; int y = Ry;
            double p01 = Ry * Ry - Rx * Rx * Ry + Rx * Rx / 4;
            int m = 2 * Ry * Ry * x;
            int n = 2 * Rx * Rx * y;
            do
            {
                E.SetPixel(Xc + x, Yc + y, Color.Chocolate);
                E.SetPixel(Xc - x, Yc + y, Color.Chocolate);
                E.SetPixel(Xc - x, Yc - y, Color.Chocolate);
                E.SetPixel(Xc + x, Yc - y, Color.Chocolate);
                if (p01 < 0)
                {
                    x++;
                    m = 2 * Ry * Ry * x;
                    n = 2 * Rx * Rx * y;
                    p01 = p01 + Ry * Ry * (2 * x + 3);
                }
                else
                {
                    x++; y--;
                    m = 2 * Ry * Ry * x;
                    n = 2 * Rx * Rx * y;
                    p01 = p01 + Ry * Ry * (2 * x + 3) + Rx * Rx * (-2 * y + 2);
                }
            } while (m < n);

            double p02 = Ry * Ry * (x + 0.5) * (x + 0.5) + Rx * Rx * (y - 1) * (y - 1) - Rx * Rx * Ry * Ry;
            do
            {
                E.SetPixel(Xc + x, Yc + y, Color.Chocolate);
                E.SetPixel(Xc - x, Yc + y, Color.Chocolate);
                E.SetPixel(Xc - x, Yc - y, Color.Chocolate);
                E.SetPixel(Xc + x, Yc - y, Color.Chocolate);
                if (p02 < 0)
                {
                    y--; x++;
                    p02 = p02 + Ry * Ry * (2 * x + 2) + Rx * Rx * (-2 * y + 3);

                }
                else
                {
                    y--;
                    p02 = p02 - Rx * Rx * (2 * y - 3);
                }
            } while (y >= 0);
            picBox.Image = E;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var nextForm = new Form1();
            nextForm.Show();
            this.Hide();
            nextForm.Closed += (s, args) => this.Close();
            nextForm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(MouseLocation.X, MouseLocation.Y);
                Location = mousePose;
            }
        }

        private void DDA_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int xa = int.Parse(txt1.Text);
                int ya = int.Parse(txt2.Text);
                int xb = int.Parse(txt3.Text);
                int yb = int.Parse(txt4.Text);
                DDA(xa, ya, xb, yb);
            }
            catch
            {
                warning.Show();
            }
        }

        private void Bresenham_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap BL = new Bitmap(picBox2.Width, picBox2.Height);
                int xa = int.Parse(txt1.Text);
                int ya = int.Parse(txt2.Text);
                int xb = int.Parse(txt3.Text);
                int yb = int.Parse(txt4.Text);
                int dx = xb - xa;
                int dy = yb - ya;
                int x = xa;
                int y = ya;
                int p = 2 * dy - dx;
                int i = xa;
                while (i <= xb)
                {
                    BL.SetPixel(x, y, Color.DarkOliveGreen);
                    x++;
                    if (p < 0)
                    {
                        p = p + 2 * dy;
                    }
                    else
                    {
                        p = p + 2 * dy - 2 * dx;
                        y++;
                    }
                    i++;
                }
                picBox.Image = BL;
            }
            catch
            {
                warning.Show();
            }
        }

        private void Circle_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int Xc = int.Parse(txt1.Text);
                int Yc = int.Parse(txt2.Text);
                int Rc = int.Parse(txt14.Text);
                Circle(Xc, Yc, Rc);
            }
            catch
            {
                warning.Show();
            }
        }

        private void Ellipse_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txt1.Text);
                int y = int.Parse(txt2.Text);
                int rx = int.Parse(txt16.Text);
                int ry = int.Parse(txt17.Text);
                Ellipse(x, y, rx, ry);
            }
            catch
            {
                warning.Show();
            }
        }
    }
}
