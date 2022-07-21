using System;

namespace Rectangles
{
	public static class RectanglesTask	{
		public static bool AreIntersected(Rectangle r1, Rectangle r2) {
			if(r2.Left > r1.Right || r1.Left > r2.Right || r2.Top > r1.Top + r1.Height || r1.Top > r2.Top + r2.Height)
				return false;			
			else
				return true;			
		}

		public static int IntersectionSquare(Rectangle r1, Rectangle r2) {
			int leftIntersection = Math.Max(r1.Left, r2.Left);
			int topIntersection = Math.Min(r1.Bottom, r2.Bottom);
			int rightIntersection = Math.Min(r1.Right, r2.Right);
			int bottomIntersection = Math.Max(r1.Top, r2.Top);
			int widhtIntersection = rightIntersection - leftIntersection;
			int heightIntersection = topIntersection - bottomIntersection;
			if( widhtIntersection < 0 || heightIntersection < 0 )
				return 0;
			else return widhtIntersection * heightIntersection;
		}

		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)	{
			if( r1.Left >= r2.Left && r1.Right <= r2.Right && r1.Top >= r2.Top && r1.Bottom <= r2.Bottom )
				return 0;
			else if( r2.Left >= r1.Left && r2.Right <= r1.Right && r2.Top >= r1.Top && r2.Bottom <= r1.Bottom )
				return 1;
			else 
				return -1;
		}
	}
}