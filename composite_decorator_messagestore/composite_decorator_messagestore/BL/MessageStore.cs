using composite_decorator_messagestore.Interfaces;
using System.IO;

namespace composite_decorator_messagestore
{
	class MessageStore
	{
		private readonly IFileLocator fileLocator;
		private readonly IStoreWriter writer;
		private readonly IStoreReader reader;

		public MessageStore(IStoreWriter writer,
			IStoreReader reader,
			IFileLocator fileLocator)
		{
			this.fileLocator = fileLocator;
			this.reader = reader;
			this.writer = writer;
		}

		public void Save(int id, string message)
		{
			this.writer.Save(id, message);
		}

		public Maybe<string> Read(int id)
		{
			return this.reader.Read(id);
		}

		public FileInfo GetFileInfo(int id)
		{
			return this.fileLocator.GetFileInfo(id);
		}
	}
}
