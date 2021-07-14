using GameElements.Interfaces;
using System;

namespace GameElements
{
	public class Die : IDie
	{
		private readonly int _sides;
		private int _value;

		public Die(int sides)
		{
			_sides = sides;
		}

		public int Sides => _sides;

		public int Value => _value;

		public int Roll()
		{
			throw new NotImplementedException();
		}
	}
}
