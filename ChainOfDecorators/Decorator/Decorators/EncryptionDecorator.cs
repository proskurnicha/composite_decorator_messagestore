using System;

namespace Decorator
{
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(DataSource dataSource)
            : base(dataSource)
        { }

        public override void ReadData()
        {
            Console.WriteLine("Encrypt");
            base.ReadData();
        }

        public override void WriteData(string data)
        {
            Console.WriteLine("Encrypt");
            base.WriteData(data);
        }
    }
}
