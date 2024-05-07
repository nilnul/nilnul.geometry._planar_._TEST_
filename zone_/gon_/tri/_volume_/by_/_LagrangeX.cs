using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.gon_.tri._volume_.by_
{
	internal class _LagrangeX
	{

		static public double Volume(
	Point4dblI a, Point4dblI b, Point4dblI c
)
		{
			double[,] matrix = new[,] {
				{a.x,a.y,1 }
				,
				{b.x,b.y,1 }
				,
				{c.x,c.y,1 }
				,

			}
			//[[a.x,a.y,a.z,1d]]

			;

			var determinant = nilnul.num.real.matrix_.square.to_.scalar_._DeterminantX._Determinant_assumeSquare(matrix);

			return determinant /
				2 // (BigInteger) nilnul.num.op_._FactorialX._Eval_byLoop(2)
			;
		}

	}
}
