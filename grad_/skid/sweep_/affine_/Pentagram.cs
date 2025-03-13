using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grad_.skid.sweep_.affine_0
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class Pentagram
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
		/// it's the caller's responsibility to gurantee the inputs are correst, in order for correct output. this algorithm cannot do anything that is outside its reach.
		public (C basis, C final) _Sweep_0nil2pi(double time)
		{

			/// the basis is at one tip.
			///

			var basis = C.FromPolarCoordinates(Radius, 0);

			/// rotates that
			///

			var final = basis + 

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
