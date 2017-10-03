namespace HelloWorld1.Grafics
{
	public class Point : GPoint
	{
		// Fields:
		private double _x;
		private double _y;

		// Constructor:
		public Point(double x, double y)
		{
			_x = x;
			_y = y;
		}

		// Property implementation:
		public double x
		{
			get
			{
				return _x;
			}

			set
			{
				_x = value;
			}
		}

		public double y
		{
			get
			{
				return _y;
			}
			set
			{
				_y = value;
			}
		}

		public override string ToString()
		{
			return _x + " === " + _y;
		}
	}

}