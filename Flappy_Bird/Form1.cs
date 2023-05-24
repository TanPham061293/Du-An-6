using System.Media;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int w;
        int h;
        SoundPlayer nhac_newgame = new SoundPlayer("flappy_bird\\nhac\\Nhay_Cung_ZinZin.wav");
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("flappy_bird\\anh_nen.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            w = this.Size.Width / 3;
            h = this.Size.Height / 3;
            nhac_newgame.Play();
            bt_newgame.Location = new Point(321, 290);
            bt_newgame.BackgroundImage = Image.FromFile("flappy_bird\\3.jpg");
            bt_newgame.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                w = this.Size.Width / 2;
                h = this.Size.Height / 3;
                bt_newgame.Location = new Point(w - 60, h * 2);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                bt_newgame.Location = new Point(321, 290);
            }
        }

        private void bt_newgame_Click(object sender, EventArgs e)
        {
            Play_Game frm2 = new Play_Game();
            nhac_newgame.Stop();
            frm2.ShowDialog();
        }
    }
}