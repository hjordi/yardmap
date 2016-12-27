using System;
using Astronomy.MapMath;
using Astronomy.SkyView;
using NUnit.Framework;

namespace Astronomy.Test
{
	[TestFixture()]
	public class SunLocatorTest
	{
		[Test()]
		public void TestDateSpread()
		{
			var locator = new SunLocator(new GeoLocationInfo(new Angle(44), new Angle(-123)));
			
			var startDate = new DateTime(2016, 1, 1, 0, 0, 0);
			var stopDate = startDate.AddDays(1);

			for (var i = startDate; i <= stopDate; i = i.AddHours(1))
			{
				var position = locator.GetPosition(i);
				var cartesian = position.Cartesian;

				Assert.AreEqual(30, cartesian.magnitude, 0.00001);
			}
		}
	}
}
