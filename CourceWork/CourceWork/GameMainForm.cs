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
        public int attempt = 1;
        public GameMainForm()
        {
            InitializeComponent();
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
            attempt = 1;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.Show();
        }

        private void CheckNum_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(userInputBox.Text) == generatedNum)
            {
                Message.Text = "Вы отгадали!";
            }
            else if(attempt<=3)
            {
                attempt += 1;
            }
        }
    }
}
