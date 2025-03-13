using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.ans_.cut4trigon
{
	/// <summary>
	/// 
	/// </summary>
	[TestClass]
	public class UnitTest1
	{

		[TestMethod]
		public void TestMethod1()
		{
			/// given a rope,
			/// , let's cut it into three segments.
			/// , the probability of them able to form a triangle?
			///
			/// from one weixin video:
			///  x + y +z =1
			///		, here we assumes that each point is equiprobable? is that so?
			///	to form a triangle,
			///	, we need
			///		, x lt 1/2
			///		, y lt 1/2
			///		, z lt 1/2
			///
			/// ;
			/// let's take <see cref="nilnul.geometry.planar.zone_.trigon_.equilateral"/>, the height/altitude of which is 1
			/// , and find an inner point P such that:
			///		the <see cref="geometry.planar.line.vsPoint._LegX"/> of P to the edges sum to 1. ( the leg * the edge /2 is the area of the subtriangle; three such subtriangles sum to the whole area; hence the sum of the legs are the altitude of the whole triangle; <see cref="geometry.planar.zone_.trigon_.equilateral.inner.legs.ISum"/>)
			///		Now constraint the point such each leg is lt 1/2,
			///		, and the confinement is the circumscribe inner triangle of three mid point of the edges.
			///		, the area of the triangle is 1/4 of the whole triangle, which represents x +y +z =1.
			///
			/// now back to the suspicion: is each point equiprobable?
			///

			///let's simulate to verify the above logic;
			const int total = 1000_000;

			var affirmative = 0;

			Random random = new Random();
			//Thread.SpinWait(1234567);
			//Thread.Sleep(123);

			Task.Delay(1234).GetAwaiter().GetResult();


			var rnd = new Random();
				//System.Security.Cryptography.RandomNumberGenerator.Create()
			;
			
			
			for (int i = 0; i < total; i++)
			{
				//Thread.SpinWait(33);

				var cut0 = random.NextDouble();
				Task.Delay(123).GetAwaiter().GetResult();

				rnd = new Random();
				var cut1 = rnd.NextDouble();


				var min = Math.Min(cut0, cut1);

				var max = Math.Max(cut0, cut1);

			

				var y = max - min;

				var z = 1 - max;

				if (nilnul.num.real_.unneg.tro.be_._TrigonX._Be_012unneg(min, y, z))
				{
					affirmative++;
				}

			 }

			Assert.IsTrue(
				nilnul.num.real.re_.approx_.Hundredth4dbl.Singleton.re(
				(double) affirmative / total
				,
				.25
				)
			);







		}
	}
}
