using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITestBed
{
   
    public partial class Form1 : Form
    {
        private Control activeControl;
        private Point previousLocation;
        Random rnd = new Random();
        int curX =0;
        int curY = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor==Color.White)
            { button1.BackColor = Color.Red;
                button1.Text = "!";
            }
            else
            { button1.BackColor = Color.White;
                button1.Text = "?";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int score = Int32.Parse(label1.Text);
            score--;
            label1.Text = score.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int score = Int32.Parse(label1.Text);
            score++;
            label1.Text = score.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int count = Int32.Parse(label2.Text);
                count++;
            label2.Text = count.ToString(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
        }

        private void Common_dragDrop(object sender, DragEventArgs e)
        {
            Label lbl = sender as Label;
            lbl.Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void Common_dragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            { e.Effect = DragDropEffects.Copy; }
        }

        private void Common_mouseDown(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            if (e.Button == MouseButtons.Left)
            {
                //invoke the drag and drop operation
                DoDragDrop(lbl.Text, DragDropEffects.Copy);
                lbl.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox[] boxes = new PictureBox[4];
            int boxX = 200;
            int boxY = 200;
            for (int i = 0; i < 4; i++)
            {
                boxes[i] = new PictureBox
                  {
                     Size = new Size(100,100),
                     Location = new Point(boxX,boxY),
                     BorderStyle =BorderStyle.FixedSingle,
                     BackColor = Color.LightGreen,
                     SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    this.Controls.Add(boxes[i]);
                boxX = boxX + 120;
            }

           
           

        }

       

        private void Com_MouseDown(object sender, MouseEventArgs e)
        {
            activeControl = sender as Control;
            previousLocation = e.Location;
            Cursor = Cursors.Hand;
        }

        private void Com_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeControl == null || activeControl != sender)
                return;

            var location = activeControl.Location;
            location.Offset(e.Location.X - previousLocation.X, e.Location.Y - previousLocation.Y);
            activeControl.Location = location;
        }

        private void Com_MouseUp(object sender, MouseEventArgs e)
        {
            activeControl = null;
            Cursor = Cursors.Default;
        }

        private void textBox5_MouseEnter(object sender, EventArgs e)
        {
            textBox5.Size = new Size(200, 40);
            
        }

        private void textBox5_MouseLeave(object sender, EventArgs e)
        {
            textBox5.Size = new Size(150, 40);
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            
            int buttonX = rnd.Next(0, 1000);
            int buttonY = rnd.Next(0, 500);
            button7.Location = new Point(buttonX, buttonY);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label7.Text = Cursor.Position.X.ToString();
            label8.Text = Cursor.Position.Y.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            curX = Cursor.Position.X-10;
            curY = Cursor.Position.Y-130;
            //MessageBox.Show(curY.ToString());
            
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int buttonX = button8.Location.X;
            int buttonY = button8.Location.Y;
            if (buttonX > curX)
            { buttonX = buttonX - 1; }
            else if (buttonX < curX)
            { buttonX = buttonX + 1; }

            if (buttonY > curY)
            { buttonY = buttonY - 1; }
            else if (buttonY < curY)
            { buttonY = buttonY + 1; }
            button8.Location = new Point(buttonX, buttonY);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You caught me!");
            int score = Int32.Parse(label10.Text);
            score++;
            label10.Text = score.ToString();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Create Bitmap object
            //Bitmap bitmap = new Bitmap(1000, 800, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            // Create and initialize Graphics
            // Graphics g = Graphics.FromImage(bitmap);
            //GraphicsExtensions g = new GraphicsExtensions();

            //draw a circle at 1300, 350
            //g.DrawCircle(Pens.Black, 100, 100, 100);
            //g.DrawEllipse(Pens.Black, 100, 100, 100, 100);
        }
    }
}
