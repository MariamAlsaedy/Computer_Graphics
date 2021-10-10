
namespace Computer_Graphics_Project
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.Circle_btn = new System.Windows.Forms.Button();
            this.Ellipse_btn = new System.Windows.Forms.Button();
            this.Bresenham_btn = new System.Windows.Forms.Button();
            this.txt17 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txt14 = new System.Windows.Forms.TextBox();
            this.txt16 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.DDA_btn = new System.Windows.Forms.Button();
            this.warning = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("BeautyRains", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(35)))), ((int)(((byte)(21)))));
            this.button1.Location = new System.Drawing.Point(160, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Let\'s Make Changes\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Circle_btn
            // 
            this.Circle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Circle_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Circle_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(35)))), ((int)(((byte)(21)))));
            this.Circle_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Circle_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Circle_btn.Location = new System.Drawing.Point(187, 70);
            this.Circle_btn.Name = "Circle_btn";
            this.Circle_btn.Size = new System.Drawing.Size(91, 28);
            this.Circle_btn.TabIndex = 9;
            this.Circle_btn.Text = "Circle";
            this.Circle_btn.UseVisualStyleBackColor = true;
            this.Circle_btn.Click += new System.EventHandler(this.Circle_btn_Click);
            // 
            // Ellipse_btn
            // 
            this.Ellipse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ellipse_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ellipse_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(35)))), ((int)(((byte)(21)))));
            this.Ellipse_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Ellipse_btn.Location = new System.Drawing.Point(85, 70);
            this.Ellipse_btn.Name = "Ellipse_btn";
            this.Ellipse_btn.Size = new System.Drawing.Size(91, 28);
            this.Ellipse_btn.TabIndex = 8;
            this.Ellipse_btn.Text = "Ellipse";
            this.Ellipse_btn.UseVisualStyleBackColor = true;
            this.Ellipse_btn.Click += new System.EventHandler(this.Ellipse_btn_Click);
            // 
            // Bresenham_btn
            // 
            this.Bresenham_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bresenham_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bresenham_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(35)))), ((int)(((byte)(21)))));
            this.Bresenham_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Bresenham_btn.Location = new System.Drawing.Point(187, 33);
            this.Bresenham_btn.Name = "Bresenham_btn";
            this.Bresenham_btn.Size = new System.Drawing.Size(91, 28);
            this.Bresenham_btn.TabIndex = 7;
            this.Bresenham_btn.Text = "Bresenham\'s \r";
            this.Bresenham_btn.UseVisualStyleBackColor = true;
            this.Bresenham_btn.Click += new System.EventHandler(this.Bresenham_btn_Click);
            // 
            // txt17
            // 
            this.txt17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(176)))));
            this.txt17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt17.Location = new System.Drawing.Point(312, 108);
            this.txt17.Name = "txt17";
            this.txt17.Size = new System.Drawing.Size(31, 20);
            this.txt17.TabIndex = 46;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(176)))));
            this.label25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(35)))), ((int)(((byte)(21)))));
            this.label25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label25.Location = new System.Drawing.Point(287, 112);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(22, 13);
            this.label25.TabIndex = 47;
            this.label25.Text = "RY";
            // 
            // txt14
            // 
            this.txt14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(176)))));
            this.txt14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt14.Location = new System.Drawing.Point(378, 108);
            this.txt14.Name = "txt14";
            this.txt14.Size = new System.Drawing.Size(31, 20);
            this.txt14.TabIndex = 42;
            // 
            // txt16
            // 
            this.txt16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(176)))));
            this.txt16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt16.Location = new System.Drawing.Point(248, 108);
            this.txt16.Name = "txt16";
            this.txt16.Size = new System.Drawing.Size(31, 20);
            this.txt16.TabIndex = 44;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(176)))));
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(35)))), ((int)(((byte)(21)))));
            this.label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label22.Location = new System.Drawing.Point(353, 112);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 13);
            this.label22.TabIndex = 43;
            this.label22.Text = "RC";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(176)))));
            this.label24.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(35)))), ((int)(((byte)(21)))));
            this.label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label24.Location = new System.Drawing.Point(223, 112);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(22, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "RX";
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(176)))));
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2.Location = new System.Drawing.Point(378, 37);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(31, 20);
            this.txt2.TabIndex = 35;
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(176)))));
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt1.Location = new System.Drawing.Point(312, 37);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(31, 20);
            this.txt1.TabIndex = 34;
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(176)))));
            this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt3.Location = new System.Drawing.Point(312, 74);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(31, 20);
            this.txt3.TabIndex = 36;
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(176)))));
            this.txt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt4.Location = new System.Drawing.Point(378, 74);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(31, 20);
            this.txt4.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(176)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(35)))), ((int)(((byte)(21)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(354, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Y2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(176)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(35)))), ((int)(((byte)(21)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(288, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "X1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(176)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(35)))), ((int)(((byte)(21)))));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(288, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "X2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(194)))), ((int)(((byte)(176)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(35)))), ((int)(((byte)(21)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(354, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Y1";
            // 
            // picBox2
            // 
            this.picBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox2.BackgroundImage")));
            this.picBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picBox2.InitialImage = null;
            this.picBox2.Location = new System.Drawing.Point(28, 159);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(446, 281);
            this.picBox2.TabIndex = 48;
            this.picBox2.TabStop = false;
            // 
            // DDA_btn
            // 
            this.DDA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DDA_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DDA_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(35)))), ((int)(((byte)(21)))));
            this.DDA_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DDA_btn.Location = new System.Drawing.Point(86, 33);
            this.DDA_btn.Name = "DDA_btn";
            this.DDA_btn.Size = new System.Drawing.Size(91, 28);
            this.DDA_btn.TabIndex = 6;
            this.DDA_btn.Text = "DDA";
            this.DDA_btn.UseVisualStyleBackColor = true;
            this.DDA_btn.Click += new System.EventHandler(this.DDA_btn_Click);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.BackColor = System.Drawing.Color.Transparent;
            this.warning.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.warning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(53)))), ((int)(((byte)(48)))));
            this.warning.Location = new System.Drawing.Point(80, 105);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(137, 26);
            this.warning.TabIndex = 49;
            this.warning.Text = "Oops try another value\r\n for X-axis or Y-axis !!";
            this.warning.Visible = false;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(194)))), ((int)(((byte)(134)))));
            this.picBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picBox.InitialImage = null;
            this.picBox.Location = new System.Drawing.Point(101, 202);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(294, 190);
            this.picBox.TabIndex = 50;
            this.picBox.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.txt17);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txt14);
            this.Controls.Add(this.txt16);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Circle_btn);
            this.Controls.Add(this.Ellipse_btn);
            this.Controls.Add(this.Bresenham_btn);
            this.Controls.Add(this.DDA_btn);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Circle_btn;
        private System.Windows.Forms.Button Ellipse_btn;
        private System.Windows.Forms.Button Bresenham_btn;
        private System.Windows.Forms.TextBox txt17;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt14;
        private System.Windows.Forms.TextBox txt16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Button DDA_btn;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.PictureBox picBox;
    }
}