using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.grid
{
	/// <summary>
	/// cellular automaton
	/// 0 players game: the initial condition determins the result; no interim input from a player is taken into account;
	/// </summary>
	internal class ConveyGameOfLife
	{
		/*
		 * 
	At each step in time, the following transitions occur:

Any live cell with fewer than two live neighbours dies, as if by underpopulation.
Any live cell with two or three live neighbours lives on to the next generation.
Any live cell with more than three live neighbours dies, as if by overpopulation.
Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.	 


		some subpatterns in a neiborhood are observed:
			1) still pattern, no change
		2) oscillating, like pulsar
		3) moving like spacecraft
		 
		 */
	}
}
