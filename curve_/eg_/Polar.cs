using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.eg_
{
	class Polar
		: nilnul.geometry.planar._troll_.Fn4dblI
	{
		/// <summary>
		/// eg: a positive one. or a positive fractor|quotient such as 3/4
		/// </summary>
		private double periodic;


		public C locus(double time)
		{
			return C.FromPolarCoordinates(
				Math.Cos(
					periodic*time
				)
				,
				time
			);
		}
	}
}
