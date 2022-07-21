namespace Mazes {
    public static class EmptyMazeTask {
        public static void MoveOut(Robot robot, int width, int height) {
            for( int i = 1; i < height + width - 2; i++ ) {
                if( !robot.Finished && robot.Y != height - 2 ) robot.MoveTo(Direction.Down);
                if( !robot.Finished && robot.X != width - 2 ) robot.MoveTo(Direction.Right);
                }
            }
        }
    }