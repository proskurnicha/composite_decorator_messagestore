using composite_decorator_messagestore.Interfaces;
using System;
using System.IO;

namespace composite_decorator_messagestore
{
	public class FileStore : IStoreReader, IFileLocator, IStoreWriter
	{
		public DirectoryInfo WorkingDirectory { get; private set; }

		public FileStore(DirectoryInfo workingDirectory)
		{
			if (workingDirectory == null)
			{
				throw new ArgumentNullException("workingDirectory");
			}
			if (!workingDirectory.Exists)
			{
				throw new ArgumentException("Boo", "workingDirectory");
			}
			WorkingDirectory = workingDirectory;
		}

		public void Save(int id, string message)
		{
			var path = GetFileInfo(id).FullName;
			File.WriteAllText(path, message);
		}

		public Maybe<string> Read(int id)
		{
			var file = GetFileInfo(id);

			if (!file.Exists)
			{
				return new Maybe<string>();
			}
			var path = file.FullName;
			return new Maybe<string>(File.ReadAllText(path));
		}

		public FileInfo GetFileInfo(int id)
		{
			return new FileInfo(Path.Combine(this.WorkingDirectory.FullName, id + ".txt"));
		}
	}
}
