namespace CourceWork
{
    partial class Settings
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
            this.label2 = new System.Windows.Forms.Label();
            this.EndRandom = new System.Windows.Forms.TextBox();
            this.StartRandom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NumAttempt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(254, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Диапозон до";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(273, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Диапозон с";
            // 
            // EndRandom
            // 
            this.EndRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.EndRandom.Location = new System.Drawing.Point(398, 140);
            this.EndRandom.Multiline = true;
            this.EndRandom.Name = "EndRandom";
            this.EndRandom.Size = new System.Drawing.Size(156, 33);
            this.EndRandom.TabIndex = 4;
            this.EndRandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StartRandom
            // 
            this.StartRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.StartRandom.Location = new System.Drawing.Point(398, 67);
            this.StartRandom.Multiline = true;
            this.StartRandom.Name = "StartRandom";
            this.StartRandom.Size = new System.Drawing.Size(156, 33);
            this.StartRandom.TabIndex = 5;
            this.StartRandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(191)))), ((int)(((byte)(110)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(247, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(435, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // NumAttempt
            // 
            this.NumAttempt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.NumAttempt.Location = new System.Drawing.Point(398, 213);
            this.NumAttempt.Multiline = true;
            this.NumAttempt.Name = "NumAttempt";
            this.NumAttempt.Size = new System.Drawing.Size(156, 33);
            this.NumAttempt.TabIndex = 8;
            this.NumAttempt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(195, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество попыток";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(204)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumAttempt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartRandom);
            this.Controls.Add(this.EndRandom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EndRandom;
        private System.Windows.Forms.TextBox StartRandom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox NumAttempt;
        private System.Windows.Forms.Label label3;
    }
}