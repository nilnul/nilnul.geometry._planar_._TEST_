using nilnul.geometry.planar.cycle_.gon.co_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.facet_.holed_
{
	public class Polygon
		:
		planar.facet_.holed_.Polygon4dbl
	{
		public Polygon() : base(
			new planar.zone_.rect_.OfFlexDbl
			0,0
			,
			20,0
			,
			20,10
			)
		)
		{
		}
	}
}
