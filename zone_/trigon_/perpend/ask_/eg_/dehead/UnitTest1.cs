using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.vec.to_;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.geometry.planar.zone_.trigon_.perpend.ask_.eg_.dehead
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Extremes();
			T(1, 2);



		}

		public void T(double x, double y)
		{

			var f= (double x, double y) => x * x + y * y == 8 * 8;


			var f1= (double x, double y) => nilnul.num.real.op_.Square.Singleton.op( x +3) + nilnul.num.real.op_.Square.Singleton.op(y +3)  ==12*12;

			/// that means:
			///
			var  f2=  nilnul.num.real.op_.Square.Singleton.op( x) + 6*x + 9 + nilnul.num.real.op_.Square.Singleton.op(y ) + 6*y +9  ==12*12;


			 f2=  nilnul.num.real.op_.Square.Singleton.op( x) +  nilnul.num.real.op_.Square.Singleton.op(y )+ 6*x + 9  + 6*y +9  ==12*12;

			f2= 8*8+ 6*x + 9  + 6*y +9  ==12*12;

			var f5= (double x, double y) => 6*x   + 6*y + 8*8+9+ 9  ==12*12

			;
			f5 = (double x, double y) => 6 * (x +  y )  == 12 * 12 - (8 * 8 + 9 + 9) ;
			f5 = (double x, double y) => 6 * (x +  y )  == 144 -82;
			f5 = (double x, double y) =>  (x +  y )  == 62/6;
			f5 = (double x, double y) =>  (x +  y )  == 31/3;
			f5 = (double x, double y) =>  (x )  == 31/3-y;

			var a=   nilnul.num.real.op_.Square.Singleton.op(31/3-y)  + y * y == 8 * 8;

			a= 2 *y*y - 62/3*y + 31/3 * 31/3 == 64;
			a= 2 *y*y - 62 / 3 *y + 31/3 * 31/3-64 == 0;


			var solvent=nilnul.num.real.fn_.quadratic._SolveX._Solve_0nonnil(
				2,
				-62d/3
				,
				31d/3 * 31/3-64 
			);

			var str=solvent.ToStr5().Where(d=>d>=0).ToArray();


			Debug.WriteLine(
				nilnul.obj.str._PhraseX.Phrase(str)
			);

			var y1 = str.First();

			var x1 = 31d / 3 - y1;
			Debug.WriteLine(
				nilnul.obj.duo.Phrase.Unison.phrase(
					"x",x1
				)
			);



		}
		public void Extremes()
		{
			var x = 0;
			var y = 8;

			var biggerLeg = x + 3;
			var biggerLeg2 = y + 3;

			var hypotenuseSq = biggerLeg * biggerLeg + biggerLeg2 * biggerLeg2;

			var hypotenuse = Math.Sqrt(hypotenuseSq);
			Debug.WriteLine(
				hypotenuse  //11.4017542509914
			);	

			var x1 = Math.Sqrt(64/2 );
			var y1 =Math.Sqrt(64/2 ); 

			var biggerLeg1 = x1 + 3;
			var biggerLeg21 = y1 + 3;

			var hypotenuseSq1 = biggerLeg1 * biggerLeg1 + biggerLeg21 * biggerLeg21;


			Debug.WriteLine( Math.Sqrt( hypotenuseSq1 ));	



		}

	}
}
