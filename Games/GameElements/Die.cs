using GameElements.Interfaces;
using System;

namespace GameElements
{
	public class Die : IDie
	{
		private readonly int _sides;
		private int _value;
		private static Random _roller = new Random();

		public Die(int sides)
		{
			_sides = sides;
		}

		public int Sides => _sides;
		public int Value => _value;
	}
}
