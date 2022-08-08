namespace shadowfiend_minigame
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
            this.hp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._zeus = new System.Windows.Forms.PictureBox();
            this.shock = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.time3 = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._zeus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hp
            // 
            this.hp.AutoSize = true;
            this.hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hp.Location = new System.Drawing.Point(24, 273);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(135, 31);
            this.hp.TabIndex = 1;
            this.hp.Text = "HP: 2800";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 73);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 73);
            this.label3.TabIndex = 4;
            this.label3.Text = "C";
            // 
            // _zeus
            // 
            this._zeus.Image = global::shadowfiend_minigame.Properties.Resources.Zeus;
            this._zeus.Location = new System.Drawing.Point(1320, 194);
            this._zeus.Name = "_zeus";
            this._zeus.Size = new System.Drawing.Size(151, 151);
            this._zeus.TabIndex = 9;
            this._zeus.TabStop = false;
            // 
            // shock
            // 
            this.shock.Image = global::shadowfiend_minigame.Properties.Resources.brave_3iLZlTBLnh;
            this.shock.InitialImage = global::shadowfiend_minigame.Properties.Resources.brave_3iLZlTBLnh;
            this.shock.Location = new System.Drawing.Point(1100, 194);
            this.shock.Name = "shock";
            this.shock.Size = new System.Drawing.Size(86, 141);
            this.shock.TabIndex = 8;
            this.shock.TabStop = false;
            this.shock.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::shadowfiend_minigame.Properties.Resources._3shadowraze;
            this.pictureBox4.Location = new System.Drawing.Point(724, 509);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(123, 129);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::shadowfiend_minigame.Properties.Resources._2shadowraze;
            this.pictureBox3.Location = new System.Drawing.Point(433, 509);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(123, 129);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::shadowfiend_minigame.Properties.Resources._1shadowraze;
            this.pictureBox2.Location = new System.Drawing.Point(149, 509);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 129);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::shadowfiend_minigame.Properties.Resources.shadowfiendicon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 158);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(1011, 509);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(379, 87);
            this.Start.TabIndex = 10;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(993, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "zeus_hp: 3000";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1011, 620);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Легкий";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1167, 620);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Средний";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(1307, 620);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(73, 17);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Сложный";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // time3
            // 
            this.time3.AutoSize = true;
            this.time3.BackColor = System.Drawing.Color.Gray;
            this.time3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time3.Location = new System.Drawing.Point(754, 533);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(68, 73);
            this.time3.TabIndex = 15;
            this.time3.Text = "3";
            this.time3.Visible = false;
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.BackColor = System.Drawing.Color.Gray;
            this.time1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time1.Location = new System.Drawing.Point(177, 533);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(68, 73);
            this.time1.TabIndex = 16;
            this.time1.Text = "3";
            this.time1.Visible = false;
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.BackColor = System.Drawing.Color.Gray;
            this.time2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time2.Location = new System.Drawing.Point(462, 533);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(68, 73);
            this.time2.TabIndex = 17;
            this.time2.Text = "3";
            this.time2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 698);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.time3);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Start);
            this.Controls.Add(this._zeus);
            this.Controls.Add(this.shock);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "ShadowFiendGame";
            ((System.ComponentModel.ISupportInitialize)(this._zeus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label hp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox shock;
        private System.Windows.Forms.PictureBox _zeus;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label time3;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label time2;
    }
}

