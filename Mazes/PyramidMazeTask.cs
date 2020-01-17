namespace Mazes
{
	public static class PyramidMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
        {
            while (!robot.Finished)
            {
                if (robot.X < width)
                {
                    robot.MoveTo(Direction.Right);
                }
                if (robot.Y < height)
                {
                    robot.MoveTo(Direction.Down);
                }
            }
		}
	}
}