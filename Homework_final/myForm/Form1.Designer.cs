namespace myForm
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mouseX = new System.Windows.Forms.TextBox();
            this.mouseY = new System.Windows.Forms.TextBox();
            this.monsterPositionY = new System.Windows.Forms.TextBox();
            this.monsterPositionX = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mouseX
            // 
            this.mouseX.Location = new System.Drawing.Point(122, 525);
            this.mouseX.Name = "mouseX";
            this.mouseX.Size = new System.Drawing.Size(118, 22);
            this.mouseX.TabIndex = 0;
            this.mouseX.Visible = false;
            // 
            // mouseY
            // 
            this.mouseY.Location = new System.Drawing.Point(-1, 525);
            this.mouseY.Name = "mouseY";
            this.mouseY.Size = new System.Drawing.Size(117, 22);
            this.mouseY.TabIndex = 1;
            this.mouseY.Visible = false;
            // 
            // monsterPositionY
            // 
            this.monsterPositionY.Location = new System.Drawing.Point(-1, 497);
            this.monsterPositionY.Name = "monsterPositionY";
            this.monsterPositionY.Size = new System.Drawing.Size(117, 22);
            this.monsterPositionY.TabIndex = 4;
            this.monsterPositionY.Visible = false;
            // 
            // monsterPositionX
            // 
            this.monsterPositionX.Location = new System.Drawing.Point(122, 497);
            this.monsterPositionX.Name = "monsterPositionX";
            this.monsterPositionX.Size = new System.Drawing.Size(118, 22);
            this.monsterPositionX.TabIndex = 3;
            this.monsterPositionX.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(508, 518);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(64, 31);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "開始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(532, 444);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 524);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.monsterPositionY);
            this.Controls.Add(this.monsterPositionX);
            this.Controls.Add(this.mouseY);
            this.Controls.Add(this.mouseX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mouseX;
        private System.Windows.Forms.TextBox mouseY;
        private System.Windows.Forms.TextBox monsterPositionY;
        private System.Windows.Forms.TextBox monsterPositionX;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

