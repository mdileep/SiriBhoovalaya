using System;
using System.Collections.Generic;
using System.Text;

namespace Siri
{
	public interface iInput
	{
		string Input { get; set; }
		int[] KeyPattern { get; set; }
	}
}
