using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Siri
{
	public class PrintHelper
	{
		const string TAB = "\t";
		public static void Print(char[] TextMatrix)
		{
			if (!MathHelper.IsPerfectSqure(TextMatrix.Length))
			{
				throw new Exception("Only Square matrix is allowed");
			}

			int rows = (int)Math.Sqrt(TextMatrix.Length);

			Print(TextMatrix, rows, rows);

		}

		public static void Print(char[] CharMatrix, int rows, int cols)
		{
			int index = 0;
			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < cols; c++)
				{
					Debug.Write(CharMatrix[index]);
					Debug.Write(TAB);
					index++;
				}
				Debug.WriteLine(Environment.NewLine);
			}
		}

		public static void Print(int[] Matrix)
		{
			if (!MathHelper.IsPerfectSqure(Matrix.Length))
			{
				throw new Exception("Only Square matrix is allowed");
			}

			int rows = (int)Math.Sqrt(Matrix.Length);
			Print(Matrix, rows, rows);
		}

		public static void Print(int[] Matrix, int rows, int cols)
		{

			int index = 0;
			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < cols; c++)
				{
					Debug.Write(Matrix[index]);
					Debug.Write(TAB);
					index++;
				}
				Debug.WriteLine(Environment.NewLine);
			}
		}

		internal static void PrintLine(string line)
		{
			Debug.WriteLine(line);
		}
	}
}
