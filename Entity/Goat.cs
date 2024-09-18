using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Entity
{
	public class Goat : LiveStock
	{
		public override double GiveMilk()
		{
			return new Random().NextDouble() * 5;
		}

		public override string MakeSound()
		{
			return "Goat";
		}
	}
}
