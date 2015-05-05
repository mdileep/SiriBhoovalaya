using Research.Services.Siri;
using System;
using System.Collections.Generic;
using System.Text;

namespace Siri
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.Title = "Siri Bhoovalaya-Stub";
			DateTime st = DateTime.Now;
			try
			{
				new TestSiri().Run();
			
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.Beep();
			}
			Console.WriteLine("----------------------------------");
			Console.WriteLine("Time taken(in Min):  " + (DateTime.Now - st).TotalMinutes.ToString("0.00"));
			Console.WriteLine("----------------DONE--------------");
			Console.Write("Press any Key to Exit.....");
			Console.ReadKey();
		}
	}
}
