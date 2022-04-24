using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShootingMonster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_GameOver.Hide();
            btn_restart.Hide();
        }
        bool right, left, space;
        int score;

        void Game_Result()
        {
            foreach (Control j in this.Controls)
            {
                foreach (Control i in this.Controls)
                {
                    if (j is PictureBox && j.Tag == "bullet")
                    {
                        if (i is PictureBox && i.Tag == "enemy")
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {
                                i.Top = -100;
                                score++;
                                lbl_Score.Text = "score: "+score;
                            }
                        }
                    }
                }
            }
            //Game Over
            if (player.Bounds.IntersectsWith(monster1.Bounds) || player.Bounds.IntersectsWith(monster2.Bounds) || player.Bounds.IntersectsWith(monster3.Bounds))
            {
                timer1.Stop();
                lbl_GameOver.Show();
                btn_restart.Show();
               
            }
        }

        
        //Bullet add into the player movement  
        void Add_Bullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet.Image = Properties.Resources.bullet_img2;
            bullet.BackColor = System.Drawing.Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Left = player.Left + 15;
            bullet.Top = player.Top - 30;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        //Bullet Movement
        void Bullet_Movement()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "bullet")
                {
                    x.Top -= 10;
                    if (x.Top < 100)
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }

        //Movement of player
        void Arrow_key_Movement()
        {
            if (right == true)
            {
                if (player.Left < 425)
                {
                    player.Left += 20;
                }
            }
            if (left == true)
            {
                if (player.Left > 10)
                {
                    player.Left -= 20;
                }
            }
        }

        //Movement of Monster
        void Enemy_Movement()
        {
            Random rnd = new Random();
            int x, y,z;
            //Monster 1
            if (monster1.Top >= 500)
            {
                x = rnd.Next(0, 300);
                monster1.Location = new Point(x, 0);
            }
            //Monster 2
            if (monster2.Top >= 500)
            {
                y = rnd.Next(0, 300);
                monster2.Location = new Point(y, 0);
            }
            //Monster 3
            if (monster3.Top >= 500) 
            {
                z = rnd.Next(0, 300);
                monster3.Location = new Point(z,0);
            }
            else
            {
                monster1.Top += 15;
                monster2.Top += 18;
                monster3.Top += 10;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = true;
                Add_Bullet();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Arrow_key_Movement();
            Enemy_Movement();
            Bullet_Movement();
            Game_Result();
        }

        //Restart Game
        private void btn_restart_Click(object sender, EventArgs e)
        {   
            Application.Restart();
        }
        
    }
}
