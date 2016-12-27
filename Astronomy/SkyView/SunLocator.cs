using System;
using Astronomy.MapMath;

namespace Astronomy.SkyView
{
	/// <summary>
	/// Sun locator.
	/// </summary>
	public class SunLocator
	{
		public const int VisualDistance = 30;

		private GeoLocationInfo location;

		/// <summary>
		/// constructor
		/// </summary>
		public SunLocator (GeoLocationInfo location)
		{
			this.location = location;
		}

		private Angle Longitude 
		{
			get { return location.Longitude; }
		}

		private Angle Latitude
		{
			get { return location.Latitude; }
		}
				
		/// <summary>
		/// get the sun position in the sky at the given time
		/// </summary>
		/// <returns>The position.</returns>
		/// <param name="time">Time.</param>
		public SkyPosition GetPosition(DateTime time)
		{		
			var calculator = new SunPositionCalculator () {
				Latitude = location.Latitude,
				Longitude = location.Longitude,
				VisualDistance = VisualDistance,
				Time = time
			};

			return calculator.Position;
		}


	}
}

