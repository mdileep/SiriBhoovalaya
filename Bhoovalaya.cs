using System;
using System.Text;

namespace Siri
{
	public class Bhoovalaya
	{
		public static iOutput Encode(iInput Input,iCoding Coding, iPublisher Publisher)
		{
			Validate(Input);

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
		private static void Validate(iInput Input)
		{
			string input = Input.Input;
			int[] KeyPattern = Input.KeyPattern;

			if (KeyPattern == null)
			{
				throw new Exception("Key Pattern can't be null");
			}

			if (input == null)
			{
				throw new Exception("Input string or string for which valaya can't be null");
			}

			if (!MathHelper.IsPerfectSqure(KeyPattern.Length))
			{
				//Currently supporting Square matrix only
				//Rectangle patterns are supposed to be supported in near future.
				throw new Exception("Key Pattern legth should be a perfect square");
			}

			if (input.Length > KeyPattern.Length)
			{
				//Currently Long Strings are not supported.
				//i.e. for a Key pattern of 3*3 we can build valaya for string length max of 9.
				//actually we should allow matrix side by side. 
				//Say if input string of length 15 and Key matrix is 3*3 then
				//should prepare a first valaya for first 9 chars and sencond valaya with remaing string
				//then combine both valaya's to form (3*3) U (3*3) = either (4*4=Sqare) or (6*3=Rectangle) or (3*6=Rectangle)
				throw new Exception("Currently Long strings are not supported");
			}

			//Find if it has any duplicate or indexes out of range.
			int[] Test = new int[KeyPattern.Length];
			foreach (int x in Test)
			{
				Test[x] = 0;
			}

			foreach (int val in KeyPattern)
			{
				if (val < 0 || val > KeyPattern.Length)
				{
					throw new Exception("Invalid pattern");
				}
				if (val == 0)
				{
					continue;
				}
				if (Test[val - 1] != 0)
				{
					throw new Exception("Duplicate value found");
				}
				Test[val - 1] = 1;
			}
		}
	}
}
