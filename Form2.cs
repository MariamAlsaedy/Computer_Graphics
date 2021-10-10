using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Computer_Graphics_Project
{
    public partial class Form2 : Form
    {
        public Point MouseLocation;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
            //GraphicsPath g = new GraphicsPath();
            //g.AddEllipse(5,5,350,350);

            //Region r = new Region(g);
            //this.Region = r;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var nextForm = new Form3();
            nextForm.Show();
            this.Hide();
            nextForm.Closed += (s, args) => this.Close();
            nextForm.Show();
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

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
