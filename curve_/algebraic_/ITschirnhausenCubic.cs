using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.curve_.algebraic_
{
	/// <summary>
	/// n algebraic geometry, the Tschirnhausen cubic, or Tschirnhaus' cubic is a plane curve defined, in its left-opening form, by the polar equation
	///		r = a * sec^3 (t/3)
	///
	/// where sec is the secant function.
	/// </summary>
	///

	static public class _TschirnhausenCubicX
	{
		static public double _Deviation_0coef_1azimuth(double coef, double azimuth) {
			return coef *
				nilnul.num.real.op_._CubicX.Cubic(
						/// secant
					1
					/
					Math.Cos(azimuth)
			);
		}
	}
	internal class ITschirnhausenCubic
	{

	}
}
