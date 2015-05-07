using System;
using System.Collections.Generic;
using System.Text;

namespace Siri
{
	public interface iPublisher
	{
		void Publish(iInput input, iOutput output);
		void WriteLine(string line);
		void Open();
		void Close();
	}
}
