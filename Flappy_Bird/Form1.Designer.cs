namespace Flappy_Bird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_newgame = new Button();
            SuspendLayout();
            // 
            // bt_newgame
            // 
            bt_newgame.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_newgame.AutoSize = true;
            bt_newgame.Location = new Point(321, 270);
            bt_newgame.Name = "bt_newgame";
            bt_newgame.Size = new Size(223, 74);
            bt_newgame.TabIndex = 0;
            bt_newgame.UseVisualStyleBackColor = true;
            bt_newgame.Click += bt_newgame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_newgame);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_newgame;
    }
}