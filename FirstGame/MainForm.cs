using FirstGame.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGame
{
    public partial class mainForm : Form
    {
        private Game game = new Game();

        public mainForm()
        {
            game.PlaygroundSize = new Size(renderControl.ClientSize);
            InitializeComponent();
        }

        private void closeMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            game.update();
            renderControl.Invalidate();
        }
    }
}
