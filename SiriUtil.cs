using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Research.Services.Siri
{

	public class TestSiri
	{
		public void Run()
		{
			string input = "Dileep";
			int[] pattern1_3x3 = new int[] {
											1,2,3,
											4,5,6,
											7,8,9
										 };

			int[] pattern2_3x3 = new int[] {
											1,6,7,
											5,2,9,
											4,8,3
										 };
			int[] pattern_5x5 = new int[]{
											1,10,21,16,9,
											20,2,11,8,23,
											19,15,3,12,24,
											14,7,18,4,13,
											6,25,22,17,5,
										};
			int[] pattern1_27x27 = new int[] {
												1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,
												28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,
												55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,
												82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,
												109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,127,128,129,130,131,132,133,134,135,
												136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162,
												163,164,165,166,167,168,169,170,171,172,173,174,175,176,177,178,179,180,181,182,183,184,185,186,187,188,189,
												190,191,192,193,194,195,196,197,198,199,200,201,202,203,204,205,206,207,208,209,210,211,212,213,214,215,216,
												217,218,219,220,221,222,223,224,225,226,227,228,229,230,231,232,233,234,235,236,237,238,239,240,241,242,243,
												244,245,246,247,248,249,250,251,252,253,254,255,256,257,258,259,260,261,262,263,264,265,266,267,268,269,270,
												271,272,273,274,275,276,277,278,279,280,281,282,283,284,285,286,287,288,289,290,291,292,293,294,295,296,297,
												298,299,300,301,302,303,304,305,306,307,308,309,310,311,312,313,314,315,316,317,318,319,320,321,322,323,324,
												325,326,327,328,329,330,331,332,333,334,335,336,337,338,339,340,341,342,343,344,345,346,347,348,349,350,351,
												352,353,354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,369,370,371,372,373,374,375,376,377,378,
												379,380,381,382,383,384,385,386,387,388,389,390,391,392,393,394,395,396,397,398,399,400,401,402,403,404,405,
												406,407,408,409,410,411,412,413,414,415,416,417,418,419,420,421,422,423,424,425,426,427,428,429,430,431,432,
												433,434,435,436,437,438,439,440,441,442,443,444,445,446,447,448,449,450,451,452,453,454,455,456,457,458,459,
												460,461,462,463,464,465,466,467,468,469,470,471,472,473,474,475,476,477,478,479,480,481,482,483,484,485,486,
												487,488,489,490,491,492,493,494,495,496,497,498,499,500,501,502,503,504,505,506,507,508,509,510,511,512,513,
												514,515,516,517,518,519,520,521,522,523,524,525,526,527,528,529,530,531,532,533,534,535,536,537,538,539,540,
												541,542,543,544,545,546,547,548,549,550,551,552,553,554,555,556,557,558,559,560,561,562,563,564,565,566,567,
												568,569,570,571,572,573,574,575,576,577,578,579,580,581,582,583,584,585,586,587,588,589,590,591,592,593,594,
												595,596,597,598,599,600,601,602,603,604,605,606,607,608,609,610,611,612,613,614,615,616,617,618,619,620,621,
												622,623,624,625,626,627,628,629,630,631,632,633,634,635,636,637,638,639,640,641,642,643,644,645,646,647,648,
												649,650,651,652,653,654,655,656,657,658,659,660,661,662,663,664,665,666,667,668,669,670,671,672,673,674,675,
												676,677,678,679,680,681,682,683,684,685,686,687,688,689,690,691,692,693,694,695,696,697,698,699,700,701,702,
												703,704,705,706,707,708,709,710,711,712,713,714,715,716,717,718,719,720,721,722,723,724,725,726,727,728,729,
											 };

			int[] pattern2_27x27 = new int[] {
												1,0,19,20,21,0,39,40,41,0,59,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												2,0,18,0,22,0,38,0,42,0,58,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												3,0,17,0,23,0,37,0,43,0,57,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												4,0,16,0,24,0,36,0,44,0,56,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												5,0,15,0,25,0,35,0,45,0,55,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												6,0,14,0,26,0,34,0,46,0,54,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												7,0,13,0,27,0,33,0,47,0,53,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												8,0,12,0,28,0,32,0,48,0,52,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												9,10,11,0,29,30,31,0,49,50,51,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,0,0,0,133,134,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,0,0,0,132,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,0,0,0,131,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,0,0,128,129,130,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,0,124,125,0,0,126,127,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,120,121,0,0,0,0,122,123,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,118,0,0,0,0,0,0,119,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,114,115,0,0,0,0,0,0,116,117,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												100,101,102,103,104,105,106,107,108,109,110,111,112,113,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
												0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
											};


			SiriHelper.BuildValaya(input, pattern1_3x3);
			SiriHelper.BuildValaya(input, pattern2_3x3);
			SiriHelper.BuildValaya(input, pattern1_27x27);
			SiriHelper.BuildValaya(input, pattern2_27x27);


		}
	}
	public class SiriHelper
	{
		public static int[] BuildValaya(string input, int[] KeyPattern)
		{

			Validate(input, KeyPattern);


			PrintHelper.PrintLine(input);

			int[] output = new int[KeyPattern.Length];

			PrintHelper.PrintLine("Key Pattern: ");
			PrintHelper.Print(KeyPattern);

			char[] TextMatrix = BuildTextMatrix(input, KeyPattern);

			PrintHelper.PrintLine("Text matrix: ");
			PrintHelper.Print(TextMatrix);

			int[] Valaya = BuildValaya(TextMatrix);


			PrintHelper.PrintLine("Valaya: ");
			PrintHelper.Print(Valaya);

			return Valaya;


		}

		private static int[] BuildValaya(char[] TextMatrix)
		{
			int[] output = new int[TextMatrix.Length];
			int index = 0;
			foreach (char c in TextMatrix)
			{
				output[index++] = (int)c;
			}
			return output;
		}



		private static char[] BuildTextMatrix(string input, int[] KeyPattern)
		{
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

		private static void Validate(string input, int[] KeyPattern)
		{
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
	public class PrintHelper
	{
		const string SPACE = " ";
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
					Debug.Write(SPACE);
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
					Debug.Write(SPACE);
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
