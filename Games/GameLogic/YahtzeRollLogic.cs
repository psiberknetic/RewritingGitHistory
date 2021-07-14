using GameElements;
using GameElements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLogic
{
	public static class YahtzeRollLogic
	{
		static IEnumerable<IEnumerable<int>> _validSmallStraightValues = new[]
		{
			new[]{1,2,3,4},
			new[]{2,3,4,5},
			new[]{3,4,5,6}
		};

		public static bool IsValidYahtzeRoll(this IEnumerable<IDie> dice)
		{
			return dice.Count() == 5 && dice.All(d => d.Sides == 6);
		}

		public static bool IsLargeStraight(this IEnumerable<IDie> dice)
		{
			if (dice.IsValidYahtzeRoll())
			{
				return dice.GroupBy(d => d.Value).Count() == 5;
			}

			throw new ArgumentException("Not a valid Yahtze roll", nameof(dice));
		}

		public static bool IsSmallStraight(this IEnumerable<IDie> dice)
		{
			if (dice.IsValidYahtzeRoll())
			{
				return _validSmallStraightValues.Any(d => dice.Select(die => die.Value).OrderBy(val => val).Intersect(d).SequenceEqual(d));
			}

			throw new ArgumentException("Not a valid Yahtze roll", nameof(dice));
		}

		public static bool IsYahtze(this IEnumerable<IDie> dice)
		{
			if (dice.IsValidYahtzeRoll())
			{
				return dice.GroupBy(d => d.Value).Count() == 1;
			}

			throw new ArgumentException("Not a valid Yahtze roll", nameof(dice));
		}
		public static bool IsFullHouse(this IEnumerable<IDie> dice)
		{
			if (dice.IsValidYahtzeRoll())
			{
				return dice.GroupBy(d => d.Value).Count() == 2;
			}

			throw new ArgumentException("Not a valid Yahtze roll", nameof(dice));
		}

	}
}
