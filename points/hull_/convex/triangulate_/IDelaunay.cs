using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.points.hull_.convex.triangulate_
{
	///en.wikipedia.org/wiki/Delaunay_triangulation
	/// <summary>
	/// In computational geometry, a Delaunay triangulation or Delone triangulation of a set of points in the plane subdivides their convex hull into triangles whose circumcircles do not contain any of the points. This maximizes the size of the smallest angle in any of the triangles, and tends to avoid sliver triangles.
	/// </summary>
	/// <remarks>
	///If the points all lie on a straight line, the notion of triangulation becomes degenerate and there is no Delaunay triangulation. For four or more points on the same circle (e.g., the vertices of a rectangle) the Delaunay triangulation is not unique: each of the two possible triangulations that split the quadrangle into two triangles satisfies the "Delaunay condition", i.e., the requirement that the circumcircles of all triangles have empty interiors.
	/// </remarks>
	internal class IDelaunay
	{
	}
}
