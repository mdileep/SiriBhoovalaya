using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Siri
{
	public class DebugPublisher : PublisherBase
	{

		public override void Write(string message)
		{
			Debug.Write(message);
		}

		public override void Write(char c)
		{
			Debug.Write(c);
		}

		public override void Write(int i)
		{
			Debug.Write(i);
		}

		public override void WriteLine(string line)
		{
			Debug.WriteLine(line);
		}

		public override void Open()
		{
			WriteLine("START");
		}

		public override void Close()
		{
			WriteLine("END");
		}
	}
}
