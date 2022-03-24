namespace composite_decorator_messagestore.Interfaces
{
	public interface IStoreWriter
	{
		void Save(int id, string message);
	}
}
