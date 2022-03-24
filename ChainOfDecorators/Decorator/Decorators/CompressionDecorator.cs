using System;

namespace Decorator
{
    public class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(DataSource dataSource)
            : base(dataSource)
        { }

        public override void ReadData()
        {
            Console.WriteLine("Compression");
            base.ReadData();
        }

        public override void WriteData(string data)
        {
            Console.WriteLine("Compression");
            base.WriteData(data);
        }
    }
}
