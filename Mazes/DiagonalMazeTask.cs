using System;

namespace Mazes {
    public static class DiagonalMazeTask {
        public static void MoveOut(Robot robot, int width, int height) {
            double deltaX = Math.Round((double)width / height) < 1 ? 1 : Math.Round((double)width / height);
            double deltaY = Math.Round((double)height / width) < 1 ? 1 : Math.Round((double)height / width);         
            while( !robot.Finished ) {
                StepA(robot, width, height, deltaX, deltaY);
                StepB(robot, width, height, deltaX, deltaY);
                }
            }

        private static void StepB(Robot robot, int width, int height, double deltaX, double deltaY) {
            for( int i = 0; i < ( width < height ? deltaX : deltaY ); i++ ) {
                if( !robot.Finished ) robot.MoveTo(width < height ? Direction.Right : Direction.Down);
                }
            }

        private static void StepA(Robot robot, int width, int height, double deltaX, double deltaY) {
            for( int i = 0; i < ( width > height ? deltaX : deltaY ); i++ ) {
                if( !robot.Finished ) robot.MoveTo(width > height ? Direction.Right : Direction.Down);
                }
            }
        }
    }