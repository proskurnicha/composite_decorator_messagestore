using System;

namespace Decorator
{
    public class ChangeDataDecorator : DataSourceDecorator
    {
        public ChangeDataDecorator(DataSource dataSource)
            : base(dataSource)
        { }

        public override void ReadData()
        {
            Console.WriteLine("ChangeData");
            base.ReadData();
        }

        public override void WriteData(string data)
        {
            Console.WriteLine("ChangeData");
            base.WriteData(data);
        }
    }
}
