using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;

namespace FirstGame.Model
{
    public class Game
    {
        public PointF Position{ get; set; }

        public PointF Velocity { get; set; }

        public Size PlaygroundSize { get; set; }

        private Stopwatch watch = new Stopwatch();

        public Game()
        {
            Position = new PointF(0f, 0f);
            Velocity = new PointF(100f, 80f);
            watch.Start();
        }

        public void update()
        {
            Position = new PointF(
                Position.X + (float)(Velocity.X * watch.Elapsed.TotalSeconds),
                Position.Y + (float)(Velocity.Y * watch.Elapsed.TotalSeconds));

            if ((Position.X + 100) > PlaygroundSize.Width)
            {
                Position = new PointF(
                    (PlaygroundSize.Width - 100),
                    Position.Y);
                Velocity = new PointF(Velocity.X * -1f, Velocity.Y);
            }
            if ((Position.Y + 100) > PlaygroundSize.Height)
            {
                Position = new PointF(
                    Position.X,
                    PlaygroundSize.Height - 100);
                Velocity = new PointF(Velocity.X, Velocity.Y * -1f);
            }
            if (Position.X < 0)
            {
                Position = new PointF(0, Position.Y);
                Velocity = new PointF(Velocity.X * -1f, Velocity.Y);
            }
            if (Position.Y < 0)
            {
                Position = new PointF(Position.X, 0);
                Velocity = new PointF(Velocity.X, Velocity.Y * -1f);
            }
        }
    }

   
}
