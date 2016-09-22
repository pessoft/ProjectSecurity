
using FileManager.Text;
namespace FileManager
{
    public class FileManager : IFileManger
    {
        public ITextWorker GetTextRW()
        {
            return new TextRW();
        }
    }
}
