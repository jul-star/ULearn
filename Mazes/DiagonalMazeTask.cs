using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System.Collections;

namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            (int right, int down) = SetSteps(width, height);
            while (!robot.Finished)
            {
                if (right > down)
                {
                    MoveToRight(robot, right);
                    MoveDown(robot, down);
                }
                else
                {
                    MoveDown(robot, down);
                    MoveToRight(robot, right);
                }
            }
        }

        private static void MoveDown(Robot robot, int down)
        {
            for (int i = 0; i < down && !robot.Finished; ++i)
                robot.MoveTo(Direction.Down);
        }

        private static void MoveToRight(Robot robot, int right)
        {
            for (int i = 0; i < right && !robot.Finished; ++i)
                robot.MoveTo(Direction.Right);
        }

        private static Tuple<int, int> SetSteps(int width, int height)
        {

            int right;
            int down;
            if (Math.Abs(width - height) <= 2)
            {
                right = down = 1;
            }
            else
            {
                right = (width + height - 1) / height;
                down = (width + height - 1) / width;
            }
             
            return new Tuple<int, int>(right , down);
        }
    }
}