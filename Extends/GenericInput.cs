using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Siri
{
	public class GenericInput : iInput
	{
		public string Input
		{
			get;
			set;
		}

		public int[] KeyPattern
		{
			get;
			set;
		}
	}
}
