using composite_decorator_messagestore.Interfaces;

namespace composite_decorator_messagestore
{
	public class SQLStore : IStoreReader, IStoreWriter
	{

		public Maybe<string> Read(int id)
		{
			// reading from sql
			return new Maybe<string>();
		}

		public void Save(int id, string message)
		{
			// writing to sql
		}
	}
}
