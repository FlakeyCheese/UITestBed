
namespace UITestBed
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(30, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(254, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 50);
            this.button4.TabIndex = 2;
            this.button4.Text = "Start";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(441, 374);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 50);
            this.button5.TabIndex = 2;
            this.button5.Text = "Stop";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(343, 430);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 50);
            this.button6.TabIndex = 2;
            this.button6.Text = "Reset";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(872, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "A";
            this.label3.DragDrop += new System.Windows.Forms.DragEventHandler(this.Common_dragDrop);
            this.label3.DragEnter += new System.Windows.Forms.DragEventHandler(this.Common_dragEnter);
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Common_mouseDown);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(1021, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 39);
            this.label4.TabIndex = 4;
            this.label4.DragDrop += new System.Windows.Forms.DragEventHandler(this.Common_dragDrop);
            this.label4.DragEnter += new System.Windows.Forms.DragEventHandler(this.Common_dragEnter);
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Common_mouseDown);
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(1021, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 39);
            this.label5.TabIndex = 4;
            this.label5.DragDrop += new System.Windows.Forms.DragEventHandler(this.Common_dragDrop);
            this.label5.DragEnter += new System.Windows.Forms.DragEventHandler(this.Common_dragEnter);
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Common_mouseDown);
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(1021, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 39);
            this.label6.TabIndex = 4;
            this.label6.DragDrop += new System.Windows.Forms.DragEventHandler(this.Common_dragDrop);
            this.label6.DragEnter += new System.Windows.Forms.DragEventHandler(this.Common_dragEnter);
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Common_mouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(822, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 44);
            this.textBox1.TabIndex = 5;
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Com_MouseDown);
            this.textBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Com_MouseMove);
            this.textBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Com_MouseUp);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(822, 347);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 44);
            this.textBox2.TabIndex = 5;
            this.textBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Com_MouseDown);
            this.textBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Com_MouseMove);
            this.textBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Com_MouseUp);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(928, 283);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 44);
            this.textBox3.TabIndex = 5;
            this.textBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Com_MouseDown);
            this.textBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Com_MouseMove);
            this.textBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Com_MouseUp);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(928, 347);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 44);
            this.textBox4.TabIndex = 5;
            this.textBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Com_MouseDown);
            this.textBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Com_MouseMove);
            this.textBox4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Com_MouseUp);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(602, 73);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(143, 40);
            this.textBox5.TabIndex = 6;
            this.textBox5.MouseEnter += new System.EventHandler(this.textBox5_MouseEnter);
            this.textBox5.MouseLeave += new System.EventHandler(this.textBox5_MouseLeave);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button7.Location = new System.Drawing.Point(12, 433);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(166, 57);
            this.button7.TabIndex = 7;
            this.button7.Text = "Click";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseEnter += new System.EventHandler(this.button7_MouseEnter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(820, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 37);
            this.label7.TabIndex = 8;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(820, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 37);
            this.label8.TabIndex = 8;
            this.label8.Text = "Y";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(30, 224);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(20, 20);
            this.button8.TabIndex = 9;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 515);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 37);
            this.label9.TabIndex = 10;
            this.label9.Text = "Score:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 515);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 37);
            this.label10.TabIndex = 10;
            this.label10.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 561);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

