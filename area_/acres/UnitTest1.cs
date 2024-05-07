using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.geometry.planar._area.unit_;
using nilnul.geometry.planar._area.unit_.eng_;
using nilnul.num;

namespace nilnul.geometry._planar_._TEST_.area_.acres
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var area = new nilnul.geometry.planar.Area<Hectare>(
				 17,
				 planar._area.unit_.Hectare.Singleton
				);

			var amountInAcres = area.amount *  planar._area.unit_.Hectare.Singleton.magnitude.ToReal() / planar._area.unit_.eng_.Acre.Singleton.magnitude ;


			var inAcres= new nilnul.geometry.planar.Area<Acre>(
				 amountInAcres
				 ,
				 planar._area.unit_.eng_.Acre.Singleton
			);

			 amountInAcres._Clamp2DigitsAftDot(4);
			var mid = amountInAcres.current.mid;

			var radixUncycle= nilnul.num.quotient_.radix_.Dec1.OvQuotient(mid,4);

			Debug.WriteLine(radixUncycle);
			return;

			var radix = nilnul.num.quotient_.radix.recur_.Dec.FroQuotient(mid);

			Debug.WriteLine(radix);

			return;

			var asQ = nilnul.num.real.to_.quotient_.radix_._DecX.ToDecRecur(amountInAcres,4);
			Debug.WriteLine(asQ);


		}
	}
}
