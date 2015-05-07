using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Siri
{
	public abstract class PublisherBase : iPublisher
	{
		public void Publish(iInput Input, iOutput Output)
		{
			string input = Input.Input;
			int[] KeyPattern = Input.KeyPattern;
			using (Printer P = new Printer(this))
			{
				P.PrintLine(input);
				P.PrintLine("");

				P.PrintLine("Key Pattern: ");
				P.PrintLine("");
				P.Print(KeyPattern);
				P.PrintLine("");

				P.PrintLine("Text matrix: ");
				P.PrintLine("");
				P.Print(Output.TextMatrix);
				P.PrintLine("");

				P.PrintLine("Valaya: ");
				P.PrintLine("");
				P.Print(Output.Valaya);
				P.PrintLine("");
			}

		}


		public virtual void Open()
		{
			//TODO..
		}

		public virtual void Close()
		{
			//TODO.. 
		}

		public virtual void WriteLine(string line)
		{
			//TODO..
		}

		public virtual void Write(string TAB)
		{
			//TODO..
		}

		public virtual void Write(char c)
		{
			//TODO..
		}

		public virtual void Write(int p)
		{
			//TODO..
		}
	}
}
