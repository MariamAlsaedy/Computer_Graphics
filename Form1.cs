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
    public partial class Form1 : Form
    {
        public Point MouseLocation;

        public Form1()
        {
            InitializeComponent();
        }
        public void DDA(int xa, int ya, int xb, int yb)
        {
            Bitmap DL = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int dx = xb - xa;
            int dy = yb - ya;
            int s = Math.Max(Math.Abs(dx), Math.Abs(dy));
            float xi = dx / (float)s;
            float yi = dy / (float)s;
            float x = xa;
            float y = yb;
            int k = 0;
            while (k < s)
            {
                DL.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.White);
                x = x + xi;
                y = y + yi;
                k++;
            }
            pictureBox1.Image = DL;
        }
        void Ellipse(int Xc, int Yc, int Rx, int Ry)
        {
            Bitmap E = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int x = 0; int y = Ry;
            double p01 = Ry * Ry - Rx * Rx * Ry + Rx * Rx / 4;
            int m = 2 * Ry * Ry * x;
            int n = 2 * Rx * Rx * y;
            do
            {
                E.SetPixel(Xc + x, Yc + y, Color.White);
                E.SetPixel(Xc - x, Yc + y, Color.White);
                E.SetPixel(Xc - x, Yc - y, Color.White);
                E.SetPixel(Xc + x, Yc - y, Color.White);
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
                E.SetPixel(Xc + x, Yc + y, Color.White);
                E.SetPixel(Xc - x, Yc + y, Color.White);
                E.SetPixel(Xc - x, Yc - y, Color.White);
                E.SetPixel(Xc + x, Yc - y, Color.White);
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
            pictureBox1.Image = E;
        }
        public void Circle(int Xc, int Yc, int Rc)
        {
            Bitmap c = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int x = Rc;
            int y = 0;
            int p0 = 1 - Rc;
            while (x >= y)
            {
                c.SetPixel(x + Xc, y + Yc, Color.White);
                c.SetPixel(y + Xc, x + Yc, Color.White);
                c.SetPixel(-x + Xc, y + Yc, Color.White);
                c.SetPixel(-y + Xc, x + Yc, Color.White);
                c.SetPixel(-x + Xc, -y + Yc, Color.White);
                c.SetPixel(-y + Xc, -x + Yc, Color.White);
                c.SetPixel(x + Xc, -y + Yc, Color.White);
                c.SetPixel(y + Xc, -x + Yc, Color.White);
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
            pictureBox1.Image = c;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(MouseLocation.X, MouseLocation.Y);
                Location = mousePose;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DDA_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = int.Parse(txt1.Text);
                int y1 = int.Parse(txt2.Text);
                int x2 = int.Parse(txt3.Text);
                int y2 = int.Parse(txt4.Text);
                DDA(x1, y1, x2, y2);
            }
            catch
            {
                string message = "Oops try another value\nfor X - axis or Y - axis!!";
                MessageBox.Show(message);
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bresenham_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap BL = new Bitmap(pictureBox1.Width, pictureBox1.Height);
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
                    BL.SetPixel(x, y, Color.White);
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
                pictureBox1.Image = BL;
            }
            catch
            {
                string message = "Oops try another value\nfor X - axis or Y - axis!!";
                MessageBox.Show(message);
            }
        }

        private void Elibse_btn_Click(object sender, EventArgs e)
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
                string message = "Oops try another value\nfor X - axis or Y - axis!!";
                MessageBox.Show(message);
            }

        }

        private void Circle_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int xc = int.Parse(txt1.Text);
                int yc = int.Parse(txt2.Text);
                int rc = int.Parse(txt14.Text);
                Circle(xc, yc, rc);
            }
            catch
            {
                string message = "Oops try another value\nfor X - axis or Y - axis!!";
                MessageBox.Show(message);
            }
        }
        
        private void Translation_btn_Click(object sender, EventArgs e)
        {
            try
            {
                x1 = int.Parse(txt1.Text);
                y1 = int.Parse(txt2.Text);
                x2 = int.Parse(txt3.Text);
                y2 = int.Parse(txt4.Text);
                int tx = int.Parse(txt5.Text);
                int ty = int.Parse(txt6.Text);
                x1 += tx;
                y1 += ty;
                x2 += tx;
                y2 += ty;
                DDA(x1, y1, x2, y2);
            }
            catch
            {
                string message = " Some information missed\n Or input another values for x-axis and y-axis ";
                MessageBox.Show(message);
            }
        }

        int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
        int dir = 1, dir2 = -1;
        double[,] Matrix_X_Matrix(double[,] arr1, double[,] arr2)
        {
            double[,] res = new double[3, 3];

            for (int i = 0; i < 9; i++)
            {

                for (int col = 0; col < 3; col++)
                {
                    res[i / 3, i % 3] += arr1[i / 3, col] * arr2[col, i % 3];
                }

            }

            return res;
        }
        double[] mat_X_mat(double[,] arr1, double[] arr2)
        {
            double[] res = new double[3];

            for (int i = 0; i < 9; i++)
            {
                res[i / 3] += arr1[i / 3, i % 3] * arr2[i % 3];
            }

            return res;
        }
        public void DrawPoint(int x, int y, PictureBox p)
        {
            try
            {
                if (x < 0 || x > p.Width || y < 0 || y > p.Height)
                {
                    return;
                }
                ((Bitmap)p.Image).SetPixel(x, y, Color.Black);
            }
            catch (Exception) { }
        }
        List<List<int>> DATA = new List<List<int>>();

        double[,] ConvertToZero(double x, double y)
        {
            double[,] ConvertToZero ={
                                 {1,0,-1*x},
                                 {0,1,-1*y},
                                 {0,0,1}
                                  };
            return ConvertToZero;
        }
        private void Rotation_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double Ceta = double.Parse(txt9.Text) * Math.PI / 180;
                double[,] rotate ={
                      {Math.Cos(Ceta),Math.Sin(Ceta)*dir,0},
                      {Math.Sin(Ceta)*dir2,Math.Cos(Ceta),0},
                      {0,0,1}
                      };
                double[,] p1_0 = ConvertToZero((x1 + x2) / 2, (y1 + y2) / 2);

                double newdx1 = x1 + p1_0[0, 2];
                double newdx2 = x2 + p1_0[0, 2];

                double newdy1 = y1 + p1_0[1, 2];
                double newdy2 = y2 + p1_0[1, 2];

                double[,] cback = ConvertToZero((x1 + x2) / -2, (y1 + y2) / -2);

                double[,] test = Matrix_X_Matrix(cback, rotate);
                double[,] res = Matrix_X_Matrix(test, p1_0);

                double[] Point1_Before = { x1, y1, 1 };
                double[] Point2_Before = { x2, y2, 1 };

                double[] Point1_AfterRotate = mat_X_mat(res, Point1_Before);
                double[] Point2_AfterRotate = mat_X_mat(res, Point2_Before);

                DDA((int)Point1_AfterRotate[0], (int)Point1_AfterRotate[1], (int)Point2_AfterRotate [0], (int)Point2_AfterRotate[1]);

                x1 = (int)Point1_AfterRotate[0];
                y1 = (int)Point1_AfterRotate[1];
                x2 = (int)Point2_AfterRotate[0];
                y2 = (int)Point2_AfterRotate[1];


                //double ang = double.Parse(txt9.Text);
                //double s1 = Math.Cos((ang * Math.PI) / 180);
                //double s2 = Math.Sin((ang * Math.PI) / 180);
                //int x1 = int.Parse(txt1.Text);
                //int y1 = int.Parse(txt2.Text);
                //int x2 = int.Parse(txt3.Text);
                //int y2 = int.Parse(txt4.Text);
                //double c1 = (int)Math.Round((x1 * s1) - (y1 * s2));
                //double c2 = (int)Math.Round((y1 * s1) + (x1 * s2));
                //double c3 = (int)Math.Round((x2 * s1) - (y2 * s2));
                //double c4 = (int)Math.Round((y2 * s1) + (x2 * s2));
                //DDA((int)c1, (int)c2, (int)c3, (int)c4);
            }
            catch
            {
                string message = " Some information missed\n Or input another values for x-axis and y-axis ";
                MessageBox.Show(message);
            }
        }

        private void Scale_btn_Click(object sender, EventArgs e)
        {
            try
            {
                 x1 = int.Parse(txt1.Text);
                 y1 = int.Parse(txt2.Text);
                 x2 = int.Parse(txt3.Text);
                 y2 = int.Parse(txt4.Text);
                int SX = int.Parse(txt7.Text);
                int SY = int.Parse(txt8.Text);
                x1 *= SX;
                y1 *= SY;
                x2 *= SX;
                y2 *= SY;
                DDA(x1, y1, x2, y2);
            }
            catch
            {
                string message = " Some information missed\n Or input another values for x-axis and y-axis ";
                MessageBox.Show(message);
            }
        }
        public void D_window(int X1, int Y1, int X2, int Y2, int Xmin, int Ymin, int Xmax, int Ymax)
        {
            Bitmap img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(img);
            g.DrawRectangle(Pens.White, Xmin, Ymin, Xmax, Ymax);
            int dx = X2 - X1;
            int dy = Y2 - Y1;
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
            float s = steps;
            float xi = dx / s;
            float yi = dy / s;
            float x = X1;
            float y = Y1;
            img.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.White);
            for (int i = 0; i < steps; i++)
            {
                x = x + xi;
                y = y + yi;
                img.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.White);
            }
            pictureBox1.Image = img;
        }
        public int Chick(int x, int y, int xmin, int ymin, int xmax, int ymax)
        { 
            int inside = 0;   // 0000
            int top = 8;     // 1000
            int bottom = 4;   // 0100
            int right = 2;    // 0010
            int left = 1;  // 0001
            int code = inside;
            if (x < xmin)
            {
                code |= left;
            }
            else if (x > xmax)
            {
                code |= right;
            }
            if (y < ymin)
            {
                code |= bottom;
            }
            else if (y > ymax)
            {
                code |= top;
            }
            return code;
        }
       
        private void Clipping_btn_Click(object sender, EventArgs e)
        {
            try {
                int x1 = int.Parse(txt1.Text);
                int y1 = int.Parse(txt2.Text);
                int x2 = int.Parse(txt3.Text);
                int y2 = int.Parse(txt4.Text);
                int xmin = int.Parse(txt10.Text);
                int ymin = int.Parse(txt11.Text);
                int xmax = int.Parse(txt12.Text);
                int ymax = int.Parse(txt13.Text);
                int inside = 0;
                int top = 8;
                int bottom = 4;
                int right = 2;
                int left = 1;
                int code1 = Chick(x1, y1, xmin, ymin, xmax, ymax);
                int code2 = Chick(x2, y2, xmin, ymin, xmax, ymax);
                int codeout;
                double d = ((y2 - y1) / (x2 - x1));

                while (true)
                {  
                    if ((code1 == inside) && (code2 == inside))
                    {
                        D_window(x1, y1, x2, y2, xmin, ymin, xmax, ymax);
                        break;
                    }
                    else if((code1 != inside) && (code2 != inside))
                    {
                        var nextForm = new Form4();
                        nextForm.Show();
                        break;
                    }
                    else 
                    {
                        double x = 0, y = 0;
                        if (code1 == inside)
                        {
                            codeout = code2;
                        }
                        else
                            codeout = code1;

                        if ((codeout & top) != 0)
                        {

                            x = x1 + (ymax - y1) / d;
                            y = ymax;                           
                        }
                        else if ((codeout & bottom) != 0)
                        {
                            x = x1 + (ymin - y1) / d;
                            y = ymin;
                        }
                        else if ((codeout & right) != 0)
                        {
                            y = y1 + d * (xmax - x1);
                            x = xmax;
                        }
                        else if ((codeout & left) != 0)
                        {
                            y = y1 + d * (xmin - x1);
                            x = xmin;
                        }
                        if (codeout == code1)
                        {
                            x1 = (int)x;
                            y1 = (int)y;
                            code1 = Chick(x1, y1, xmin, ymin, xmax, ymax);
                        }
                        else if (codeout == code2)
                        {
                            x2 = (int)x;
                            y2 = (int)y;
                            code2 = Chick(x2, y2, xmin, ymin, xmax, ymax);
                        }
                        D_window(x1, y1, x2, y2, xmin, ymin, xmax, ymax);
                    }
                   
                }
            }
            catch
            {
                string message =" Some information missed\n Or input another values for x-axis and y-axis ";
                MessageBox.Show(message);
            }
        }
    

        private void Reflection_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int temp;
                int temp2;
                int x1 = int.Parse(txt1.Text);
                int y1 = int.Parse(txt2.Text);
                int x2 = int.Parse(txt3.Text);
                int y2 = int.Parse(txt4.Text);
                temp = x1;
                x1 = y2;
                temp2 = x2;
                x2 = y1;
                y1 = temp2;
                y2 = temp;
                DDA(x1, y1, x2, y2);
            }
            catch
            {
                string message = " Some information missed\n Or input another values for x-axis and y-axis ";
                MessageBox.Show(message);
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int xc = int.Parse(txt1.Text);
                int yc = int.Parse(txt2.Text);
                int r = int.Parse(txt14.Text);
                int tx = Int32.Parse(txt5.Text);
                int ty = Int32.Parse(txt6.Text);
                int TX = xc + tx;
                int TY = yc + ty;
                Circle(TX, TY, r);
            }
            catch
            {
                string message =" Some information missed\n Or input another values for x-axis and y-axis ";
                MessageBox.Show(message);
            }
        }

        private void Ellipse_Translation_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txt1.Text);
                int y = int.Parse(txt2.Text);
                int RX = int.Parse(txt16.Text);
                int RY = int.Parse(txt17.Text);
                int tx = Int32.Parse(txt5.Text);
                int ty = Int32.Parse(txt6.Text);
                int TX = x + tx;
                int TY  = y + ty;
                Ellipse(TX, TY, RX, RY);
            }
            catch
            {
                string message = " Some information missed\n Or input another values for x-axis and y-axis ";
                MessageBox.Show(message);
            }
        }

        private void Circle_Rotation_btn_Click(object sender, EventArgs e)
        {
            try
            {
                double ang = double.Parse(txt9.Text);
                double s1 = Math.Cos((ang * Math.PI) / 180);
                double s2 = Math.Sin((ang * Math.PI) / 180);
                int xc = int.Parse(txt1.Text);
                int yc = int.Parse(txt2.Text);
                int r = int.Parse(txt14.Text);
                double c1 = (int)Math.Round((xc * s1) - (yc * s2));
                double c2 = (int)Math.Round((yc * s1) + (xc * s2));
                Circle((int)c1, (int)c2, r);
            }
            catch
            {
                string message = " Some information missed\n Or input another values for x-axis and y-axis ";
                MessageBox.Show(message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txt12_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //play show
            button1.Hide();
            pictureBox1.Show();
            txt1.Show();  label3.Show();
            txt2.Show();  label4.Show();
            txt3.Show();  label5.Show();
            txt4.Show();  label6.Show();
            txt10.Show(); label12.Show();
            txt11.Show(); label13.Show();
            txt12.Show(); label14.Show();
            txt13.Show(); label15.Show();
            txt5.Show();  label7.Show();
            txt6.Show();  label8.Show();
            txt7.Show();  label9.Show();
            txt8.Show();  label10.Show();
            txt15.Show(); label23.Show();
            txt9.Show();  label11.Show();
            txt16.Show(); label24.Show();
            txt17.Show(); label25.Show();
            txt14.Show(); label22.Show();
            DDA_btn.Show();  Bresenham_btn.Show();
            Ellipse_btn.Show();  Circle_btn.Show();
            label17.Show();  DDA_Translation_btn.Show();
            Circle_Translation_btn.Show();  Ellipse_Translation_btn.Show();
            label18.Show();  DDA_Rotation_btn.Show();
            Circle_Rotation_btn.Show();  Ellipse_Rotation_btn.Show();
            label19.Show();  DDA_Reflection_btn.Show();
            Circle_Reflection_btn.Show();  Ellipse_Reflection_btn.Show();
            label20.Show();  DDA_Scale_btn.Show();
            Circle_Scale_btn.Show();  Ellipse_Scale_btn.Show();
            label21.Show(); D_wind.Show();
            DDA_Clipping_btn.Show();
            button2.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void txt16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Ellipse_Rotation_btn_Click(object sender, EventArgs e)
        {
            try
            {

                double ang = double.Parse(txt9.Text);
                double s1 = Math.Cos((ang * Math.PI) / 180);
                double s2 = Math.Sin((ang * Math.PI) / 180);
                int xc = int.Parse(txt1.Text);
                int yc = int.Parse(txt2.Text);
                int rx = int.Parse(txt16.Text);
                int ry = int.Parse(txt17.Text);
                double c1 = (int)Math.Round((xc * s1) - (yc * s2));
                double c2 = (int)Math.Round((yc * s1) + (xc * s2));
                Ellipse((int)c1, (int)c2, rx, ry);
            }
            catch
            {
                string message = " Some information missed\n Or input another values for x-axis and y-axis ";
                MessageBox.Show(message);
            }
        }

        private void Circle_Scale_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txt1.Text);
                int y = int.Parse(txt2.Text);
                int r = int.Parse(txt14.Text);
                int SX = int.Parse(txt7.Text);
                int SY = int.Parse(txt8.Text);
                int SR = int.Parse(txt15.Text);
                int SX1 = x * SX;
                int SY1 = y * SY;
                int SR1 = r * SR;
                Circle(SX1, SY1, SR1);
            }
            catch
            {
                string message = " Some information missed\n Or input another values for x-axis and y-axis ";
                MessageBox.Show(message);
            }
        }

        private void Ellipse_Scale_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int xc = int.Parse(txt1.Text);
                int yc = int.Parse(txt2.Text);
                int rx = int.Parse(txt16.Text);
                int ry = int.Parse(txt17.Text);
                int SX = int.Parse(txt7.Text);
                int SY = int.Parse(txt8.Text);
                int SR = int.Parse(txt15.Text);
                int SX1 = xc * SX;
                int SY1 = yc * SY;
                int SR1 = rx * SR;
                int SR2 = ry * SR;
                Ellipse(SX1, SY1, SR1, SR2); 
            }
            catch
            {
                string message = " Some information missed\n Or input another values for x-axis and y-axis ";
                MessageBox.Show(message);
            }
        }

        private void Circle_Reflection_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txt1.Text);
                int y = int.Parse(txt2.Text);
                int r = int.Parse(txt14.Text);
                int temp;
                temp = x;
                x = y;
                y = temp;
                Circle(x, y, r);
            }
            catch
            {
                string message = " Some information missed\n Or input another values for x-axis and y-axis ";
                MessageBox.Show(message);
            }
        }

        private void Ellipse_Reflection_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int xc = int.Parse(txt1.Text);
                int yc = int.Parse(txt2.Text);
                int rx = int.Parse(txt16.Text);
                int ry = int.Parse(txt17.Text);
                int temp;
                temp = xc;
                xc = yc;
                yc = temp;
                Ellipse(xc, yc, rx, ry);
            }
            catch
            {
                string message = " Some information missed\n Or input another values for x-axis and y-axis ";
                MessageBox.Show(message);
            }
        }

        private void D_wind_Click(object sender, EventArgs e)
        {
            try{
            int x1 = int.Parse(txt1.Text);
            int y1 = int.Parse(txt2.Text);
            int x2 = int.Parse(txt3.Text);
            int y2 = int.Parse(txt4.Text);
            int xmin = int.Parse(txt10.Text);
            int ymin = int.Parse(txt11.Text);
            int xmax = int.Parse(txt12.Text);
            int ymax = int.Parse(txt13.Text);
            D_window(x1, y1, x2, y2, xmin, ymin, xmax, ymax);
            }
            catch
            {
                string message = " Some information missed\n Or input another values for x-axis and y-axis ";
                MessageBox.Show(message);
            }
        }
    }
}
