using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Entity
{
	public class Cow : LiveStock
	{
		public override double GiveMilk()
		{
			return new Random().NextDouble() * 20;
		}

		public override string MakeSound()
		{
			return "Cow";
		}
	}
}
