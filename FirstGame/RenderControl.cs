using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FirstGame.Model
{
    public partial class RenderControl : UserControl
    {
        private Stopwatch watch = new Stopwatch();

        public RenderControl()
        {
            InitializeComponent();
            watch.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.CornflowerBlue);

            using (Brush brush = new SolidBrush(Color.White))
            {
                e.Graphics.FillEllipse(brush, new RectangleF(x, y, 100, 100));
            }

            watch.Restart();
        }
    }
}
