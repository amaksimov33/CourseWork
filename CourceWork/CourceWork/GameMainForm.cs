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
        public GameMainForm()
        {
            InitializeComponent();
        }

        private void GameMainForm_Load(object sender, EventArgs e)
        {
            generatedNum = new Random().Next(9);
            MessageBox.Show(Convert.ToString(generatedNum));
        }

    }
}
