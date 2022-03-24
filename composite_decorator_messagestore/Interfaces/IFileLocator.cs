using System.IO;

namespace composite_decorator_messagestore.Interfaces
{
	public interface IFileLocator
	{
		FileInfo GetFileInfo(int id);
	}
}
