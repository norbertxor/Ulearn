namespace Mazes
{
	public static class PyramidMazeTask	{
		public static void MoveOut(Robot robot, int width, int height) {
			bool isRight = true;
			int deltaX = 2;
			while( !robot.Finished ) {
				MoveRobot(robot, width, height, isRight, deltaX);
				MoveDown(robot, width, height);
				isRight = !isRight;
				deltaX += 2;
				}
			}

		private static void MoveRobot(Robot robot, int width, int height, bool isRight, int deltaX) {
			for( int i = 1; i < width - deltaX; i++ ) {
				if( !robot.Finished ) robot.MoveTo(isRight ? Direction.Right : Direction.Left);
				}
			}

		public static void MoveDown(Robot robot, int width, int height) {
			if( !robot.Finished ) {
				robot.MoveTo(Direction.Up);
				robot.MoveTo(Direction.Up);
				}
			}
		}
}