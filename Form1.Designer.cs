
namespace SimpleGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_ShootAway = new System.Windows.Forms.Button();
            this.Btn_Shoot = new System.Windows.Forms.Button();
            this.Btn_Spin = new System.Windows.Forms.Button();
            this.Btn_load = new System.Windows.Forms.Button();
            this.Btn_PlayAgain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(310, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 71);
            this.label1.TabIndex = 12;
            this.label1.Text = "TERROR ROULETTE";
            // 
            // Btn_ShootAway
            // 
            this.Btn_ShootAway.BackColor = System.Drawing.Color.Coral;
            this.Btn_ShootAway.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ShootAway.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_ShootAway.Location = new System.Drawing.Point(1062, 436);
            this.Btn_ShootAway.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_ShootAway.Name = "Btn_ShootAway";
            this.Btn_ShootAway.Size = new System.Drawing.Size(224, 59);
            this.Btn_ShootAway.TabIndex = 10;
            this.Btn_ShootAway.Text = "Shoot Away";
            this.Btn_ShootAway.UseVisualStyleBackColor = false;
            this.Btn_ShootAway.Click += new System.EventHandler(this.Btn_ShootAway_Click);
            // 
            // Btn_Shoot
            // 
            this.Btn_Shoot.BackColor = System.Drawing.Color.Coral;
            this.Btn_Shoot.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Shoot.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_Shoot.Location = new System.Drawing.Point(1062, 137);
            this.Btn_Shoot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Shoot.Name = "Btn_Shoot";
            this.Btn_Shoot.Size = new System.Drawing.Size(224, 55);
            this.Btn_Shoot.TabIndex = 9;
            this.Btn_Shoot.Text = "Shoot";
            this.Btn_Shoot.UseVisualStyleBackColor = false;
            this.Btn_Shoot.Click += new System.EventHandler(this.Btn_Shoot_Click);
            // 
            // Btn_Spin
            // 
            this.Btn_Spin.BackColor = System.Drawing.Color.Coral;
            this.Btn_Spin.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Spin.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_Spin.Location = new System.Drawing.Point(35, 436);
            this.Btn_Spin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Spin.Name = "Btn_Spin";
            this.Btn_Spin.Size = new System.Drawing.Size(217, 57);
            this.Btn_Spin.TabIndex = 8;
            this.Btn_Spin.Text = "Spin";
            this.Btn_Spin.UseVisualStyleBackColor = false;
            this.Btn_Spin.Click += new System.EventHandler(this.Btn_Spin_Click);
            // 
            // Btn_load
            // 
            this.Btn_load.BackColor = System.Drawing.Color.Coral;
            this.Btn_load.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_load.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_load.Location = new System.Drawing.Point(35, 137);
            this.Btn_load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_load.Name = "Btn_load";
            this.Btn_load.Size = new System.Drawing.Size(217, 63);
            this.Btn_load.TabIndex = 7;
            this.Btn_load.Text = "Load";
            this.Btn_load.UseVisualStyleBackColor = false;
            this.Btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // Btn_PlayAgain
            // 
            this.Btn_PlayAgain.BackColor = System.Drawing.Color.Coral;
            this.Btn_PlayAgain.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PlayAgain.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_PlayAgain.Location = new System.Drawing.Point(830, 40);
            this.Btn_PlayAgain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_PlayAgain.Name = "Btn_PlayAgain";
            this.Btn_PlayAgain.Size = new System.Drawing.Size(180, 62);
            this.Btn_PlayAgain.TabIndex = 13;
            this.Btn_PlayAgain.Text = "Play Again";
            this.Btn_PlayAgain.UseVisualStyleBackColor = false;
            this.Btn_PlayAgain.Click += new System.EventHandler(this.Btn_PlayAgain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BackgroundImage = global::SimpleGame.Resource1.download;
            this.pictureBox1.InitialImage = global::SimpleGame.Resource1.download;
            this.pictureBox1.Location = new System.Drawing.Point(384, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 315);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 612);
            this.Controls.Add(this.Btn_PlayAgain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_ShootAway);
            this.Controls.Add(this.Btn_Shoot);
            this.Controls.Add(this.Btn_Spin);
            this.Controls.Add(this.Btn_load);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_ShootAway;
        private System.Windows.Forms.Button Btn_Shoot;
        private System.Windows.Forms.Button Btn_Spin;
        private System.Windows.Forms.Button Btn_load;
        private System.Windows.Forms.Button Btn_PlayAgain;
    }
}

