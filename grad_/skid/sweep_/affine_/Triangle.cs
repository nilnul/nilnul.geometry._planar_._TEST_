using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.edge.sweep_.affine_
{
	/// <summary>
	/// </summary>
	class Triangle
	{
		/// <summary>
		/// the result is <see cref="planar.zone_.trigon_.IEquilateral"/>;
		/// the area is 1/2 * 2/ Sqrt(3) *1 = sqrt(3) /3
		/// </summary>
		/// <param name="time">
		/// from 0 to tau/2
		/// </param>
		/// <returns>
		///
		/// </returns>
		static public (C basis, C final) _Sweep_0nil2pi(double time)
		{

			const double sextant = Math.PI / 3;

			const double deg30 = sextant / 2;

			if (time < sextant)
			{
				return (
					C.Zero
					,
					C.FromPolarCoordinates(1, time)
				//time
				);
			}
			time -= sextant;
			var edgeLengthOfTrigon = 1 / Math.Cos(
				deg30
			);
			///we need to move the final
			///


			/// we need the height to be 1 such that the edge wouldnot exceed the trigon during rotate.
			/// then the edge of the trigon:
			///
			//var finale = C.FromPolarCoordinates(1, sextant);

			var finale = C.FromPolarCoordinates(edgeLengthOfTrigon, sextant); /// move away from origin

			if (time < sextant)
			{

				var final2basis = 0 - finale;

				return (
					finale + final2basis * C.FromPolarCoordinates(1, time)
					,
					finale /// the finale wouldnot change
				);

			}

			time -= sextant;

			var basis = new C(edgeLengthOfTrigon, 0);

			var vect = finale - basis;

			return (basis, basis + vect * C.FromPolarCoordinates(1, time));
		}
	}
}
