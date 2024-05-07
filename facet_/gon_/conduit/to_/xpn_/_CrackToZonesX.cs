using nilnul.geometry.planar.cycle_.gon_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.geometry.planar.facet_.gon_.conduit.to_.xpn_
{
	/// when cutting <see cref="trihole_.UnitTest1.Facet"/>, we follow the edge of a hole first, then one hole is ended up an outclave of the resulted <see cref="flank_.gon_"/>, which a channel connteting to a hole.
	/// we need to follow the edge of the hull first. <see cref="facet_.gon_.conduit.to_._CrackToAdjacentZonesX"/>

	/// recursively find chords. but vs <see cref="planar.zone_.gon_.nontri._ChordX"/> which might cut off an ear of the hull, this will always cut by the connecting line from the hole to the hull
	///
	/// <summary>
	/// <see cref="gon_.conduit.of_._Coerce4dblX"/>
	/// </summary>
	/// <remarks>
	/// for one hole case, this works fine.
	/// for more than one holes,this might result more than two parts.
	/// for cutting into at most two parts, we need to conduit the holes, zigzagly some times in order to remain  inside the hull. That is complex for us now. Let's defer it:
	///		ensure it's in hull. so zigzag conduct is needed.
	///		ensure it's on vertex, not sides
	///		ensure conduit not blocked by other holes in between.
	///		the conduit might be a smooth curve, not only polyline.
	/// </remarks>
	/// alias:
	///		bifurcate
	///		slice
	///		fissure
	///		breach
	///
	[InWorking]
	static public class _CrackToAdjacentZonesX
	{

		/// <summary>
		/// apply the  algorithm recursively.
		/// </summary>
		/// <param name="_conduit">
		/// hull and holes connected by channels;
		/// </param>
		/// <param name="hole">the child</param>
		/// <returns></returns>
		private static (List<Point4dblI> first, List<Point4dblI> second) _CutHole(
			IEnumerable<Point4dblI> _conduit
			,
			 Point4dblI leftmost
			, Point4dblI[] hull
		)
		{




			var grads = cloze_.gon._Grads4dblX._Grads_ofStarted(hull)
				.ToArray() //keep the logic simple, make the debug nondistracted
				;

			///get the edge in the parent
			var parentEdge1pointCandidate = nilnul.objs_.started._MaxX.Max_assumeStarted(
				grads.Select(
					g => (
						grad: g
						,
						 vergeX:
planar.ray_.horizon_.decrease.vsGrad._NearestJoint.NearestJoint(
									leftmost
									,
									g
						)

					)
				).ToArray()
				,
				c => c.Item2
				,
				nilnul.num.real.nuly.comp_.NulMin4Dbl.Singleton
			);

			var parentEdgeRayed = new Point4dbl(parentEdge1pointCandidate.vergeX.Value, leftmost.y);

			//((cycle_.gon_.Antiwise4dbl, Point4dblI) child, (Grad4dbl_byPointsI g, double?) parentEdge1point) hole;
			(Grad4dbl_byPointsI, Point4dblI) parentEdge9point222;
			Point4dblI parentPoint;

			if (
				planar.point.EqDbl.Singleton.Equals(
					parentEdgeRayed
					,
					parentEdge1pointCandidate.Item1.basis
				)
			)
			{
				//((cycle_.gon_.Antiwise4dbl, Point4dblI) child, (Grad4dbl_byPointsI g, double?) parentEdge1point)
				parentEdge9point222 = (parentEdge1pointCandidate.grad, parentEdgeRayed);

				parentPoint = parentEdgeRayed;
			}
			else if (
				planar.point.EqDbl.Singleton.Equals(
					parentEdgeRayed
					,
					parentEdge1pointCandidate.Item1.finish
				)
			)
			{
				//var
				parentEdge9point222 =
				 (parentEdge1pointCandidate.grad, parentEdgeRayed);
				parentPoint = parentEdgeRayed;
			}
			else // if the intersection is not a vertex
			{

				var endPointOfParentEdgeRayed = parentEdge1pointCandidate.grad.basis.x
					<   // we need to keep the point left to the hole; otherwise, if the point is right to the hole's leftmost, this method's underlying logic would not hold.
					parentEdge1pointCandidate.Item1.finish.x
					? parentEdge1pointCandidate.grad.basis : parentEdge1pointCandidate.grad.finish;

				var insideVertexes =
					//_conduit	/// note here <see cref="conduit.of_._Coerce4dblX.Of(Gon4dbl)"/> would have only hull, but here the conduit including inner points.
					hull
				.Where(
					x =>
					zone_.gon.vsPoint.has_.byRay_._StokesIfIntersected.IsInPolygon(
						x
						,
						 nilnul.geometry.planar.zone_.TriangleDbl.OfByReorient(
							leftmost, parentEdgeRayed, endPointOfParentEdgeRayed
						)
					) != false
				)
				.ToArray()	//in once debug mode, the evaluation throws exception.
					;


				Point4dblI parentJointer = nilnul.objs_.started._MinX.Min_assumeStarted(
					insideVertexes
					,
					p => (
						Math.Abs(p.y - leftmost.y) / (p.x - leftmost.x)
						,
						planar.tend._VarianceX.Variance(p, leftmost) // if the angle is the same, we select the nearest. if there are two of the same angle and distance, either will be ok, as it is visible (a connection exists in the facet) to the hole.
					)
					,
					nilnul.num.real.co.Comp4dbl.Singleton
				);
				parentEdge9point222 = (parentEdge1pointCandidate.grad, parentJointer);
				parentPoint = parentJointer;
			}

			return newConduitPoints();

			// now slice the pair as whole.
			(List<Point4dblI> first, List<Point4dblI> second) newConduitPoints()
			{
				Point4dblI[] hullArray = _conduit.ToArray();
				/// let's get the hull first:
				///
				var indexOfHull = Array.IndexOf(
					hullArray
					,
					parentEdge9point222.Item2// by reference the default
					
				);

				var totalCount = hullArray.Length;//.Count();

				var first = new List<Point4dblI>();
				var second = new List<Point4dblI>();

				int i = indexOfHull;
				for (i = indexOfHull; i < totalCount + indexOfHull; i++)
				{
					var p = _conduit.ElementAt(i % totalCount);
					first.Add(p);

					if (
						geometry.planar.point.EqDbl.Eq(
							leftmost,p
						)
							//leftmost == p /// some eq values here is evaluated as not true;
					)
					{
						break; /// i++ not 
					}
				}

				//second.Add(leftmost); break out, would keep the i unchanged.

				for (; i < totalCount + indexOfHull; i++)
				{
					var p = _conduit.ElementAt(i % totalCount);

					second.Add(p);

					//yield return p;
					//if (parentEdge9point222.Item2 == p)
					//{
					//	break;
					//}

				}

				second.Add(parentEdge9point222.Item2);

				return (first, second);



			}
		}



		static public IEnumerable<IEnumerable<Point4dblI>> ToAdjacentZones(
			IEnumerable<Point4dblI> gon
		)
		{

			return splitRecur(gon);


			///
			IEnumerable<IEnumerable<Point4dblI>> splitRecur(
				IEnumerable<Point4dblI> conduit

			)
			{
				/// if the conduit without holes, just return it.
				///

				List<Grad4dbl_byPointsI> hull = planar.facet_.gon_.conduit._HullX._Hull_0conduit(conduit);


				var hullPoints = hull.Select(e => e.basis).ToArray();

				var childPoints = conduit.Except(
					hullPoints
					,
					planar.point.EqDbl.Singleton
				);

				if (childPoints.Any())
				{
					var innerMin = innerOfMinX(childPoints);

					var splited3 = _CutHole(
						conduit
						,
						innerMin
						,hullPoints
					);

					var f = splited3.first;
					return splitRecur(f).Concat(splitRecur(splited3.second));


				}
				return [conduit];
			}

			Point4dblI innerOfMinX(
			   IEnumerable<Point4dblI> innerPoints
		   )
			{
				return nilnul.objs_.started._MinX.Min_assumeStarted(
					innerPoints
					,
					t => t.x
					,
					nilnul.num.real.ComparerDbl.Singleton
				);
			}




		}
	}
}