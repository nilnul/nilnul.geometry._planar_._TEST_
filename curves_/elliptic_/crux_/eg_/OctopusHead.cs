using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curves_.elliptic_.crux_.eg_
{
	internal class OctopusHead
	{
		static public bool Predicate(double x, double y) {
			return num.real.op_._CubicX.Cubic(x) - x+1 == y * y;
		}
	}
}
