using System;
using System.Text;

namespace Siri
{
	public class Bhoovalaya
	{
		public static iOutput Encode(iInput Input,iCoding Coding, iPublisher Publisher)
		{
			Validator.Validate(Input);

			iOutput Valaya = Coding.BuildValaya(Input);
			
			Publisher.Publish(Input, Valaya);
			
			return Valaya;
		}

		public static char[] BuildTextMatrix(iInput Input)
		{
			string input = Input.Input;
			int[] KeyPattern = Input.KeyPattern;

			StringBuilder sb = new StringBuilder(KeyPattern.Length);
			foreach (int pos in KeyPattern)
			{
				if (pos > 0 && pos <= input.Length)
				{
					sb.Append(input[pos - 1]);
				}
				else
				{
					sb.Append((char)MathHelper.GetRandomNonZero());
				}
			}
			return sb.ToString().ToCharArray();
		}
	}
}
