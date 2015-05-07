using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Siri
{
	public class FilePublisher : PublisherBase
	{
		StreamWriter sw;
		string toFile;


		public FilePublisher(string toFile)
			: base()
		{
			this.toFile = toFile;
		}

		public override void Open()
		{
			sw = new StreamWriter(toFile, false, Encoding.UTF8);
		}

		public override void Close()
		{
			sw.Close();
		}



		public override void WriteLine(string line)
		{
			sw.WriteLine(line);
		}

		public override void Write(string message)
		{
			sw.Write(message);
		}

		public override void Write(char c)
		{
			sw.Write(c);
		}

		public override void Write(int i)
		{
			sw.Write(i);
		}
	}
}
