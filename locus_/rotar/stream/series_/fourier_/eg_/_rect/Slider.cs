using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.loci_.rotar.stream.series_.fourier_.eg_._rect
{
	/// <summary>
	/// the stream
	/// </summary>
	/// <remarks>
	/// for the series, the y only would be square.
	/// </remarks>
	class Slider :
		nilnul.obj.stream_.SliderA<C>
		,
		nilnul.num.complex.stream_.Slider4dblI
	{
		/// <summary>
		/// 
		/// </summary>
		double odds = 1;
		public override C current =>  C.FromPolarCoordinates(
			1d/odds
			,

			t * odds
		);


		double t;

		public override void moveNext()
		{
			odds++;
		}

	}
}
