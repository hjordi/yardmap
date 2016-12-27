using System;
using NUnit.Framework;
using Astronomy.MapMath;

namespace Astronomy.Test
{
	[TestFixture()]
	public class AngleTest
	{
		[Test()]
		public void TestConventionMinutes()
		{
			var degree = new Angle (48, 49);

			Assert.AreEqual (48.81667, degree.Degrees, 0.00001);
		}

		[Test()]
		public void TestConversionSeconds()
		{
			var degree = new Angle (02, 17, 23);

			Assert.AreEqual(2.28972, degree.Degrees, 0.00001);
		}
		[Test()]
		public void TestToRadians()
		{
			Assert.AreEqual(0, new Angle(0).Radians);
			Assert.AreEqual(Math.PI/2, new Angle(90).Radians);
		}
	}
}

