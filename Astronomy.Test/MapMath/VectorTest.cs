using System;
using Astronomy.MapMath;
using NUnit.Framework;

namespace Astronomy.Test
{
	[TestFixture()]
	public class VectorTest
	{
		private readonly Angle right = new Angle(90);

		private readonly Angle zero = new Angle(0);

		[Test()]
		public void TestSphericalConversion_Origin()
		{
			var vector = new SphericalVector(0, zero, zero).Cartesian;

			Assert.AreEqual(0, vector.x);
			Assert.AreEqual(0, vector.y);
			Assert.AreEqual(0, vector.z);
			Assert.AreEqual(0, vector.magnitude);
		}


		[Test()]
		public void TestSphericalConversion1()
		{
			var vector = new SphericalVector(10, zero, right).Cartesian;

			Assert.AreEqual(10, vector.x, 0.000001);
			Assert.AreEqual(0, vector.y, 0.000001);
			Assert.AreEqual(0, vector.z, 0.000001);
			Assert.AreEqual(10, vector.magnitude);
		}

		[Test()]
		public void TestSphericalConversion2()
		{
			var vector = new SphericalVector(10, right, right).Cartesian;

			Assert.AreEqual(0, vector.x, 0.000001);
			Assert.AreEqual(10, vector.y, 0.000001);
			Assert.AreEqual(0, vector.z, 0.000001);
			Assert.AreEqual(10, vector.magnitude);
		}

		[Test()]
		public void TestSphericalConversion3()
		{
			var vector = new SphericalVector(10, right, zero).Cartesian;

			Assert.AreEqual(0, vector.x, 0.000001);
			Assert.AreEqual(0, vector.y, 0.000001);
			Assert.AreEqual(10, vector.z, 0.000001);
			Assert.AreEqual(10, vector.magnitude);
		}

		[Test()]
		public void TestMagnitude()
		{
			var vector = new SphericalVector(10, new Angle(45), new Angle(45)).Cartesian;

			Assert.AreEqual(10, vector.magnitude);
		}
	}
}
