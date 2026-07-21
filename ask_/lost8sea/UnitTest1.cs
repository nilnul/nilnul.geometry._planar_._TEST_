using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.geometry.planar.ask_.lost8sea
{
	[TestClass]
	public class UnitTest1
	{

		/// <summary>
		/// when you drive a boat offshore 1000meters, and you get lost. How can you get back to shore, efficiently?
		/// 
		/// </summary>
		/// <remarks>
		/// solvent (threshold: acceptable, satisfactory, optimum):
		///		,confirm that the boat is offshore no more than 1000meters
		///		,drive the boat straight in the direction that is the most possible towards the shore; take this path as the radius;
		///				-- this step is necessary as we need the radius (from center to perimeter) to fixate the circle.
		///		- then perpendicular to the radius, circle a rotation until Tau=2Pi, and along the circle the shore can be found along the cruising;
		///;
		///
		/// ans:
		///		when you have circled almost a full circle, you don't need to follow the arc, which is a curve, any more; you can just follow the tangent line, and go forward straight, and you will reach the shore;
		///		
		/// ans:
		///		if you drive out <var>d</var>meters, where d is more than 1000, you then cruise less than a cirle to reach the land in worst scenario.
		///		it turns out the distance is shorter than when <var>d</var> is exactly 1000m.
		/// 
		/// </remarks>
		/// alternative:
		///		statistically, the position (including angle estimated where the shore is) might be not evenly in probability;
		///		
		/// nature: the wave's direction in general is stable; consider that.
		/// also consider observing the stars, suns.
		/// artifact:
		///		take into account of the gasoline you have, and how long you can go; jettison when necessary; 
		///		
		/// learned:
		///  never go further to make the gasoline less than the circle entails;

		[TestMethod]
		public void TestMethod1()
		{
			{

				var offshore = 1; /// kilometers

				var distance = offshore + nilnul.geometry.planar.cloze_.circ._PerimeterX._Perimeter_0radius(offshore);


				/// now drive further
				/// 
				/// the worst scenario:
				/// 

				double total(double radius)
				{


					var distanceTotal =
						radius
						+
						(nilnul.num.real_.eg_._Tau4dblX.FULL
						-
						2* nilnul.num.real.op_.atrig_._AsecX.Asec(radius)
						)

						* radius

						; /// this is a convex function;
						  /// [1,1.183] of d maps to [1+tau] of distance
						  /// and the minimal src is in between. search for it  
						  /// 
					return distanceTotal;

				}

				var total8one = total(1);
				var total81_183 = total(1.183);

				double[] trials = [
					total(1),total(1.183)
					,
					total(1.04)		/// this is better as this avoids the nearMiss due to precision when the radius is exactly 1.
					];

				Assert.IsTrue(
					trials[2]< trials[0]
				);


				/// now we select an arbitrary direction, which is theta rotation away from the leg perpendicular to the shore which is assumed straight.
				/// 
				/// 
				/// 

				double voyage_0theta(double angle)
				{

					/// in the worst scenario:
					/// we initially travel sec(theta)
					/// :
					/// 
					var radius = nilnul.num.real.op_.trigno_._SecantX.Secant(
						angle
					);

					/// then in worst case, we travel away from the shore, by a turn of 90deg + theta
					/// then go straight of distance: tan(theta), which is the same as the pedal of the foot to the current onshore point. (noting: the two triangles are same in shared side, an angle, and the other side, hence they are identical triangles );
					/// , and the point we reach as target is again 1 away from the center. Then we circle, by (tau - 4 theta);
					/// ,then we go straight.
					/// 
					/// 
					var voyage = radius
						+
						(nilnul.num.real_.eg_._Tau4dblX.FULL - 4* angle)
						+2* Math.Tan(angle)

					;
					return voyage;
				}

				/// <see cref="voyage_0theta(double)"/> is a convex function.
				/// 
				double[] trials4angles = [
					voyage_0theta(0)
					,
					voyage_0theta(
						nilnul.geometry.planar.rotation_.Degree4dbl.ToRadian(36.375)
					)

				];

				Assert.IsTrue(
				trials4angles[1] < trials4angles[0]
				);

				Assert.IsTrue(
				trials4angles[1] < trials[2]
				);


				/// but we can make last straight segment earlier, by circling 210deg
				/// 

				double voyage_straight2shore()
				{
					var angle = nilnul.geometry.planar.rotation_.Degree4dbl.ToRadian(30);


					/// in the worst scenario:
					/// we initially travel sec(theta)
					/// :
					/// 
					var radius = nilnul.num.real.op_.trigno_._SecantX.Secant(
						angle
					);

					/// then in worst case, we travel away from the shore, by a turn of 90deg + theta
					/// then go straight of distance: tan(theta), which is the same as the pedal of the foot to the current onshore point. (noting: the two triangles are same in shared side, an angle, and the other side, hence they are identical triangles );
					/// , and the point we reach as target is again 1 away from the center. Then we circle, by (tau - 4 theta);
					/// ,then we go straight.
					/// 
					/// 
					var voyage = radius
						+ Math.Tan(angle)
						+
						(
						nilnul.num.real_.eg_._Tau4dblX.FULL
						- 4* angle
						-angle  /// make the last straight segment the same length as how far we are initially offshore; that is 1km; This makes it the same farness as the center of circle. So it's 90 - the two angles.
					)
						+ 1

					;
					return voyage;
				}

				var nearest = voyage_straight2shore(


				);

				Assert.IsTrue(nearest < trials4angles[1]);

			}
		}

	}
}
