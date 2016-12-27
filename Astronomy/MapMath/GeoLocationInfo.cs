using System;
using Astronomy.MapMath;

namespace Astronomy.MapMath
{
	public class GeoLocationInfo
	{
		public const string Format = "F5";

		public GeoLocationInfo ()
		{
		}

		public GeoLocationInfo(Angle latitude, Angle longitude)
		{
			Latitude = latitude;
			Longitude = longitude;
		}

		public Angle Longitude { get; set; }

		public Angle Latitude { get; set; }

		public decimal Altitude { get; set; }
	}


}

