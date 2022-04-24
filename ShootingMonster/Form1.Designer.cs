namespace ShootingMonster
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_GameOver = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.monster3 = new System.Windows.Forms.PictureBox();
            this.monster2 = new System.Windows.Forms.PictureBox();
            this.monster1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.monster3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.BackColor = System.Drawing.Color.White;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(12, 9);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(92, 25);
            this.lbl_Score.TabIndex = 4;
            this.lbl_Score.Text = "Score: 0";
            // 
            // lbl_GameOver
            // 
            this.lbl_GameOver.AutoSize = true;
            this.lbl_GameOver.BackColor = System.Drawing.Color.Black;
            this.lbl_GameOver.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GameOver.ForeColor = System.Drawing.Color.Red;
            this.lbl_GameOver.Location = new System.Drawing.Point(161, 202);
            this.lbl_GameOver.Name = "lbl_GameOver";
            this.lbl_GameOver.Size = new System.Drawing.Size(147, 33);
            this.lbl_GameOver.TabIndex = 5;
            this.lbl_GameOver.Text = "Game-Over";
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.Transparent;
            this.btn_restart.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.ForeColor = System.Drawing.Color.Red;
            this.btn_restart.Location = new System.Drawing.Point(188, 248);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(82, 35);
            this.btn_restart.TabIndex = 6;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // monster3
            // 
            this.monster3.Image = global::ShootingMonster.Properties.Resources.monster1;
            this.monster3.Location = new System.Drawing.Point(366, 87);
            this.monster3.Name = "monster3";
            this.monster3.Size = new System.Drawing.Size(68, 56);
            this.monster3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monster3.TabIndex = 3;
            this.monster3.TabStop = false;
            this.monster3.Tag = "enemy";
            // 
            // monster2
            // 
            this.monster2.Image = global::ShootingMonster.Properties.Resources.monster2;
            this.monster2.Location = new System.Drawing.Point(217, 45);
            this.monster2.Name = "monster2";
            this.monster2.Size = new System.Drawing.Size(53, 47);
            this.monster2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monster2.TabIndex = 2;
            this.monster2.TabStop = false;
            this.monster2.Tag = "enemy";
            // 
            // monster1
            // 
            this.monster1.Image = global::ShootingMonster.Properties.Resources.monster4;
            this.monster1.Location = new System.Drawing.Point(60, 126);
            this.monster1.Name = "monster1";
            this.monster1.Size = new System.Drawing.Size(44, 47);
            this.monster1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monster1.TabIndex = 1;
            this.monster1.TabStop = false;
            this.monster1.Tag = "enemy";
            // 
            // player
            // 
            this.player.Image = global::ShootingMonster.Properties.Resources.spaceship;
            this.player.Location = new System.Drawing.Point(212, 411);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(48, 65);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Tag = "ship";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.lbl_GameOver);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.monster3);
            this.Controls.Add(this.monster2);
            this.Controls.Add(this.monster1);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.monster3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox monster1;
        private System.Windows.Forms.PictureBox monster2;
        private System.Windows.Forms.PictureBox monster3;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_GameOver;
        private System.Windows.Forms.Button btn_restart;
    }
}

