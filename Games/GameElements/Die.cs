using GameElements.Interfaces;
using System;

namespace GameElements
{
	public class Die : IDie
	{
		public Die(int sides)
		{
			Sides = sides;
		}

		public int Sides { get; }

		public int Value { get; }

		public int Roll()
		{
			throw new NotImplementedException();
		}
	}
}
