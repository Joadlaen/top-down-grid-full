using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameIteration4
{
    public partial class PauseMenu : Form
    {
        public PauseMenu()
        {
            InitializeComponent();
        }

        private void Continue(object sender, EventArgs e)
        {
            Application.Run(new Form1());
        }

        private void Options(object sender, EventArgs e)
        {

        }

        private void SaveGame(object sender, EventArgs e)
        {

        }

        private void LoadGame(object sender, EventArgs e)
        {

        }

        private void GamePaused(object sender, EventArgs e)
        {
            LBTips.Items.Add("foxtrot, uniform, charlie, kilo");
        }
    }
}
