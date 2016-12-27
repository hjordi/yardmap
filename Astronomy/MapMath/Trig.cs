using System;

namespace Astronomy.MapMath
{
	/// <summary>
	/// calls Math library functions related to Trigonometry but handles them in degrees instead of radianas
	/// </summary>
	public static class Trig
	{
		/// <summary>
		/// Sin in degrees.
		/// </summary>
		/// <param name="angle">Degrees.</param>
		public static double Sin(Angle angle)
		{
			var rad = angle.Radians;
			return System.Math.Sin(rad);
		}
		/// <summary>
		/// Cos in degrees.
		/// </summary>
		/// <param name="angle">Degrees.</param>
		public static double Cos(Angle angle)
		{
			var rad = angle.Radians;
			return System.Math.Cos(rad);
		}
		/// <summary>
		/// Arc Cosine
		/// </summary>
		/// <returns>degrees for this cosine</returns>
		/// <param name="cosine">a cosine ratio</param>
		public static Angle Acos(double cosine)
		{
			if (cosine > 1.0)
				cosine = 1.0;
			if (cosine < -1.0)
				cosine = -1.0;
			return Angle.FromRadians(System.Math.Acos(cosine));
		}

	}
}

