using System;
using Astronomy.MapMath;
using NUnit.Framework;

namespace Astronomy.Test
{
	[TestFixture()]
	public class TrigTest
	{
		[Test()]
		public void TestCos()
		{
			Assert.AreEqual(1, Trig.Cos(new Angle(0)), 0.000001);
			Assert.AreEqual(0, Trig.Cos(new Angle(90)), 0.000001);
		}
		[Test()]
		public void TestSanity()
		{
			Assert.AreEqual(0, Math.Cos(Math.PI / 2), 0.000001);
		}
	}
}
