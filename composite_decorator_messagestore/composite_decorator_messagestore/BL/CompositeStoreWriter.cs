using composite_decorator_messagestore.Interfaces;

namespace composite_decorator_messagestore.BL
{
	public class CompositeStoreWriter : IStoreWriter
	{
		private readonly IStoreWriter[] storeWriters;

		public CompositeStoreWriter(params IStoreWriter[] storeWriters)
		{
			this.storeWriters = storeWriters;
		}

		public void Save(int id, string message)
		{
			foreach (var storeWriter in storeWriters)
			{
				storeWriter.Save(id, message);
			}
		}
	}
}
