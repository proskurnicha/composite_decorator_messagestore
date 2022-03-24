using System;

namespace Decorator
{
	public class FileDataSource : DataSource
	{
		public string FileName { get; set; }

		public FileDataSource(string filename)
		{
			FileName = filename;
		}

		public void ReadData()
		{
			Console.WriteLine("FileDataSource ReadData");
		}

		public void WriteData(string data)
		{
			Console.WriteLine("FileDataSource WriteData");
		}
	}
}
