using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Siri
{
	class DebugPublisher : iPublisher
	{

		public void Publish(iInput Input, iOutput Output)
		{
			string input = Input.Input;
			int[] KeyPattern = Input.KeyPattern;
			using (Printer P = new Printer(this))
			{
				P.PrintLine(input);
				P.PrintLine("Key Pattern: ");
				P.Print(KeyPattern);
				P.PrintLine("Text matrix: ");
				P.Print(Output.TextMatrix);
				P.PrintLine("Valaya: ");
				P.Print(Output.Valaya);
			}
			
		}

		public void WriteLine(string line)
		{
			Debug.WriteLine(line);
		}

		public void Open()
		{
			WriteLine("START");
		}

		public void Close()
		{
			WriteLine("END");
		}

	}
}
