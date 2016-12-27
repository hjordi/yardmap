using System; 

namespace Astronomy.MapMath
{
	/// <summary>
	/// angle measurement in classic 0-360 degrees
	/// </summary>
	public class Angle
	{
		/// <summary>
		/// actual measure of degrees
		/// </summary>
		/// <value>The degrees.</value>
		public double Degrees { get; private set; }


		/// <summary>
		/// constructor from classic degree description
		/// </summary>
		/// <param name="degrees">Degrees.</param>
		/// <param name="minutes">Minutes.</param>
		/// <param name="seconds">Seconds.</param>
		public Angle(double degrees, double minutes = 0, double seconds = 0)
		{
			//TODO: normalize degrees to be between 0 and 360
			this.Degrees = degrees + minutes / 60 + seconds / 3600;
		}


		/// <summary>
		/// convert to radians
		/// </summary>
		/// <returns>The radians.</returns>
		public double Radians
		{
			get { return Degrees * System.Math.PI / 180; }	
		}
		/// <summary>
		/// Froms the radians.
		/// </summary>
		/// <returns>The radians.</returns>
		/// <param name="radians">Radians.</param>
		public static Angle FromRadians(double radians)
		{
			return new Angle(radians * 180 / System.Math.PI);
		}

		public override string ToString()
		{
			return Degrees.ToString(GeoLocationInfo.Format);
		}



		/// <param name="c1">C1.</param>
		/// <param name="c2">C2.</param>
		public static Angle operator +(Angle c1, Angle c2) 
		{
			return new Angle (c1.Degrees + c2.Degrees);
		}

		/// <param name="c1">C1.</param>
		/// <param name="c2">C2.</param>
		public static Angle operator -(Angle c1, Angle c2) 
		{
			return new Angle (c1.Degrees - c2.Degrees);
		}

		/// <param name="c1">C1.</param>
		/// <param name="c2">C2.</param>
		public static Angle operator *(double c1, Angle c2) 
		{
			return new Angle (c1 * c2.Degrees);
		}

		/// <param name="c1">C1.</param>
		/// <param name="c2">C2.</param>
		public static Angle operator *(Angle c1, double c2) 
		{
			return new Angle (c1.Degrees * c2);
		}
	}
}

