using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.roulette_.cog_.hypo_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class Hypocycloid:curve_.roulette_.cog_.hypo_.IHypoCycloid
	{

		public double outerRadius;
		public double innerRadius;
		double velocity;
		double velocity1;

		/// <summary>
		/// the center of the moving circle. This is in fact the radius of the Fourier term.
		/// </summary>

		

		static public Hypocycloid OfRadii( double outerRadius,
		 double innerRadius)
		{
			return new Hypocycloid(
				outerRadius -innerRadius
				,
				1
				,
				innerRadius

				,
				(innerRadius -outerRadius  ) / innerRadius		/// tau * r / R = rotation of first
					/// the speed2nd =-( tau -rotation of first ).
					///		=- tau ( 1 -r/R) = tau (r-R) /R
					///
					///  the proportion:
					///		tau(r-R) /R   / (tau * r/R) = (r-R) /r
					///
					///	eg:
					///	when R =4, r =1,
					///	then  inner rotation =  (1-4)/1=3
			);


		}

		public Hypocycloid(
			double radius
			,
			double speed
			,
			double secondRadius
			,
			double speedSecond
		
		)
		{
			this.outerRadius = radius;
			this.velocity = speed;
			this.innerRadius = secondRadius;
			this.velocity1 = speedSecond;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		public C _Sweep_0nil2pi(double time)
		{

			return  C.FromPolarCoordinates(
				this.outerRadius, this.velocity*time)
				+ C.FromPolarCoordinates(this.innerRadius,this.velocity1*time);  ///fourier with only two complex terms added
			/// 0 the center
			/// +
			/// R 
		


	
		}

		///The area enclosed by a hypocycloid is given by:A=(k−1)(k−2)/ k^2 π R^2=(k−1)(k−2)π r^2
		///


		/// The arc length of a hypocycloid is given by:s=8(k−1)/k * R=8(k-1)r

	}
}
