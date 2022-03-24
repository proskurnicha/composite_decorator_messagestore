namespace Decorator
{
	public class DataSourceDecorator : DataSource
	{
		protected DataSource DataSource { get; set; }

		public DataSourceDecorator(DataSource dataSource)
		{
			DataSource = dataSource;
		}

		public virtual void ReadData()
		{
			DataSource.ReadData();
		}

		public virtual void WriteData(string data)
		{
			DataSource.WriteData("Data");
		}
	}
}
