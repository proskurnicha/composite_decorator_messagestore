using Serilog;
using composite_decorator_messagestore.Interfaces;
using System.Linq;

namespace composite_decorator_messagestore
{
	public class StoreLogger : IStoreWriter, IStoreReader
	{
		private readonly ILogger logger;
		private readonly IStoreWriter writer;
		private readonly IStoreReader reader;

		public StoreLogger(ILogger logger, 
			IStoreWriter writer,
			IStoreReader reader)
		{
			this.writer = writer;
			this.reader = reader;
		}

		public void Save(int id, string message)
		{
			this.logger.Information($"Saving message {id}");
			this.writer.Save(id, message);
			this.logger.Information($"Saved message {id}");
		}

		public Maybe<string> Read(int id)
		{
			this.logger.Debug($"Reading message {id}");
			var message = this.reader.Read(id);
			if (message.Any())
			{
				this.logger.Information($"Returning message {id}");
				return message;
			}

			this.logger.Debug($"No message {id} found");
			return new Maybe<string>();
		}
	}
}
