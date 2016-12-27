using System;

namespace Astronomy.MapMath
{
	/// <summary>
	/// use spherical coordinates to represent a vector. 
	/// 
	/// </summary>
	public class SphericalVector
	{

		public double Radius { get; set; }
		public Angle Theta { get; set; }
		public Angle Phi { get; set; }

		public SphericalVector(double radius, Angle theta, Angle phi)
		{
			this.Radius = radius;
			this.Theta = theta;
			this.Phi = phi;
		}

		public SphericalVector()
		{
		}

		public CartesianVector Cartesian
		{
			get
			{
				var x = Radius * Trig.Sin(Phi) * Trig.Cos(Theta);
				var y = Radius * Trig.Sin(Phi) * Trig.Sin(Theta);
				var z = Radius * Trig.Cos(Phi);
				return new CartesianVector(x, y, z);
			}
		}

		public override string ToString()
		{
			return "(" + Radius.ToString(GeoLocationInfo.Format) + "," + Theta + "," + Phi + ")";
		}

	
		


			
	}
}

