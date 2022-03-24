using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Decorator
{
    class Program
	{
		static void Main(string[] args)
		{
            var source = new FileDataSource("somefile.dat");
            source.WriteData("salaryRecords");
			Console.WriteLine("==============================================");

            var source2 = new CompressionDecorator(source);
            source2.WriteData("salaryRecords");
            Console.WriteLine("==============================================");

            var source3 = new EncryptionDecorator(source2);
            source3.WriteData("salaryRecords");
            Console.WriteLine("==============================================");

            var source4 = new ChangeDataDecorator(source3);
            source4.WriteData("salaryRecords");
            Console.WriteLine("==============================================");

            List<string> list = new List<string>() { "test", "test2" };
            list.Add("test3");
            ReadOnlyCollection<string> coll = new ReadOnlyCollection<string>(list);

            Console.ReadLine();
        }
    }
}
