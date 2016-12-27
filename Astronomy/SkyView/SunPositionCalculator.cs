using System;
using Astronomy.MapMath;

namespace Astronomy.SkyView
{
	/// <summary>
	/// temporary tool to troubleshoot Sun position
	/// </summary>
	public class SunPositionCalculator
	{
		
		public Angle Longitude { get; set; }

		public Angle Latitude { get; set;}

		public DateTime Time { get; set; }

		public int VisualDistance { get; set; }

		/// <summary>
		/// day of the year
		/// </summary>
		/// <value>The dy.</value>
		public int dy 
		{
			get { return Time.DayOfYear; }
		}
		/// <summary>
		/// hour of the day
		/// </summary>
		/// <value>The h.</value>
		public double h
		{
			get
			{
				var hourOffset = Time - new DateTime (Time.Year, Time.Month, Time.Day, 0, 0, 0);
				return hourOffset.TotalHours;
			}
		}
		/// <summary>
		/// factional year
		/// </summary>
		/// <value>The g.</value>
		public Angle g 
		{
			get { return new Angle((360 / 365.25) * (dy + h / 24)); }	
		}
		/// <summary>
		/// declination
		/// </summary>
		/// <value>The d.</value>
		public Angle d
		{
			get { 
				return new Angle (0.396372 - 22.91327 * Trig.Cos (g) + 4.02543 * Trig.Sin (g) -
				0.387205 * Trig.Cos (2 * g) + 0.051967 * Trig.Sin (2 * g) -
				0.154527 * Trig.Cos (3 * g) + 0.084798 * Trig.Sin (3 * g));
			}
		}
		/// <summary>
		/// time correction
		/// </summary>
		/// <value>The tc.</value>
		public Angle tc
		{
			get 
			{ 
				return new Angle (0.004297 + 0.107029 * Trig.Cos (g) - 1.837877 * Trig.Sin (g)
					- 0.837378 * Trig.Cos (2 * g) - 2.340475 * Trig.Sin (2 * g));

			}
		}
		/// <summary>
		/// solar height angle
		/// </summary>
		/// <value>The sha.</value>
		public Angle sha
		{
			get 
			{
				return new Angle((h-12) * 15) + Longitude + tc;
			}
		}
		/// <summary>
		/// sun zenith angle
		/// </summary>
		/// <value>The sza.</value>
		public Angle sza
		{
			get
			{
				var cosine = Trig.Sin (Latitude) * Trig.Sin (d) + Trig.Cos (Latitude) * Trig.Cos (d) * Trig.Cos (sha);
				return Trig.Acos(cosine);
			}
		}
		/// <summary>
		/// sun elevation angle
		/// </summary>
		/// <value>The sea.</value>
		public Angle sea
		{
			get { return new Angle (90) - sza; }
		}
		/// <summary>
		/// solar azimuth
		/// </summary>
		/// <value>The az.</value>
		public Angle az
		{
			get 
			{
				var cosine = (Trig.Sin (d) - Trig.Sin (Latitude) * Trig.Cos (sza)) / (Trig.Cos (Latitude) * Trig.Sin (sza));
				return Trig.Acos(cosine);
			}
		}

		public SkyPosition Position
		{
			get 
			{
				var vector = new SphericalVector(VisualDistance, az, sza);
				if (Time.Hour > 12)
					vector.Theta = vector.Theta + new Angle(180);
				return new SkyPosition (vector); 
			}
		}


	}
}

