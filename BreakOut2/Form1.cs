using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BreakOut2
{
    public partial class Form1 : Form
    {
        bool ka = false, kd = false, kw = false, ks = false;
        int aSpeed = 1;
        int bSpeed = 1;
        int contscore = 0;
        int vidaball = 3;
        int contrevive = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timercursor.Start();
            timerball.Start();
            label2.Text = ball.Tag.ToString();
            label4.Text = contscore.ToString();
            label6.Text = contrevive.ToString();
            label6.Visible = false;
        }

        
        //-------------------------------------------------------------------------------------

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                ka = true;
                //cursor.Location = new Point(cursor.Location.X - 2, cursor.Location.Y);
            }

            if (e.KeyCode == Keys.D)
            {
                kd = true;
                //cursor.Location = new Point(cursor.Location.X + 2, cursor.Location.Y);
            }

            if (e.KeyCode == Keys.W)
            {
                kw = true;
            }

            if (e.KeyCode == Keys.S)
            {
                ks = true;
            }
        }
        //--------------------------------------------------------------------------------------

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                ka = false;
            }

            if (e.KeyCode == Keys.D)
            {
                kd = false;
            }

            if (e.KeyCode == Keys.W)
            {
                kw = false;
            }

            if (e.KeyCode == Keys.S)
            {
                ks = false;
            }
        }
        //------------------------------------------------------------------------------------------

        private void timercursorder_Tick(object sender, EventArgs e)
        {
            if (kd == true)
            {
                cursor.Location = new Point(cursor.Location.X + 5, cursor.Location.Y);
            }
        }
        //------------------------------------------------------------------------------------------

        private void timercursorizq_Tick(object sender, EventArgs e)
        {
            if (ka == true)
            {
                cursor.Location = new Point(cursor.Location.X -5, cursor.Location.Y);
            }
        }
        //---------------------------------------------------------------------------------------------

        private void timercursor_Tick(object sender, EventArgs e)
        {
            timercursorder.Start();
            timercursorizq.Start();
            if (cursor.Bounds.IntersectsWith(panel1.Bounds))
            {
                kw = false;
            }

            if (cursor.Bounds.IntersectsWith(panel2.Bounds))
            {
                ks = false;
            }

            if (kw == true)
            {
                cursor.Location = new Point(cursor.Location.X, cursor.Location.Y - 2);
            }

            if (ks == true)
            {
                cursor.Location = new Point(cursor.Location.X, cursor.Location.Y +2);
            }

            

            if (cursor.Right > this.ClientSize.Width)
            {
                timercursorder.Stop();
                timercursorizq.Start();
            }

            if (cursor.Left == 0)
            {
                timercursorizq.Stop();
                timercursorder.Start();
            }
            //if (cursor.Right > this.ClientSize.Width)
            //{
                //kd = false;
            //}

            //if (cursor.Left < 0)
            //{
                //ka = false;
            //}

            if (ball.Bounds.IntersectsWith(bloque1.Bounds))
            {
                if (bloque1.Visible == true)
                {
                    contscore += 99;
                    contscore++;
                    label4.Text = contscore.ToString();
                }

                bloque1.Visible = false;
            }

            if (ball.Bounds.IntersectsWith(bloque2.Bounds))
            {
                if (bloque2.Visible == true)
                {
                    contscore += 99;
                    contscore++;
                    label4.Text = contscore.ToString();
                }

                bloque2.Visible = false;               
            }

            if (ball.Bounds.IntersectsWith(bloque3.Bounds))
            {
                if (bloque3.Visible == true)
                {
                    contscore += 99;
                    contscore++;
                    label4.Text = contscore.ToString();
                }

                bloque3.Visible = false;                
            }

            if (contscore > 340)
            {
                timerball.Interval = 1;
            }

            if (contrevive == 0)
            {
               
                timerrevive.Stop();
                contrevive = 10;
                contscore = 0;
                label6.Visible = false;
                label4.Text = contscore.ToString();
                timerball.Start();
                ball.Location = new Point(258, 175);
                bloque1.Visible = true;
                bloque2.Visible = true;
                bloque3.Visible = true;
            }

            if (contscore == 400)
            {
                timercursor.Stop();
                timerball.Stop();

                Form3 f3 = new Form3 ();
                this.Hide();
                f3.Show();

            }

            
        }
        //---------------------------------------------------------------------------------------------

        private void timerball_Tick(object sender, EventArgs e)
        {
            ball.Top += aSpeed;
            ball.Left += bSpeed;

           
            if (ball.Bounds.IntersectsWith(cursor.Bounds))
            {
                aSpeed = -aSpeed;
                contscore += 20;
                label4.Text = contscore.ToString();

            }

            if (ball.Bounds.IntersectsWith(panel1.Bounds))
            {
                aSpeed = -aSpeed;
            }

            if (ball.Right > this.ClientSize.Width)
            {
                bSpeed = -bSpeed;
            }

            if (ball.Left < 0)
            {
                bSpeed = -bSpeed;
            }
            
            if (ball.Bounds.IntersectsWith(panel2.Bounds))
            {
                vidaball = Convert.ToInt32(ball.Tag);
                vidaball--;
                ball.Tag = vidaball.ToString();
                label2.Text = vidaball.ToString();
                timerball.Stop();
                timerrevive.Start();
            }
            if (bloque1.Visible == true)
            {
                if (ball.Bounds.IntersectsWith(bloque1.Bounds))
                {
                    bSpeed = -bSpeed;
                }
            }

            if (bloque2.Visible == true)
            {
                if (ball.Bounds.IntersectsWith(bloque2.Bounds))
                {
                    bSpeed = -bSpeed;
                }
            }

            if (bloque3.Visible == true)
            {
                if (ball.Bounds.IntersectsWith(bloque3.Bounds))
                {
                    bSpeed = -bSpeed;
                }

            }

            if (vidaball == 0)
            {
                timerball.Stop();
                timerrevive.Stop();
                MessageBox.Show("YOU LOSE");
            }

        }
        //------------------------------------------------------------------------

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }
        //-----------------------------------------------------------------------------------

        private void timerrevive_Tick(object sender, EventArgs e)
        {
            contrevive--;
            label6.Visible = true;
            label6.Text = contrevive.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerball.Stop();
            MessageBox.Show("SEE YOU LATER!!");
        }
    }
}
