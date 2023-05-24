namespace Flappy_Bird
{
    partial class Play_Game
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
            components = new System.ComponentModel.Container();
            pnel_conduong1 = new Panel();
            ptb_Bird = new PictureBox();
            timer_conduong1 = new System.Windows.Forms.Timer(components);
            timer_bird = new System.Windows.Forms.Timer(components);
            timer_random_vatcan = new System.Windows.Forms.Timer(components);
            timer_ThoiGianChoi = new System.Windows.Forms.Timer(components);
            lb_thoigian = new Label();
            bt_pause_play = new Button();
            pnel_conduong3 = new Panel();
            ptb_vacham = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptb_Bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_vacham).BeginInit();
            SuspendLayout();
            // 
            // pnel_conduong1
            // 
            pnel_conduong1.Location = new Point(66, 31);
            pnel_conduong1.Name = "pnel_conduong1";
            pnel_conduong1.Size = new Size(214, 100);
            pnel_conduong1.TabIndex = 0;
            // 
            // ptb_Bird
            // 
            ptb_Bird.BackColor = Color.FromArgb(128, 255, 255);
            ptb_Bird.Location = new Point(80, 253);
            ptb_Bird.Name = "ptb_Bird";
            ptb_Bird.Size = new Size(100, 50);
            ptb_Bird.TabIndex = 1;
            ptb_Bird.TabStop = false;
            // 
            // timer_conduong1
            // 
            timer_conduong1.Tick += timer_conduong1_Tick;
            // 
            // timer_bird
            // 
            timer_bird.Interval = 10;
            timer_bird.Tick += timer_bird_Tick;
            // 
            // timer_random_vatcan
            // 
            timer_random_vatcan.Interval = 10;
            timer_random_vatcan.Tick += timer_random_vatcan_Tick;
            // 
            // timer_ThoiGianChoi
            // 
            timer_ThoiGianChoi.Interval = 1000;
            timer_ThoiGianChoi.Tick += timer_ThoiGianChoi_Tick;
            // 
            // lb_thoigian
            // 
            lb_thoigian.AutoSize = true;
            lb_thoigian.Location = new Point(183, 257);
            lb_thoigian.Name = "lb_thoigian";
            lb_thoigian.Size = new Size(49, 15);
            lb_thoigian.TabIndex = 2;
            lb_thoigian.Text = "00:00:00";
            // 
            // bt_pause_play
            // 
            bt_pause_play.Location = new Point(183, 280);
            bt_pause_play.Name = "bt_pause_play";
            bt_pause_play.Size = new Size(75, 23);
            bt_pause_play.TabIndex = 3;
            bt_pause_play.Text = "Pause";
            bt_pause_play.UseVisualStyleBackColor = true;
            bt_pause_play.Click += bt_pause_play_Click;
            // 
            // pnel_conduong3
            // 
            pnel_conduong3.Location = new Point(66, 147);
            pnel_conduong3.Name = "pnel_conduong3";
            pnel_conduong3.Size = new Size(214, 100);
            pnel_conduong3.TabIndex = 0;
            // 
            // ptb_vacham
            // 
            ptb_vacham.Location = new Point(327, 34);
            ptb_vacham.Name = "ptb_vacham";
            ptb_vacham.Size = new Size(100, 50);
            ptb_vacham.TabIndex = 4;
            ptb_vacham.TabStop = false;
            // 
            // Play_Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ptb_vacham);
            Controls.Add(bt_pause_play);
            Controls.Add(lb_thoigian);
            Controls.Add(ptb_Bird);
            Controls.Add(pnel_conduong3);
            Controls.Add(pnel_conduong1);
            KeyPreview = true;
            Name = "Play_Game";
            Text = "Play_Game";
            Load += Play_Game_Load;
            Click += Play_Game_Click;
            KeyDown += Play_Game_KeyDown;
            ((System.ComponentModel.ISupportInitialize)ptb_Bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_vacham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnel_conduong1;
        private PictureBox ptb_Bird;
        private System.Windows.Forms.Timer timer_conduong1;
        private System.Windows.Forms.Timer timer_bird;
        private System.Windows.Forms.Timer timer_random_vatcan;
        private System.Windows.Forms.Timer timer_ThoiGianChoi;
        private Label lb_thoigian;
        private Button bt_pause_play;
        private Panel pnel_conduong3;
        private PictureBox ptb_vacham;
    }
}