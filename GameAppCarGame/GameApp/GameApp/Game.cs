using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int score = 0;
        Random random = new Random();
        private void gameOver()
        {

            End.Visible = true;
            restart.Enabled = true;
            restart.Visible = true;
            tick.Stop();
            Entimer1.Stop();
            etimer2.Stop();
            etimer3.Stop();
            etimer4.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if e.KeyCode=Keys
        }

        private void MouseUP(object sender, MouseEventArgs e)
        {

        }

        private void UP(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode ==Keys.Up)
            //{
            //    Box.Top -= 5;
            //}
        }

        private void DownMovement(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                if (e.KeyCode == Keys.Up)
                {
                    if (Box.Location.X < 1)
                        Box.Top -= 5;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (Box.Location.X > 360)
                        Box.Top += 5;
                }
                else if (e.KeyCode == Keys.Left)
                {
                    if (Box.Location.X > 1)
                        Box.Left -= 5;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    if (Box.Location.X < 390)
                        Box.Left += 5;
                }
            }


        }

        private void lr(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.Right))
            //{
            //    Box.Left += 5;
            //}




        }

        private void LEFT(object sender, KeyPressEventArgs e)
        {

        }

        private void LEFT(object sender, KeyEventArgs e)
        {

        }



        private void Right_Click(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int speed;
            speed = 3;
            //PictureBox[] road = new PictureBox[11];
            //road[0] = pictureBox1;
            //road[1] = pictureBox2;
            //road[2] = pictureBox3;
            //road[3] = pictureBox4;
            //road[4] = pictureBox5;
            //road[5] = pictureBox6;
            //road[6] = pictureBox7;
            //road[7] = pictureBox8;
            //road[8] = pictureBox9;
            //road[9] = pictureBox10;
            //road[10] = pictureBox11;
            //road[11] = pictureBox12;









        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void tick_Tick(object sender, EventArgs e)
        {

            //pictureBox1.Top += 2;
            //pictureBox2.Top += 2;
            //pictureBox3.Top += 2;
            //pictureBox4.Top += 2;
            //pictureBox5.Top += 2;
            //pictureBox6.Top += 2;
            //pictureBox7.Top += 2;
            //pictureBox8.Top += 2;
            //pictureBox9.Top += 2;
            //pictureBox10.Top += 2;
            //pictureBox11.Top += 2;
            //pictureBox12.Top += 2;
            PictureBox[] boxes =
                {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7,
                pictureBox8,
                pictureBox9,
                pictureBox10,
                pictureBox11,
                pictureBox12,

                };

            for (int i = 0; i < boxes.Length; i++)
            {
                boxes[i].Top += 8;
                if (boxes[i].Top >= this.Height)
                {

                    boxes[i].Top = -boxes[i].Height;
                }
                if (Box.Bounds.IntersectsWith(en1.Bounds))
                {
                    gameOver();
                }
                else if (Box.Bounds.IntersectsWith(en2.Bounds))
                {
                    gameOver();
                }
                else if (Box.Bounds.IntersectsWith(en3.Bounds))
                {
                    gameOver();
                }
                else if (Box.Bounds.IntersectsWith(en4.Bounds))
                {
                    gameOver();
                }
                else
                {

                }

            }







        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            en1.Top += 2;
            score += 1;
            Score.Text = "Score :" + score;
            if (en1.Top >= this.Height)
            {
                en1.Top = -en1.Height;
            }
        }

        private void etimer2_Tick(object sender, EventArgs e)
        {
            en2.Top += 3;
            score += 1;
            Score.Text = "Score :" + score;
            if (en2.Top >= this.Height)
            {
                en2.Top = -en2.Height;
            }

        }

        private void etimer3_Tick(object sender, EventArgs e)
        {
            en3.Top += 1;
            score += 1;
            Score.Text = "Score :" + score;
            if (en3.Top >= this.Height)
            {
                en3.Top = -en3.Height;
              // en3.Left = Convert.ToInt32(random.Next(0, 5))+10; 
            }


        }

        private void en4_Click(object sender, EventArgs e)
        {


        }

        private void etimer4_Tick(object sender, EventArgs e)
        {
            en4.Top += 2;
            score += 1;
            Score.Text = "Score :" + score;
            if (en4.Top >= this.Height)
            {
                en4.Top = -en1.Height;
            }
        }

        private void Right_Tick(object sender, EventArgs e)
        {

        }

        private void Up_Tick(object sender, EventArgs e)
        {

        }

        private void Down_Tick(object sender, EventArgs e)
        {

        }

        private void ReplayButton_Click(object sender, EventArgs e)
        {


            score = 0;
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 0;
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);


        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            /*/Form1 f1 = new Form1();
            f1.Refresh();*/
            //this.Controls.Clear();
            score = 0;
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void timePlayed_Click(object sender, EventArgs e)
        {
            timePlayed.Text = DateTime.Now.ToLongDateString();
        }

        private void en3_Click(object sender, EventArgs e)
        {

        }
    }
}
