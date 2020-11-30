using System;
using System.Collections.Generic;
using System.Text;

namespace GameElements.Interfaces
{
	public interface IDie
	{
		int Sides { get; }
		int Value { get; }
	}
}
