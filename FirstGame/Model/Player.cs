using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame.Model
{
    public class Player
    {
        public PointF Position { get; set; }

        public PointF Velocity { get; set; }

        public Player()
        {
            Position = new PointF(0f, 0f);
            Velocity = new PointF(100f, 100f);
        }


    }
}
