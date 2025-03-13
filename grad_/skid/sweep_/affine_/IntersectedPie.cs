using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.edge.sweep_.affine_
{
	/// <see cref="planar.zone_.IPie"/>
	/// <summary>
	/// by SovietUnion Mathematician;
	/// two pies are intersected, such that one straight edge of a pie is parallel to a straight edge of the other pie.
	/// Then the moving stick(<see cref="planar.edge"/>) can move out of the staight edge to infinity, and then moves back (note the trail to infinity is long but 0 in area)
	/// ;
	/// By recurring infinitely, a fractal shape can be achieved. and the area is 0;
	/// </summary>
	/// <remarks>
	/// the dimension is still 2(as the fractal is 2dimensional by <see cref="geometry.planar.curve.stream_.fractal_."/>)?
	/// </remarks>
	class IntersectedPie
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		static public (C basis, C final) _Sweep_0nil2pi(double time)
		{
			throw new NotImplementedException();


		}
	}
}
