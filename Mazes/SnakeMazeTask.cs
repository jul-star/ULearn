using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Mazes
{
	public static class SnakeMazeTask
	{
        public static void MoveOut(Robot robot, int width, int height)
        {
            while (!robot.Finished)
            {
                Direction dir = (robot.X == 1 ?  Direction.Right : Direction.Left);
                for (int i = 0; i < width-3;++i)
                    robot.MoveTo(dir);
                for (int i = 0; i < 2 && robot.Y< height-2; ++i)
                    robot.MoveTo(Direction.Down);
            }
        }
    }
}