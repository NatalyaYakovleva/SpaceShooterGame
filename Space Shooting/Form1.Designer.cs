namespace Space_Shooting
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.e_1 = new System.Windows.Forms.PictureBox();
            this.e_2 = new System.Windows.Forms.PictureBox();
            this.e_3 = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_Over = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.e_4 = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Space_Shooting.Properties.Resources._13;
            this.player.Location = new System.Drawing.Point(144, 357);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(94, 98);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // e_1
            // 
            this.e_1.BackColor = System.Drawing.Color.Transparent;
            this.e_1.Image = global::Space_Shooting.Properties.Resources._2__2_;
            this.e_1.Location = new System.Drawing.Point(26, 55);
            this.e_1.Name = "e_1";
            this.e_1.Size = new System.Drawing.Size(50, 50);
            this.e_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_1.TabIndex = 1;
            this.e_1.TabStop = false;
            // 
            // e_2
            // 
            this.e_2.BackColor = System.Drawing.Color.Transparent;
            this.e_2.Image = global::Space_Shooting.Properties.Resources.mothership_blue__2_;
            this.e_2.Location = new System.Drawing.Point(218, 12);
            this.e_2.Name = "e_2";
            this.e_2.Size = new System.Drawing.Size(50, 50);
            this.e_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_2.TabIndex = 2;
            this.e_2.TabStop = false;
            // 
            // e_3
            // 
            this.e_3.BackColor = System.Drawing.Color.Transparent;
            this.e_3.Image = global::Space_Shooting.Properties.Resources.aestroid_brown2;
            this.e_3.Location = new System.Drawing.Point(131, 73);
            this.e_3.Name = "e_3";
            this.e_3.Size = new System.Drawing.Size(55, 55);
            this.e_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_3.TabIndex = 3;
            this.e_3.TabStop = false;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_score.Location = new System.Drawing.Point(5, 6);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(97, 31);
            this.lbl_score.TabIndex = 4;
            this.lbl_score.Text = "Счёт : 0";
            // 
            // lbl_Over
            // 
            this.lbl_Over.AutoSize = true;
            this.lbl_Over.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Over.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Over.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Over.Location = new System.Drawing.Point(88, 222);
            this.lbl_Over.Name = "lbl_Over";
            this.lbl_Over.Size = new System.Drawing.Size(210, 40);
            this.lbl_Over.TabIndex = 5;
            this.lbl_Over.Text = "Game-Over";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // e_4
            // 
            this.e_4.BackColor = System.Drawing.Color.Transparent;
            this.e_4.Image = global::Space_Shooting.Properties.Resources.aestroid_gay_22;
            this.e_4.Location = new System.Drawing.Point(304, 40);
            this.e_4.Name = "e_4";
            this.e_4.Size = new System.Drawing.Size(50, 50);
            this.e_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_4.TabIndex = 6;
            this.e_4.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.Color.Transparent;
            this.bullet.Image = global::Space_Shooting.Properties.Resources.bullet1;
            this.bullet.Location = new System.Drawing.Point(186, 325);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(10, 35);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 7;
            this.bullet.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Space_Shooting.Properties.Resources.blue;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.e_4);
            this.Controls.Add(this.lbl_Over);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.e_3);
            this.Controls.Add(this.e_2);
            this.Controls.Add(this.e_1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bullet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Shooting Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox e_1;
        private System.Windows.Forms.PictureBox e_2;
        private System.Windows.Forms.PictureBox e_3;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_Over;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox e_4;
        private System.Windows.Forms.PictureBox bullet;
    }
}

