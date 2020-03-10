namespace CourceWork
{
    partial class GameMainForm
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
            this.userInputBox = new System.Windows.Forms.TextBox();
            this.InputNumLabel = new System.Windows.Forms.Label();
            this.CheckNum = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.StartOver = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.AttemptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userInputBox
            // 
            this.userInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.userInputBox.Location = new System.Drawing.Point(314, 208);
            this.userInputBox.Multiline = true;
            this.userInputBox.Name = "userInputBox";
            this.userInputBox.Size = new System.Drawing.Size(156, 33);
            this.userInputBox.TabIndex = 0;
            this.userInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputNumLabel
            // 
            this.InputNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InputNumLabel.ForeColor = System.Drawing.Color.Black;
            this.InputNumLabel.Location = new System.Drawing.Point(167, 165);
            this.InputNumLabel.Name = "InputNumLabel";
            this.InputNumLabel.Size = new System.Drawing.Size(440, 27);
            this.InputNumLabel.TabIndex = 1;
            this.InputNumLabel.Text = "Введите число";
            this.InputNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckNum
            // 
            this.CheckNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(191)))), ((int)(((byte)(110)))));
            this.CheckNum.Location = new System.Drawing.Point(306, 307);
            this.CheckNum.Name = "CheckNum";
            this.CheckNum.Size = new System.Drawing.Size(172, 52);
            this.CheckNum.TabIndex = 2;
            this.CheckNum.Text = "Проверить";
            this.CheckNum.UseVisualStyleBackColor = false;
            this.CheckNum.Click += new System.EventHandler(this.CheckNum_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.button2.Location = new System.Drawing.Point(473, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StartOver
            // 
            this.StartOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(148)))), ((int)(((byte)(191)))));
            this.StartOver.Location = new System.Drawing.Point(51, 60);
            this.StartOver.Name = "StartOver";
            this.StartOver.Size = new System.Drawing.Size(164, 52);
            this.StartOver.TabIndex = 4;
            this.StartOver.Text = "Начать занова";
            this.StartOver.UseVisualStyleBackColor = false;
            this.StartOver.Click += new System.EventHandler(this.StartOver_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(142)))), ((int)(((byte)(143)))));
            this.Settings.Location = new System.Drawing.Point(563, 60);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(164, 52);
            this.Settings.TabIndex = 5;
            this.Settings.Text = "Настройка";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(9)))), ((int)(((byte)(237)))));
            this.Message.Location = new System.Drawing.Point(5, 254);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(783, 35);
            this.Message.TabIndex = 6;
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Message.UseMnemonic = false;
            // 
            // AttemptLabel
            // 
            this.AttemptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AttemptLabel.ForeColor = System.Drawing.Color.Black;
            this.AttemptLabel.Location = new System.Drawing.Point(235, 387);
            this.AttemptLabel.Name = "AttemptLabel";
            this.AttemptLabel.Size = new System.Drawing.Size(316, 33);
            this.AttemptLabel.TabIndex = 7;
            this.AttemptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(204)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AttemptLabel);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.StartOver);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CheckNum);
            this.Controls.Add(this.InputNumLabel);
            this.Controls.Add(this.userInputBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "GameMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameMainForm_FormClosed);
            this.Load += new System.EventHandler(this.GameMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInputBox;
        private System.Windows.Forms.Label InputNumLabel;
        private System.Windows.Forms.Button CheckNum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button StartOver;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Label AttemptLabel;
    }
}