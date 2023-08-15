using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooting
{
    public partial class Form1 : Form
    {
        int speed = 15;

        public Form1()
        {
            InitializeComponent();
            lbl_Over.Hide();
        }

        private void enemy() // функция перемещения врага
        {
            Random rand = new Random();
            int enemy_1, enemy_2, enemy_3, enemy_4;

            if (e_1.Top >= 500)
            {
                enemy_1 = rand.Next(0, 300);
                e_1.Location = new Point(enemy_1, 0);
            }
            if (e_2.Top >= 500)
            {
                enemy_2 = rand.Next(0, 300);
                e_2.Location = new Point(enemy_2, 0);
            }
            if (e_3.Top >= 500)
            {
                enemy_3 = rand.Next(0, 300);
                e_3.Location = new Point(enemy_3, 0);
            }
            if (e_4.Top >= 500)
            {
                enemy_4 = rand.Next(0, 300);
                e_4.Location = new Point(enemy_4, 0);
            }
            else
            {
                e_1.Top += 2;
                e_2.Top += 3;
                e_3.Top += 4;
                e_4.Top += 5;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) //перемещение влево
            {
                if (player.Left > 5)
                {
                    player.Left -= 15;
                }
            }
            if (e.KeyCode == Keys.Right) //перемещение вправо
            {
                if (player.Left < 291)
                {
                    player.Left += 15;
                }
            }
        }

        //конец игры
        private void game_over()
        {
            if (e_1.Bounds.IntersectsWith(player.Bounds) || e_2.Bounds.IntersectsWith(player.Bounds) || e_3.Bounds.IntersectsWith(player.Bounds) || e_4.Bounds.IntersectsWith(player.Bounds)) //здесь мы используем метод коллизии
            {
                timer1.Stop(); //останавливаем таймер
                lbl_Over.Show(); //вызываем надпись Game-Over через метод Show
            }
        }

        private void Bullet() //функция выстрела 
        {
            bullet.Top -= speed;
            if (bullet.Top < 0)
            {
                speed = 20;
                bullet.Left = player.Left + 45;
                bullet.Top = player.Top;
            }
        }

        int score = 0; //счёт
        private void timer1_Tick(object sender, EventArgs e)
        {
            enemy();
            game_over();
            Bullet();

            //создадим функция для подсчёта очков
            if (e_1.Bounds.IntersectsWith(bullet.Bounds))
            {
                e_1.Top = 500;
                score += 5;
                lbl_score.Text = "Счёт : " + score;
            }
            if (e_2.Bounds.IntersectsWith(bullet.Bounds))
            {
                e_2.Top = 500;
                score += 5;
                lbl_score.Text = "Счёт : " + score;
            }
            if (e_3.Bounds.IntersectsWith(bullet.Bounds))
            {
                e_3.Top = 500;
                score += 5;
                lbl_score.Text = "Счёт : " + score;
            }
            if (e_4.Bounds.IntersectsWith(bullet.Bounds))
            {
                e_4.Top = 500;
                score += 5;
                lbl_score.Text = "Счёт : " + score;
            }
        }
    }
}
