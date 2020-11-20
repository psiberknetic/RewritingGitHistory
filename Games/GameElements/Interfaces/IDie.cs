using System;
using System.Collections.Generic;
using System.Text;

namespace GameElements.Interfaces
{
	interface IDie
	{
		int Sides { get; }
		int Value { get; }
		int Roll();
	}
}
