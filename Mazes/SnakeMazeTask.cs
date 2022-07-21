namespace Mazes {
	public static class SnakeMazeTask {
		public static void MoveOut(Robot robot, int width, int height) {
			bool isRight = true;
			while( !robot.Finished ) {
				MoveRobot(robot, width, height, isRight);
				MoveDown(robot, width, height);
				isRight = !isRight;
				}
			}

		private static void MoveRobot(Robot robot, int width, int height, bool isRight) {
			for( int i = 1; i < width - 2; i++ ) {
				if( !robot.Finished ) robot.MoveTo(isRight ? Direction.Right : Direction.Left);
				}
			}

		public static void MoveDown(Robot robot, int width, int height) {
			if( !robot.Finished ) {
				robot.MoveTo(Direction.Down);
				robot.MoveTo(Direction.Down);
				}
			}
		}
	}