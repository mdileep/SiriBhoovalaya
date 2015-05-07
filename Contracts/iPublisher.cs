using System;
using System.Collections.Generic;
using System.Text;

namespace Siri
{
	public interface iPublisher
	{
		void Publish(iInput input, iOutput output);

		void Open();
		void Close();

		void WriteLine(string line);
		void Write(string TAB);
		void Write(char c);
		void Write(int p);
	}
}
