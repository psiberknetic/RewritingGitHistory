using GameElements.Interfaces;
using GameLogic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;

namespace GameLogicTests
{
	[TestClass]
	public class YahtzeRollLogicTests
	{
		[TestMethod]
		public void RollsContainingNonSixSidedDice_NotValidYahtzeRoll()
		{
			var dice = Enumerable.Repeat(CreateMockDie(6), 4).Append(CreateMockDie(8));
			dice.IsValidYahtzeRoll().Should().BeFalse();
		}

		[TestMethod]
		public void RollsWithLessThanFiveDice_NotValidYahtzeRoll()
		{
			var dice = Enumerable.Repeat(CreateMockDie(6), 3);
			dice.IsValidYahtzeRoll().Should().BeFalse();
		}

		[TestMethod]
		public void RollsWithMoreThanFiveDice_NotValidYahtzeRoll()
		{
			var dice = Enumerable.Repeat(CreateMockDie(6), 12);
			dice.IsValidYahtzeRoll().Should().BeFalse();
		}

		[TestMethod]
		public void RollsWithFiveSixSidedDice_IsAValidYahtzeRoll()
		{
			var dice = Enumerable.Repeat(CreateMockDie(6), 5);
			dice.IsValidYahtzeRoll().Should().BeTrue();
		}

		[TestMethod]
		public void RollsWithAllTheSameNumber_IsAYahzte()
		{
			var dice = new[]
			{
				CreateMockDie(6,1),
				CreateMockDie(6,1),
				CreateMockDie(6,1),
				CreateMockDie(6,1),
				CreateMockDie(6,1)
			};

			dice.IsYahtze().Should().BeTrue();
		}

		[TestMethod]
		public void RollsWithDifferentNumbers_IsNotAYahzte()
		{
			var dice = new[]
			{
				CreateMockDie(6,1),
				CreateMockDie(6,1),
				CreateMockDie(6,3),
				CreateMockDie(6,1),
				CreateMockDie(6,1)
			};

			dice.IsYahtze().Should().BeFalse();
		}

		[TestMethod]
		public void RollsWithFiveDifferentValues_IsALargeStraight()
		{
			var dice = new[]
			{
				CreateMockDie(6,1),
				CreateMockDie(6,2),
				CreateMockDie(6,3),
				CreateMockDie(6,4),
				CreateMockDie(6,5)
			};

			dice.IsLargeStraight().Should().BeTrue();
		}

		[TestMethod]
		public void RollsWithoutFiveDifferentValues_IsNotALargeStraight()
		{
			var dice = new[]
			{
				CreateMockDie(6,1),
				CreateMockDie(6,1),
				CreateMockDie(6,6),
				CreateMockDie(6,4),
				CreateMockDie(6,6)
			};

			dice.IsLargeStraight().Should().BeFalse();
		}

		[TestMethod]
		public void RollsWith1234_IsSmallStraight()
		{
			var dice = new[]
			{
				CreateMockDie(6,1),
				CreateMockDie(6,2),
				CreateMockDie(6,3),
				CreateMockDie(6,4),
				CreateMockDie(6,1)
			};

			dice.IsSmallStraight().Should().BeTrue();
		}

		[TestMethod]
		public void RollsWith2345_IsSmallStraight()
		{
			var dice = new[]
			{
				CreateMockDie(6,5),
				CreateMockDie(6,2),
				CreateMockDie(6,3),
				CreateMockDie(6,4),
				CreateMockDie(6,2)
			};

			dice.IsSmallStraight().Should().BeTrue();
		}

		[TestMethod]
		public void RollsWith3456_IsSmallStraight()
		{
			var dice = new[]
			{
				CreateMockDie(6,5),
				CreateMockDie(6,1),
				CreateMockDie(6,3),
				CreateMockDie(6,4),
				CreateMockDie(6,6)
			};

			dice.IsSmallStraight().Should().BeTrue();
		}

		[TestMethod]
		public void RollsWith11265_IsNotSmallStraight()
		{
			var dice = new[]
			{
				CreateMockDie(6,1),
				CreateMockDie(6,1),
				CreateMockDie(6,2),
				CreateMockDie(6,5),
				CreateMockDie(6,6)
			};

			dice.IsSmallStraight().Should().BeFalse();
		}

		private IDie CreateMockDie(int sides)
		{
			return CreateMockDie(sides, 1);
		}

		private IDie CreateMockDie(int sides, int value)
		{
			var mockDie = new Mock<IDie>();
			mockDie.SetupGet(d => d.Sides).Returns(sides);
			mockDie.SetupGet(d => d.Value).Returns(value);
			mockDie.Setup(d => d.Roll()).Returns(value);


			return mockDie.Object;
		}
	}
}
