using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo.Entity
{
	public abstract class LiveStock
	{
		public abstract string MakeSound();
		public abstract double GiveMilk();
		public virtual int GiveBirth()
		{
			return new Random().Next(1, 5);
		}	
	}
}
