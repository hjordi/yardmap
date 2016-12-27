using System;
using NUnit.Framework;
using Astronomy.SkyView;
using Astronomy.MapMath;

namespace Astronomy.Test
{
	[TestFixture ()]
	public class SunPositionCalculatorTest
	{
		

		[Test ()]
		public void TestCalculation()
		{			
			var Longitude = new Angle (02, 17, 23);
			var Latitude = new Angle (48, 49);
			var testTime = new DateTime (2006, 11, 15, 10, 35, 00);

			var calculator = new SunPositionCalculator () {
				Longitude = Longitude,
				Latitude = Latitude,
				Time = testTime,
				VisualDistance = 1					
			};


			Assert.AreEqual (314.849, calculator.g.Degrees, 0.001);
			Assert.AreEqual (-18.6162, calculator.d.Degrees, 0.0001);
			Assert.AreEqual (3.72763, calculator.tc.Degrees, 0.001);
			Assert.AreEqual (-15.2327, calculator.sha.Degrees, 0.0001);
			Assert.AreEqual (68.78676, calculator.sza.Degrees, 0.0001);
			Assert.AreEqual (21.213, calculator.sea.Degrees, 0.001);
			Assert.AreEqual (164.50848, calculator.az.Degrees, 0.001);

		}


	}
}

