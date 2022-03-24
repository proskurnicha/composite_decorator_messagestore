namespace composite_decorator_messagestore.Interfaces
{
	public interface IStoreCache
	{
		void Save(int id, string message);
		Maybe<string> Read(int id);
	}
}
