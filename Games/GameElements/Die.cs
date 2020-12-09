using GameElements.Interfaces;
using System;

namespace GameElements
{
	public class Die : IDie
	{
		readonly int _sides;

		public Die(int sides)
		{
			_sides = sides;
		}

		public int Sides => _sides;

		public int Value => throw new NotImplementedException();

		public int Roll()
		{
			throw new NotImplementedException();
		}
	}
}
