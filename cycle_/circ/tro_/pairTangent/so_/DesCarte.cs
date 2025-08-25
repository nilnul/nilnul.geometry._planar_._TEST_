namespace nilnul.geometry.planar.cycle_.circ.tro_.pairTangent.so_
{
	/// <summary>
	/// (a+b+c+d)^2 = 2 (a^2 + b^2 + c^2 + d^2)
	/// ,where a,b,c,d each is the signed curvature, the sign of which is determined by:
	///		: if two circs are tangent outside, the sign is positive. (thinking they are cogs to gear with each other rotating)
	///		: if one is inside, the sign is negative.
	/// </summary>
	/// if one circ is line, then curvature is 0:
	///  sqrt( d) = sqrt( a) +- sqrt( b)

	class DesCarte
	{

		///  (a x + b y + c z + d w)^2  == 2( (ax)^2 + (by)^2 + (cz)^2 + (dw)^2 )
		///  ,where a, b, c,d is signed curvature. and x,y,z,w is the center.
		///
		/// we can solve d at 1st step.
		///
		/// then we can solve w:
		///
		/// w = (
		///			ax + by + cz  (+-) 2 sqrt( ab xy + bx cz + cz ax   )
		///		) / d
		/// 
		/// 
	}


}
