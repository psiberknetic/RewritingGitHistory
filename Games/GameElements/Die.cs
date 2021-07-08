using GameElements.Interfaces;
using System;

namespace GameElements
{
	public class Die : IDie
	{
		private readonly int _sides;
		private int _value;
		private static Random _roller = new Random();

		public Die(int sdies)
		{
			_sides = sdies;

			Roll();
		}

		public int Sides => _sides;

		public int Value => _value;

		public int Roll()
		{
			_value = _roller.Next(1, _sides + 1);

			return Value;
		}
	}
}
