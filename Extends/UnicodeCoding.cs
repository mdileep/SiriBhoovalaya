using System;
using System.Collections.Generic;
using System.Text;

namespace Siri
{
	class UnicodeCoding :iCoding
	{
		public iOutput BuildValaya(iInput input)
		{
			string _input = input.Input;
			int[] _keyPattern = input.KeyPattern;

			int[] iOutput = new int[_keyPattern.Length];

			char[] TextMatrix = Bhoovalaya.BuildTextMatrix(input);
			
			int[] Valaya = BuildValaya(TextMatrix);

			GenericOutput O = new GenericOutput();
			O.Valaya = Valaya;
			O.TextMatrix = TextMatrix;

			return O;
		}


		private int[] BuildValaya(char[] TextMatrix)
		{
			int[] output = new int[TextMatrix.Length];
			int index = 0;
			foreach (char c in TextMatrix)
			{
				output[index++] = (int)c;
			}
			return output;
		}
	}
}
