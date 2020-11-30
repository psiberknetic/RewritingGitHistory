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
	}
}
