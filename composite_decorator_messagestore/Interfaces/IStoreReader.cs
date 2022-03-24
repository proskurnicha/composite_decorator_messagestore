namespace composite_decorator_messagestore
{
	public interface IStoreReader
	{
		Maybe<string> Read(int id);
	}
}
