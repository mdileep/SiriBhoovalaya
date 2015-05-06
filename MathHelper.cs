using System;
using System.Collections.Generic;
using System.Text;

namespace Siri
{
	public class MathHelper
	{
		public static bool IsPerfectSqure(int num)
		{
			int root = (int)Math.Sqrt(num);
			return (int)Math.Pow(root, 2) == num;
		}
		const int MAX = 255;
		static Random random = new Random();
		public static int GetRandomNonZero()
		{

			int r = 0;
			while (r == 0 || r == 13)
			{
				r = random.Next(MAX);
			}
			return r;
		}
	}
}
