using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.cycle_.polygon.co_
{
	public class Nondonut
	{
		public planar.cycle_.Polygon4dbl outer = new Polygon4dbl(
			0,0
			,
			20,0
			,
			20,20
		);
		public planar.zone_.Polygon4dblI inner = new planar.zone_.bloc_.Originated4dbl(
			20,10
		);

	}
}
