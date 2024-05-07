using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.geometry._planar_._TEST_.facet_.gon_.conduit_.minDistanceNotWork
{
	/// <summary>
	/// /nilnul.geometry._planar_/_KEN_(Git/facet_/holed_/gon/to_/_coil/TriangulationByEarClipping.pdf
	/// the min distance method might have a bug: the point with the minimal distance might result in a connection passing thru other edges.
	/// </summary>
	[TestClass]
	public class UnitTest1
	{
		/// <summary>
		/// see nilnul.img
		/// </summary>
		public System.Collections.Generic.IEnumerable<planar.Point4dblI> TestMethod1()
		{

			var facet = new nilnul.geometry.planar.facet_.Gon4dbl(
				new planar.cycle_.gon_.Facade4dbl(
						(71 , 89)
						,
						(665,-52)
						,
						(840,526)
						,
						(601,482)
						,
						(608,238)
						,
						(456,253)
						,
						(474,227)
						,
						(430,240	)
						,
						(565,160)

						,
						(319,251)
						,
						(342,597)
						,
						(138,572)
				)
				,
				new planar.cycle_.gon_.Antiwise4dbl(
					(292,164)
					,
					(188,268)
					,
					(275,495)
				)
			);

			var conduit = nilnul.geometry.planar.facet_.gon_.conduit.of_.coerce_.Of(
				facet
			);

			return conduit;


		}
	}
}
