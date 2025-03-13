using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.sweep_.affine_
{
	/// <summary>
	/// each edge is concave inward, nonstraight;
	/// </summary>
	/// <remarks>
	/// the area is Pi/8
	/// </remarks>
	/// <see cref="curve_.roulette_.cog_.Hypocycloid"/>
	public class InscribeTriangle
	{
		private const double Radius = 1d / 4;
		private const double HALF_SKID = 1d / 2;


		static readonly C centerOfLocus = new C();
		//static readonly C mid = centerOfLocus + Radius;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		public (C basis, C final) _Sweep_0nil2pi(double time)
		{
			/// the mid point of the grad moving along a circle;
			///



			/// the rotation speed of the skid is Pi / cycle
			///

			/// at time 0, the mid is at the bottom of the locus, a circle:
			/// let's take that position for the mid as the x-ray:
			///
			/// as the skid's mid is on the locus, when the basis is at a cusp vertex, the final is at the center of the opposite curl which is tangent to the circle thus the final is also on the locus. So the diameter of the circle is half.
			/// 
			///



			//double radius = Radius;
			//var radial = radius;


			//var basis = mid - radius;

			//var final =mid + radius;

			/// we can regard this as fourier series of only finite terms (finite fourier transform), and just add two complex numbers;


			var mid0 = C.FromPolarCoordinates( Radius, time );


			/// when the mid rotate for one round <see cref="rotation_.Turns"/>
			/// , the skid rotate for half round.
			/// That means for the same time, the skid rotates slower: 
			var skidRotation = - time /

				(2
				 //+1  /// by plus one, the ended curl is not closed.
				);

			///var half = 1d / 2;


			C mid2final = C.FromPolarCoordinates(HALF_SKID, skidRotation);
			var final0 = mid0 + mid2final;

			var basis0 = mid0 - mid2final;

			return (basis0,final0);


	
		}
	}
}
