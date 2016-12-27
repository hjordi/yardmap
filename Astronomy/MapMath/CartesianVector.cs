using System;
namespace Astronomy
{
	public class CartesianVector 
	{
		internal CartesianVector(double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public double x
		{
			get; private set;
		}

		public double y
		{
			get; private set;
		}

		public double z
		{
			get; private set;
		}

		public double magnitude
		{
			get { return Math.Sqrt(x * x + y * y + z * z); }
		}
	}
}
