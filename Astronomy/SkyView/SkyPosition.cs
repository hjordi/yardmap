using System;
using Astronomy.MapMath;

namespace Astronomy
{
	public class SkyPosition
	{
		private SphericalVector vector;

		public SkyPosition(SphericalVector vector)
		{
			this.vector = vector;
		}
		public double Intensity 
		{
			get { return vector.Radius; }
		}

		public Angle SolarHeightAngle
		{
			get { return vector.Theta; }
		}

		public Angle Azimuth 
		{ 
			get { return vector.Phi;} 
		}

		public CartesianVector Cartesian
		{
			get { return vector.Cartesian; }
		}

		public bool IsNight
		{
			get { return SolarHeightAngle.Degrees < 0.0 || Azimuth.Degrees < 0.0; }
		}

		public int ApparentHour
		{
			get 
			{
				return (int)(Azimuth.Degrees % 24);
			}
		}

		public override string ToString()
		{
			if (IsNight)
				return "Night";

			return "~" + ApparentHour;
		}
	}
}
