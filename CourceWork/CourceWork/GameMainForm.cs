using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourceWork
{
    public partial class GameMainForm : Form
    {
        int generatedNum;
        public static int startRandom = 0;
        public static int endRandom = 9;
        public static int numAttempt = 3;
        public int attempt = numAttempt;
        public GameMainForm()
        {
            InitializeComponent();
            InputNumLabel.Text = InputNumLabel.Text + " от " + startRandom + " до " + endRandom + ":";
            AttemptLabel.Text = "Осталось попыток: " + attempt;
        }

        private void GameMainForm_Load(object sender, EventArgs e)
        {
            generatedNum = new Random().Next(startRandom, endRandom);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userInputBox.Text = "";
        }


        private void StartOver_Click(object sender, EventArgs e)
        {
            generatedNum = new Random().Next(startRandom, endRandom);
            attempt = numAttempt;
            Message.Text = "";
            AttemptLabel.Text = "";
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsForm settings = new SettingsForm();
            settings.Show();
        }

        private void CheckNum_Click(object sender, EventArgs e)
        {
            string Str = userInputBox.Text.Trim();
            int inputValue;
            bool isNum = int.TryParse(Str, out inputValue);
            if (!isNum) {
                Message.ForeColor = Color.FromArgb(87, 20, 255);
                Message.Text = "Необходимо ввести число";
                return;
            }
            else if (inputValue< startRandom || inputValue>endRandom)
            {
                Message.ForeColor = Color.FromArgb(87, 20, 255);
                Message.Text = "Число выходит за допустимый диапозон";
                return;
            }
            else if (inputValue == generatedNum)
            {
                Message.ForeColor = Color.FromArgb(184, 9, 237);
                Message.Text = "Вы отгадали!";
                AttemptLabel.Text = "";
            }
            else if(attempt != 0)
            {
                Message.ForeColor = Color.FromArgb(87, 20, 255);
                Message.Text = "Задуманное компьютером число "+(inputValue > generatedNum ? "меньше" : "больше")+" введеного";
                attempt -= 1;
                AttemptLabel.Text = "Осталось попыток: " + attempt;
            }
            else
            {
                Message.ForeColor = Color.FromArgb(250, 20, 20);
                Message.Text = "Попытки закончились, начните занова";
            }
        }

    }
}
