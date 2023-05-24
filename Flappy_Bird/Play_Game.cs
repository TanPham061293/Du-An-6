using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Media;

namespace Flappy_Bird
{
    public partial class Play_Game : Form
    {
        public Play_Game()
        {
            InitializeComponent();
        }

        int loacation_x_vatcan = 600;
        int location_y_vatcan;
        int height_vatcan;

        int location_x_bird = 80;
        int location_y_bird = 50;
        List<PictureBox> arr_vat_can1 = new List<PictureBox>();
        List<PictureBox> arr_vat_can2 = new List<PictureBox>();
        Random rd_location_y_vatcan = new Random();
        Random rd_height_vatcan = new Random();
        PictureBox vatcan = new PictureBox();

        SoundPlayer nhac_playgame = new SoundPlayer("flappy_bird\\nhac\\NhacGameBoomDuaXe1.wav");
        SoundPlayer nhac_vacham = new SoundPlayer("flappy_bird\\nhac\\bum.wav");
        private void Play_Game_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("flappy_bird\\anh_nen_trong_game.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Size = new Size(550, 350);

            ptb_Bird.BackgroundImage = Image.FromFile("flappy_bird\\bird2.png");
            ptb_Bird.BackgroundImageLayout = ImageLayout.Stretch;
            ptb_Bird.Location = new Point(location_x_bird, location_y_bird);
            ptb_Bird.Size = new Size(50, 30);

            ptb_vacham.BackgroundImage = Image.FromFile("flappy_bird\\xevacham.png");
            ptb_vacham.BackgroundImageLayout = ImageLayout.Stretch;
            ptb_vacham.Size = new Size(40, 30);
            ptb_vacham.Visible = false;

            lb_thoigian.Location = new Point(470, 0);
            bt_pause_play.Location = new Point(470, lb_thoigian.Size.Height + 10);

            pnel_conduong1.Size = new Size(1000, 4);
            pnel_conduong1.Location = new Point(0, 4);
            pnel_conduong1.BackColor = Color.Red;

            pnel_conduong3.Size = new Size(1000, 4);
            pnel_conduong3.Location = new Point(0, 300);
            pnel_conduong3.BackColor = Color.Red;


            height_vatcan = rd_height_vatcan.Next(50, 120);
            location_y_vatcan = rd_location_y_vatcan.Next(0, 3);
            if (location_y_vatcan != 0)
            {
                location_y_vatcan = 200 - height_vatcan;
            }

            vatcan.Location = new Point(loacation_x_vatcan, location_y_vatcan);
            vatcan.Size = new Size(100, height_vatcan);
            vatcan.BackgroundImage = Image.FromFile("flappy_bird\\vatcan.jpg");
            vatcan.BackgroundImageLayout = ImageLayout.Stretch;
            //vatcan.BringToFront();
            arr_vat_can1.Add(vatcan);
            nhac_playgame.Play();
            this.Controls.Add(vatcan);

            timer_ThoiGianChoi.Start();
            timer_random_vatcan.Start();
            timer_bird.Start();
            timer_conduong1.Start();
        }

