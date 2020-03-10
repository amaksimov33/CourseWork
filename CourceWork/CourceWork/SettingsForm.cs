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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            StartRandom.Text = Convert.ToString(GameMainForm.startRandom);
            EndRandom.Text = Convert.ToString(GameMainForm.endRandom);
            NumAttempt.Text = Convert.ToString(GameMainForm.numAttempt);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
                GameMainForm.startRandom = Convert.ToInt32(StartRandom.Text);
                GameMainForm.endRandom = Convert.ToInt32(EndRandom.Text);
                GameMainForm.numAttempt = Convert.ToInt32(NumAttempt.Text);
                this.Hide();
                GameMainForm gameMainForm = new GameMainForm();
                gameMainForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameMainForm gameMainForm = new GameMainForm();
            gameMainForm.Show();
        }
    }
}
