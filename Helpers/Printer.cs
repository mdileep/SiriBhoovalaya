using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Siri
{
	public class Printer :IDisposable
	{
		const string TAB = "\t";
		private iPublisher Publisher;

		public Printer(iPublisher Publisher)
		{
			this.Publisher = Publisher;
			Publisher.Open();
		}

		public void Print(char[] TextMatrix)
		{
			if (!MathHelper.IsPerfectSqure(TextMatrix.Length))
			{
				throw new Exception("Only Square matrix is allowed");
			}

			int rows = (int)Math.Sqrt(TextMatrix.Length);

			Print(TextMatrix, rows, rows);

		}

		public void Print(char[] CharMatrix, int rows, int cols)
		{
			int index = 0;
			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < cols; c++)
				{
					Publisher.Write(CharMatrix[index]);
					Publisher.Write(TAB);
					index++;
				}
				Publisher.WriteLine(Environment.NewLine);
			}
		}

		public void Print(int[] Matrix)
		{
			if (!MathHelper.IsPerfectSqure(Matrix.Length))
			{
				throw new Exception("Only Square matrix is allowed");
			}

			int rows = (int)Math.Sqrt(Matrix.Length);
			Print(Matrix, rows, rows);
		}

		public void Print(int[] Matrix, int rows, int cols)
		{

			int index = 0;
			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < cols; c++)
				{
					Publisher.Write(Matrix[index]);
					Publisher.Write(TAB);
					index++;
				}
				Publisher.WriteLine(Environment.NewLine);
			}
		}

		public void PrintLine(string line)
		{
			Publisher.WriteLine(line);
		}

		public void Dispose()
		{
			Publisher.Close();
		}
	}
}
