using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curves_.elliptic_.bipartite_.eg_
{
	internal class CubicMinusLinear
	{
		/// <summary>
		/// an oval, and a <see cref="curve_.celestial_"/>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public bool Predicate(double x, double y) {
			return num.real.op_._CubicX.Cubic(x) - x == y * y;
		}
	}
}
