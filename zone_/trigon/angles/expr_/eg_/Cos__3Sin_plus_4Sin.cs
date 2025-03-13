using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using static System.Diagnostics.Assert;

namespace nilnul.geometry.planar.zone_.trigon.angles.expr_.eg_
{
	/// <summary>
	/// optimize for min.
	/// </summary>
	///
	[TestClass]

	public class Cos__3Sin_plus_4Sin
	{

		static public double OfAngles(double x, double y, double z)
		{
			return Math.Cos(x) * (
				3 * Math.Sin(y) + 4 * Math.Sin(z)
			);

		}
		static public double OfAngles(double x, double y)
		{
			return OfAngles(x, Math.PI -x-y, y );



		}


		[TestMethod]
		public void MyTestMethod()
		{
			///

			Main(Math.PI /2 *1.2, Math.PI /2 *.5);
		}

		/// <summary>
		/// for a triangle of three angles: a, b,c;
		/// </summary>
		/// <param name="a"></param>
		/// <param name="c"></param>
		static void Main(double a, double c)
		{
			;

			double b = PI - a - c;

			var x =
				Cos(a) * (3 * Sin(b) + 4 * Sin(c))
				;	/// maximize that;
			var target = (double a,double b,double c) =>
				Cos(a) * (3 * Sin(b) + 4 * Sin(c))
				;


			x = Cos(a) * (3 * Sin( PI-a-c) +  4 * Sin(c))
				;
			x = Cos(a) * (
				3 * (
					Sin(a) * Cos(c) + Cos(a) * Sin(c)
				)
				+
				4 * Sin(c)
			);

			/// where:
			///
			//var y =
			_=
				3 * (
					Sin(a) * Cos(c) + Cos(a) * Sin(c)
				)
				+
				4 * Sin(c);

			_ = 3 * Cos(a) * Sin(c) + 3 * Sin(a) * Cos(c) + 4 * Sin(c)
				;

			var t2 = (3 * Cos(a) + 4) * Sin(c) + 3 * Sin(a) * Cos(c)
				

				;

			/// theorem: for vec x,y,  x.y le 

			var u =( (3 * Cos(a) + 4), 3*Sin(a) );
			var v = (Sin(c), Cos(c));

			var t1 = Sqrt( nilnul.geometry.planar.vect._ExtensionsX.Variance(u) *nilnul.geometry.planar.vect._ExtensionsX.Variance(v) );

			t1 = Sqrt( 25 + 24 * Cos(a) );

			bool condition = t2 <= t1;

			Assert.IsTrue (condition); // Cauthy Inequality;

			Assert.IsTrue (
				Cos(a) * t2 >= Cos(a) * t1
			);      /// as Cos(a) lt 0

			var t3 = Cos(a) * t1;
			 t3 = Cos(a) * Sqrt(25 + 24 * Cos(a));

			var t3_sq = nilnul.num.real.op_.Square.Singleton.op(Cos(a)) * (25 + 27 * Cos(a));
			;

			var t6 = Cos(a);

			t3_sq = t6*t6 * (25 + 24 *t6); /// where t6 in (-1,0)

			Func<double,double> f= t6 => nilnul.num.real.op_.Square.Singleton.op(t6) * (25 + 24 *t6);

			var dFdT = 72 * t6 * t6 + 50 * t6;



			/// when dFdT = 0, then:
			///
			var reflexPoint = -50d / 72;  /// cos(a)
			reflexPoint = -25d / 36;

			 reflexPoint = -25d / 36;

			/// f''
			///
			var fDeriv2 = 144 * t6 + 50; ///

			var fDeriv2_at_reflex = 144 * -25d / 36 + 50;

			fDeriv2_at_reflex = -50d;

			/// hence this is the max point
			///

			var max = f( reflexPoint);
			max = nilnul.num.real.op_.Square.Singleton.op(25d / 36) * 25d/3

				;

			var sqrtOfF = -Math.Sqrt(max);
			sqrtOfF = -125 * Sqrt(3) / 108;

			/// is this lowrbound attainable?
			///

			Func<double,bool> s= a=> Cos(a) == reflexPoint; // a is attainable;

			/// <see cref="condition"/>


			_=  (3 * Cos(a) + 4) / 3 * Sin(a) == Tan(c);

			_=  (3 * t6 + 4) / 3 * Math.Sqrt( 1-t6) == Tan(c);

			Func<double,double> ff= t6=>   (3 * t6 + 4) / 3 * Math.Sqrt( 1-t6) ;


			var tanC=ff(reflexPoint);

			var cAngle = Atan(tanC);

			var aAngle = Acos(reflexPoint);

			var bAngle = Math.PI - aAngle - cAngle;

			var total = aAngle + bAngle + cAngle;

			var targetValue = target(aAngle, bAngle, cAngle);

			

			






			/// as cos(a) lt 0
			///










		}




	}
}
