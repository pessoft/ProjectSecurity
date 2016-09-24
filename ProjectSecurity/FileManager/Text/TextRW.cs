using System;
using System.IO;
using System.Text;

namespace FileManager.Text
{
    public class TextRW : ITextWorker
    {
        public string Open(string path)
        {
            var result = string.Empty;
            try
            {
                result = File.ReadAllText(path, Encoding.Default);
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }

        public bool Save(string path, string text)
        {
            var result = false;

            try
            {
                File.WriteAllText(path, text, Encoding.Unicode);
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }
    }
}
