using GameElements.Interfaces;
using System;

namespace GameElements
{
	public class Die : IDie
	{
		readonly int _sdies;

		public Die(int sides)
		{
			_sdies = sides;
		}

		public int Sides => _sdies;

		public int Value => throw new NotImplementedException();

		public int Roll()
		{
			throw new NotImplementedException();
		}
	}
}