        int gio = 0;
        int giay = 0;
        int phut = 0;
        int DichChuyen = 5;
        int thoigianquydoi = 0;
        private void timer_ThoiGianChoi_Tick(object sender, EventArgs e)
        {
            giay++;
            if (giay == 60)
            {
                phut++;
                giay = 0;
                if (phut == 60)
                {
                    gio++;
                    phut = 0;
                }
            }
            //lb_thoigian.Text = gio.ToString() + ":" + phut.ToString() + ":" + giay.ToString();
            lb_thoigian.Text = (gio < 10 ? "0" + gio.ToString() : gio.ToString()) + ":"
                + (phut < 10 ? "0" + phut.ToString() : phut.ToString()) + ":"
                + (giay < 10 ? "0" + giay.ToString() : giay.ToString());
            thoigianquydoi = giay + phut * 60 + gio * 3600;
            if (thoigianquydoi % 30 == 0 && thoigianquydoi != 0)
            {
                DichChuyen += 3;
            }
        }
        int giayrd = 1;
        private void timer_random_vatcan_Tick(object sender, EventArgs e)
        {
            giayrd++;
            timer_bird.Start();
            if (arr_vat_can1[arr_vat_can1.Count - 1].Location.X <= 360)
            {
                PictureBox vatcan2 = new PictureBox();
                location_y_vatcan = rd_location_y_vatcan.Next(0, 2);

                height_vatcan = rd_height_vatcan.Next(50, 130);
                if (location_y_vatcan > 0)
                {
                    location_y_vatcan = 100;
                }
                vatcan2.Location = new Point(loacation_x_vatcan, location_y_vatcan);
                vatcan2.Size = new Size(100, height_vatcan);
                vatcan2.BackgroundImage = Image.FromFile("flappy_bird\\vatcan.jpg");
                vatcan2.BackgroundImageLayout = ImageLayout.Stretch;
                arr_vat_can1.Add(vatcan2);
                this.Controls.Add(vatcan2);
            }
            if (giayrd % 30 == 0 && arr_vat_can1[arr_vat_can1.Count- 1].Location.Y == 0)
            {
                PictureBox vatcan2 = new PictureBox();
                height_vatcan = rd_height_vatcan.Next(50,300 - arr_vat_can1[arr_vat_can1.Count-1].Size.Height - 50);
                location_y_vatcan = 300 - height_vatcan;
                vatcan2.Location = new Point(loacation_x_vatcan, location_y_vatcan);
                vatcan2.Size = new Size(100, height_vatcan);
                vatcan2.BackgroundImage = Image.FromFile("flappy_bird\\vatcan.jpg");
                vatcan2.BackgroundImageLayout = ImageLayout.Stretch;
                arr_vat_can1.Add(vatcan2);
                this.Controls.Add(vatcan2);
            }
            if (arr_vat_can1[0].Location.X < -100)
            {
                arr_vat_can1.Remove(arr_vat_can1[0]);
            }
            if (giayrd == 60)
            {
                giayrd = 1;
            }
        }

        
        private void timer_conduong1_Tick(object sender, EventArgs e)
        {
            //loacation_x_vatcan -= 5;
            foreach (var item in arr_vat_can1)
            {
                int toado = item.Location.X;
                toado -= DichChuyen;
                item.Location = new Point(toado, item.Location.Y);
            }
        }
        private void vacham()
        {
            nhac_playgame.Stop();
            nhac_vacham.Play();
            timer_bird.Stop();
            timer_conduong1.Stop();
            timer_random_vatcan.Stop();
            timer_ThoiGianChoi.Stop();

            ptb_vacham.Location = new Point(ptb_Bird.Location.X + 20, ptb_Bird.Location.Y - 10);
            ptb_vacham.BringToFront();
            ptb_vacham.Visible = true;
            MessageBox.Show("game over.");
            nhac_vacham.Stop();
        }
        private void timer_bird_Tick(object sender, EventArgs e)
        {
            if (phut <= 2)
            {
                location_y_bird += 5;
            }
            else
            {
                location_y_bird += 8;
            }
            ptb_Bird.Location = new Point(location_x_bird, location_y_bird);
            if (location_y_bird <= 0)
            {
                nhac_playgame.Stop();
                nhac_vacham.Play();
                timer_bird.Stop();
                timer_conduong1.Stop();
                timer_random_vatcan.Stop();
                timer_ThoiGianChoi.Stop();

                ptb_vacham.Location = new Point(ptb_Bird.Location.X + 20, ptb_Bird.Location.Y - 10);
                ptb_vacham.BringToFront();
                ptb_vacham.Visible = true;
                MessageBox.Show("game over.");
                nhac_vacham.Stop();
            }
            else if (location_y_bird >= 270)
            {
                nhac_playgame.Stop();
                nhac_vacham.Play();
                timer_bird.Stop();
                timer_conduong1.Stop();
                timer_random_vatcan.Stop();
                timer_ThoiGianChoi.Stop();

                ptb_vacham.Location = new Point(ptb_Bird.Location.X + 20, ptb_Bird.Location.Y - 10);
                ptb_vacham.BringToFront();
                ptb_vacham.Visible = true;
                MessageBox.Show("game over.");
                nhac_vacham.Stop();
            }
            else
            {
                foreach (var item in arr_vat_can1)
                {
                    if (item.Location.X > ptb_Bird.Location.X)
                    {
                        if (item.Location.X - ptb_Bird.Location.X <= 50)
                        {
                            if (item.Location.Y > ptb_Bird.Location.Y)
                            {
                                if (item.Location.Y - ptb_Bird.Location.Y <= 30)
                                {
                                    vacham();
                                }
                            }
                            else
                            {
                                if (ptb_Bird.Location.Y - item.Location.Y <= item.Size.Height)
                                {
                                    vacham();
                                }
                            } 
                        }
                    }
                    else if (item.Location.X <= ptb_Bird.Location.X)
                    {
                        if (ptb_Bird.Location.X - item.Location.X <= 100)
                        {
                            if (item.Location.Y > ptb_Bird.Location.Y)
                            {
                                if (item.Location.Y - ptb_Bird.Location.Y <= 30)
                                {
                                    vacham();
                                }
                            }
                            else
                            {
                                if (ptb_Bird.Location.Y - item.Location.Y <= item.Size.Height)
                                {
                                    vacham();
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            
        }

        private void Play_Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                timer_bird.Stop();
                if (phut <= 2)
                {
                    location_y_bird -= 12;
                }
                else
                {
                    location_y_bird -= 15;
                }
               
                ptb_Bird.Location = new Point(location_x_bird, location_y_bird);
            }
        }

        private void Play_Game_Click(object sender, EventArgs e)
        {
            timer_bird.Stop();
            if (phut <= 2)
            {
                location_y_bird -= 12;
            }
            else
            {
                location_y_bird -= 15;
            }
            ptb_Bird.Location = new Point(location_x_bird, location_y_bird);
        }
        int dem = 0;
        private void bt_pause_play_Click(object sender, EventArgs e)
        {
            dem++;
            if (dem == 1)
            {
                bt_pause_play.Text = "Play.";
                timer_bird.Stop();
                timer_conduong1.Stop();
                timer_random_vatcan.Stop();
                timer_ThoiGianChoi.Stop();
            }
            else if (dem == 2)
            {
                bt_pause_play.Text = "Pause.";
                timer_bird.Start();
                timer_conduong1.Start();
                timer_random_vatcan.Start();
                timer_ThoiGianChoi.Start();
                dem = 0;
            }
        }
    }
}
